﻿using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private void frmLauncher_Load(object sender, EventArgs e)
        {
            if (Singleton.Instance.UserModel.CurrentUser == null)
            {
                var result = new frmLogin().ShowDialog();
                var dresult = new DialogResult();
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {

                    if (Singleton.Instance.UserModel.CurrentUser.UserType == 1)
                    {
                        var main = new frmMain();
                        dresult = main.ShowDialog();
                    }
                    else
                    {
                        var user = new frmEndUser();
                        dresult = user.ShowDialog();
                    }
                    if (dresult != DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    else
                    {











                    }
                }
            }
        }
    }
}


