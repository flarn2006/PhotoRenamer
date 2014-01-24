using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoRenamer
{
    public partial class MainForm : Form
    {
        private List<ImageEntry> images;
        private bool newNameGiven = false;

        public MainForm()
        {
            InitializeComponent();
            images = new List<ImageEntry>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void LoadImages()
        {
            if (openDlg.ShowDialog() == DialogResult.OK) {
                images.Clear();
                list.Items.Clear();
                foreach (string fileName in openDlg.FileNames) {
                    try {
                        ImageEntry entry = new ImageEntry(fileName);
                        images.Add(entry);
                        list.Items.Add(entry);
                    } catch (FileNotFoundException) {
                        // If a file doesn't exist, the user obviously won't care what name it has.
                        // This really shouldn't happen in the first place, but you never know.
                        continue;
                    }
                }
                progressBar.Minimum = 1;
                progressBar.Maximum = images.Count;
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            if (list.SelectedIndex >= 0) {
                // An image is selected
                progressBar.Value = list.SelectedIndex + 1;
                progressLabel.Text = String.Format("Image {0} of {1}", list.SelectedIndex + 1, images.Count);
                pictureBox.ImageLocation = images[list.SelectedIndex].FullName;
                newName.Enabled = true;
                tsbAccept.Enabled = true;
                tsbPrevImage.Enabled = (list.SelectedIndex > 0);
                tsbNextImage.Enabled = (list.SelectedIndex < list.Items.Count - 1);
                newName.Text = Path.GetFileNameWithoutExtension(images[list.SelectedIndex].Name);
            } else {
                // No image is selected
                progressBar.Value = 1;
                progressLabel.Text = "No image is selected.";
                pictureBox.ImageLocation = "";
                newName.Enabled = false;
                tsbAccept.Enabled = false;
                newName.Text = "";
            }

            tsbFirstImage.Enabled = tsbLastImage.Enabled = (list.Items.Count > 0);
            newNameGiven = false;
        }

        private void tsbLoadImages_Click(object sender, EventArgs e)
        {
            LoadImages();
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void tsbSizeToFit_Click(object sender, EventArgs e)
        {
            if (tsbSizeToFit.Checked) {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            } else {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void tsbFirstImage_Click(object sender, EventArgs e)
        {
            list.SelectedIndex = 0;
            UpdateDisplay();
        }

        private void tsbPrevImage_Click(object sender, EventArgs e)
        {
            list.SelectedIndex--;
            UpdateDisplay();
        }

        private void tsbNextImage_Click(object sender, EventArgs e)
        {
            list.SelectedIndex++;
            UpdateDisplay();
        }

        private void tsbLastImage_Click(object sender, EventArgs e)
        {
            list.SelectedIndex = list.Items.Count - 1;
            UpdateDisplay();
        }

        private void RemoveDuplicateListItems()
        {
            bool somethingWasDeleted = false;

            for (int i = 0; i < images.Count; i++) {
                if (list.SelectedIndex != i) {
                    if (list.SelectedItem.Equals(images[i])) {
                        images.RemoveAt(i);
                        list.Items.RemoveAt(i);
                        i--;
                        somethingWasDeleted = true;
                    }
                }
            }

            if (somethingWasDeleted) UpdateDisplay();
        }

        private void AcceptNewName()
        {
            bool cancel = false; // Set to true to re-select the name and let the user try again
            bool removeDuplicate = false;

            if (newNameGiven) {
                string oldPath = images[list.SelectedIndex].FullName;
                string newPath = Path.Combine(Path.GetDirectoryName(oldPath), newName.Text + Path.GetExtension(oldPath));

                // Check if the file still exists, and ask if the user wants to overwrite if necessary
                if (File.Exists(newPath)) {
                    string msg = String.Format("File {0} already exists. Do you want to overwrite it?", newPath);
                    if (MessageBox.Show(msg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                        try {
                            File.Delete(newPath);
                            removeDuplicate = true;
                        } catch (IOException ex) {
                            MessageBox.Show("Unable to overwrite file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cancel = true;
                        }
                    } else {
                        cancel = true;
                    }
                }

                if (!cancel) {
                    try {
                        File.Move(oldPath, newPath);
                        images[list.SelectedIndex] = new ImageEntry(newPath);
                        list.Items[list.SelectedIndex] = images[list.SelectedIndex];
                        if (removeDuplicate) RemoveDuplicateListItems();
                    } catch (IOException ex) {
                        // Show an error dialog and let the user give a new name or go to the next file.
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        cancel = true;
                    } catch (Exception ex) {
                        if (ex is ArgumentException || ex is NotSupportedException) {
                            // Same as above, but mention a likely cause for this specific problem.
                            string msg = ex.Message + "\r\nA filename cannot contain any of the following characters:\r\n\\ / : * ? \" < > |";
                            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cancel = true;
                        } else {
                            throw ex;
                        }
                    }
                }
            }

            if (cancel) {
                newName.Focus();
                newName.SelectAll();
            } else {
                if (list.SelectedIndex == list.Items.Count - 1) {
                    string msg = "That was the last image! Start over from the first image?";
                    if (MessageBox.Show(msg, "End of images", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                        list.SelectedIndex = 0;
                    }
                    UpdateDisplay();
                } else {
                    list.SelectedIndex++;
                    UpdateDisplay();
                    newName.Focus();
                    newName.SelectAll();
                }
            }
        }

        private void tsbAccept_Click(object sender, EventArgs e)
        {
            AcceptNewName();
        }

        private void newName_TextChanged(object sender, EventArgs e)
        {
            newNameGiven = true;
        }

        private void newName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') {
                AcceptNewName();
                e.Handled = true;
            } else {
                e.Handled = false;
            }
        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void newName_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Up) {
                if (tsbPrevImage.Enabled) {
                    list.SelectedIndex--;
                    UpdateDisplay();
                    newName.SelectAll();
                }
            } else if (e.KeyCode == Keys.Down) {
                if (tsbNextImage.Enabled) {
                    list.SelectedIndex++;
                    UpdateDisplay();
                    newName.SelectAll();
                }
            } else {
                e.Handled = false;
            }
            e.SuppressKeyPress = e.Handled;
        }
    }
}
