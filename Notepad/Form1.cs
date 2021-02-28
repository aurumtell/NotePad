using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFile.Click += new EventHandler(open_button);
        }

        private void open_button(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string ChosenFile = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ChosenFile = openFileDialog1.FileName;
        }
    }
}
