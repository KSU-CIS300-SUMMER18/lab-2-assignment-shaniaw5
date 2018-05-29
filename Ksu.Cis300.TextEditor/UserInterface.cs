using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// GUI that allows files to be opened and saved
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens file dialog and allows to select a file to be opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
                            {
                string fn = uxOpenFileDialog.FileName;
                MessageBox.Show("Cannot Open File" + fn);
                            }
        }
        /// <summary>
        /// allows file and changes to be saved or displays error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSave_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
                           {
               string fn = uxSaveFileDialog.FileName;
               MessageBox.Show("Cannot Write to File" + fn);
                           }
        }
    }
}
