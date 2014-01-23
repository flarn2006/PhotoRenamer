using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhotoRenamer
{
    class ImageEntry
    {
        private string fullName;

        public ImageEntry(string fullPath)
        {
            if (File.Exists(fullPath)) {
                this.fullName = fullPath;
            } else {
                throw new FileNotFoundException("File " + fullPath + " does not exist.");
            }
        }

        public string FullName
        {
            get { return fullName; }
        }

        public string Name
        {
            get { return Path.GetFileName(fullName); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
