using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Parent : Form
    {       
        Child form2;

        public Parent()
        {
            InitializeComponent();

            form2 = new Child(this);
            form2.Show();
        }

        public void SetTextInParentTextBox(string text)
        {
            textBoxParent.Text = text;
        }

        private void textBoxParent_TextChanged(object sender, EventArgs e)
        {
            form2.SetTextInChildTextBox(textBoxParent.Text);
        }
    }
}
