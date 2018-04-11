using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mook_WinControl01
{
    public partial class Form1 : Form
    {

        private String id = "test1234";
        private String pw = "testpw12";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtId.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckData();
        }

        private void CheckData()
        {
            if (this.txtId.Text.Equals(id))
            {
                if (this.txtPwd.Text.Equals(pw))
                {
                    this.lblResult.Text = "로그인 성공.";
                } else
                {
                    this.lblResult.Text = "로그인 실패.";
                }
            } else
            {
                this.lblResult.Text = "로그인 실패.";
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.CheckData();
            }
        }
    }
}
