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
    public partial class Child : Form
    {
        Parent parent;

        public Child(Parent parentForm)
        {
            InitializeComponent();

            parent = parentForm;
        }

        public void SetTextInChildTextBox(string text)
        {
            textBoxChild.Text = text;
        }

        private void textBoxChild_TextChanged(object sender, EventArgs e)
        {
            parent.SetTextInParentTextBox(textBoxChild.Text);
        }
    }
}
