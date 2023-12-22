using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using E_CommerceSystem.Properties;
using MySql.Data.MySqlClient;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace E_CommerceSystem
{
    public partial class Intro : KryptonForm
    {
        public static int parentX, ParentY;
        public Intro()
        {

            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Config dbconfig = new Config();
            MySqlConnection conn = dbconfig.getConnection();
            Opacity += .2;

            if (introLoad.Value < 100)
            {
                introLoad.Value += 5;

                load_detail.Text = $"{introLoad.Value}%: Setting Up Graphical User Interfaces";

                if (introLoad.Value >= 50)
                {
                    load_detail.Text = $"{introLoad.Value}%: Fetching Database";
                }
                if (introLoad.Value >= 100) { load_detail.Text = $"Done!";}
            }

            else
            {
                timer1.Stop();
                this.Close();
                new Login().Show();
            }
        }
      
    }
}