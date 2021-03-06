﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteBLL.DBOperate;
namespace NOTE
{
    public partial class Forget : Form
    {
        public Forget()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            UserFunction uf = new UserFunction();
            if (uf.Forget(this.UserNameTbx.Text, this.PasswordTbx.Text))
            {
                Modify m = new Modify(this.UserNameTbx.Text);
                m.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("输入错误");
            }
        }
    }
}
