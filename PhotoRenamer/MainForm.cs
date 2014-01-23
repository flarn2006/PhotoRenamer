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
        private ImageEntry[] images;
        private bool newNameGiven = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void LoadImages()
        {
            if (openDlg.ShowDialog() == DialogResult.OK) {
                images = new ImageEntry[openDlg.FileNames.Length];
                list.Items.Clear();
                for (int i = 0; i < openDlg.FileNames.Length; i++) {
                    try {
                        images[i] = new ImageEntry(openDlg.FileNames[i]);
                        list.Items.Add(images[i]);
                    } catch (FileNotFoundException) {
                        // If a file doesn't exist, the user obviously won't care what name it has.
                        continue;
                    }
                }
                progressBar.Minimum = 1;
                progressBar.Maximum = images.Length;
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            if (list.SelectedIndex >= 0) {
                // An image is selected
                progressBar.Value = list.SelectedIndex + 1;
                progressLabel.Text = String.Format("Image {0} of {1}", list.SelectedIndex + 1, images.Length);
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

        private void AcceptNewName()
        {
            if (newNameGiven) {
                string oldPath = images[list.SelectedIndex].FullName;
                string newPath = Path.Combine(Path.GetDirectoryName(oldPath), newName.Text + Path.GetExtension(oldPath));
                File.Move(oldPath, newPath);
                images[list.SelectedIndex] = new ImageEntry(newPath);
                list.Items[list.SelectedIndex] = images[list.SelectedIndex];
            }

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
