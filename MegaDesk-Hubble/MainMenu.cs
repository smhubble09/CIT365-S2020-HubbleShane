using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hubble{
    public partial class MainMenu : Form{
        public MainMenu(){
            InitializeComponent();
        }
        //New Quote
        private void NewQuote_Click(object sender, EventArgs e){
            AddQuote form = new AddQuote();
            form.Show();
            this.Hide();
        }
        private void NewQuote_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == (char)Keys.A) {
                AddQuote form = new AddQuote();
                form.Show();
                this.Hide();
            }
        }
        //View Quotes
        private void ViewQuote_Click(object sender, EventArgs e){
            ViewAllQuotes form = new ViewAllQuotes();
            form.Show();
            this.Hide();
        }
        private void ViewQuote_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.V) {
                ViewAllQuotes form = new ViewAllQuotes();
                form.Show();
                this.Hide();
            }
        }
        //Search Quote
        private void SearchQuote_Click(object sender, EventArgs e){
            SearchQuotes form = new SearchQuotes();
            form.Show();
            this.Hide();
        }
        private void SearchQuote_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.S) {
                SearchQuotes form = new SearchQuotes();
                form.Show();
                this.Hide();
            }
        }
        //Exit
        private void Exit_Click(object sender, EventArgs e){
            Application.Exit();
        }
        private void Exit_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == (char)Keys.X) {
                Application.Exit();
            }
        }
    }
}
