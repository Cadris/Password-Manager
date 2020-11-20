using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.Forms
{
    public partial class genPasswordForm : Form
    {
        public genPasswordForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fixedTextBoxEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (fixedTextBoxEnable.Checked == true)
                fixedTextBox.Enabled = true;
            else
                fixedTextBox.Enabled = false;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {            
            if(resultBox.Text.Equals(""))
            {
                MessageBox.Show("No Password to Copy.", "Error");
            }
            else
            {
                clipboardAction(sender,e);
            }            
        }

        private void clipboardAction(object sender, EventArgs e)
        {
            Clipboard.SetText(resultBox.Text);            
        }

        private void btnGenaratePassword_Click(object sender, EventArgs e)
        {
            String ans = genaratePassword();
            resultBox.Text = ans;
        }

        private string genaratePassword()
        {
            //throw new NotImplementedException();
            String ret = "",masterString="";

            if(checkNum.Checked==true)
            {
                masterString += "1234567890";                
            }
            if(checkSpecial.Checked==true)
            {
                masterString += "!@#$%^&*?-_";                
            }
            if(checkBlock.Checked==true)
            {
                masterString += "QWERTYUIOPASDFGHJKLZXCVBNM";                
            }
            if(checkSmall.Checked==true)
            {
                masterString += "qwertyuiopasdfghjklzxcvbnm";                
            }
            
            Random rn = new Random();
            for(int i=0;i< Convert.ToInt32(passwordLengthTBox.Text);i++)
            {
                ret = ret + masterString[rn.Next(0,masterString.Length)];
            }            

            return ret;
        }

        private void statusBar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Devoloped by Sayan Dasgupta","Dev Info");
        }

        private void checkNum_CheckedChanged(object sender, EventArgs e)
        {
            statusBar.Text = "Enable Numbers";
        }

        private void checkSpecial_CheckedChanged(object sender, EventArgs e)
        {
            statusBar.Text = "Enable Special Charecters";
        }

        private void checkBlock_CheckedChanged(object sender, EventArgs e)
        {
            statusBar.Text = "Enable Block Letters";
        }

        private void checkSmall_CheckedChanged(object sender, EventArgs e)
        {
            statusBar.Text = "Enable Block Letters";
        }
    }
}
