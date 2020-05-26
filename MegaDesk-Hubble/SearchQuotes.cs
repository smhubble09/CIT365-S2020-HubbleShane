using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hubble
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            //Bind ComboBox with Enum
            MaterialSearchBox.DataSource = System.Enum.GetValues(typeof(Enum.DesktopMaterial));

        }
        //Main Menu
        private void MainMenu_Click(object sender, EventArgs e) {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }
        private void MainMenu_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.M) {
                MainMenu form = new MainMenu();
                form.Show();
                this.Close();
            }
        }
        //Exit
        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void Exit_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.X) {
                Application.Exit();
            }
        }
    }
}
