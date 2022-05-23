using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class ProfileForm : Form
    {
        ProfileClass profile = new ProfileClass();
        DBConnect connect = new DBConnect();
        LoginForm f1 = new LoginForm();

        public ProfileForm()
        {
            InitializeComponent();
        }

        public void ProfileForm_Load(object sender, EventArgs e)
        {
            label_fio.Text = ProfileClass.Repository.user.FIO;
            label_telephone.Text = ProfileClass.Repository.user.Telephone;
            label_mail.Text = ProfileClass.Repository.user.Mail;
            label_address.Text = ProfileClass.Repository.user.Address;
        }

        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label_PasswordRecovery_Click(object sender, EventArgs e)
        {
            RecoveryForm recovery = new RecoveryForm();
            recovery.Show();
            this.Hide();
        }
    }
}
