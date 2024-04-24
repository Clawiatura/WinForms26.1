using System.ComponentModel.Design;

namespace WinForms26._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbmark1_CheckedChanged(object sender, EventArgs e)
        {
            cbmark1.Enabled = false;
            
        }

        private void cbmark2_CheckedChanged(object sender, EventArgs e)
        {
            
            cbmark2.Enabled = false;
            
        }

        private void cbmark3_CheckedChanged(object sender, EventArgs e)
        {
            
            cbmark3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbmark1.Enabled == false) 
            {
                btres.Text = " Выбрана Галочка № 1 ";
            }
            else if (cbmark2.Enabled == false)
            {
                btres.Text = " Выбрана Галочка № 2";
            }
            else if (cbmark3.Enabled == false)
            {
                btres.Text = " Выбрана Галочка № 3";
            }
            else 
             btres.Text = " Ничего не выбрано";
        }
    }
}
