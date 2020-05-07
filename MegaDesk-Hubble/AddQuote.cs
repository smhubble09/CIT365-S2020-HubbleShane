using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hubble
{
    public partial class AddQuote : Form {
        public AddQuote() {
            InitializeComponent();

            //Populate Date
            QuoteDateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
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
        //Submit
        private void SubmitButton_Click(object sender, EventArgs e) {

        }
        private void SubmitButton_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.S) {

            }
        }
        //Exit
        private void Exit_Click(object sender, EventArgs e) {
            Close();
            Application.Exit();
        }
        private void Exit_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.X) {
                Application.Exit();
            }
        }

        //NameBox Validation
        private void NameBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.ShiftKey || e.KeyChar == (char)Keys.Space);
        }

        //WidthBox Validation
        private void WidthBox_Validating(object sender, CancelEventArgs e) {
            string errorMsg;
            if (!ValidWidth(WidthBox.Text, out errorMsg)) {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                WidthBox.Select(0, WidthBox.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(WidthBox, errorMsg);
            }
        }

        private void WidthBox_Validated(object sender, EventArgs e) {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(WidthBox, "");
        }

        public bool ValidWidth(string width, out string errorMessage) {
            try {
                if (WidthBox.TextLength == 0) {//Confirm that the width box is not empty.
                    errorMessage = "Required";
                    return false;
                }

                else if (int.Parse(width) < 24 || int.Parse(width) > 96) {//Number is between 24 and 96
                    errorMessage = "Please enter a number between 24 and 96";
                    return false;
                }
                else {
                    errorMessage = null;
                    return true;
                }
            }
            catch (FormatException) {//No letters
                errorMessage = "Please enter numbers only.";
                return false;
            }
        }
        
        //DepthBox KeyPress Validation
        private void DepthBox_KeyPress(object sender, KeyPressEventArgs e) {
            //Prevent letters from entering the control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }
        private void DepthBox_Validated(object sender, EventArgs e) {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider2.SetError(DepthBox, "");
        }
        private void DepthBox_Validating(object sender, CancelEventArgs e) {
            string errorMsg;
            if (!ValidDepth(DepthBox.Text, out errorMsg)) {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                DepthBox.Select(0, DepthBox.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider2.SetError(DepthBox, errorMsg);
            }
        }
        public bool ValidDepth(string depth, out string errorMessage) {
            if (DepthBox.TextLength == 0) {//Confirm that the width box is not empty.
                errorMessage = "Required";
                return false;
            }

            else if (int.Parse(depth) < 12 || int.Parse(depth) > 48) {//Number is between 12 and 48
                errorMessage = "Please enter a number between 12 and 48";
                return false;
            }
            else {
                errorMessage = null;
                return true;
            }
        }

        //Find square inch
        private void WidthBox_TextChanged(object sender, EventArgs e) {
            returnSqIn();
        }
        private void DepthBox_TextChanged(object sender, EventArgs e) {
            returnSqIn();
        }
        private void returnSqIn() {
            int width;
            int depth;
            if (int.TryParse(WidthBox.Text, out width) && int.TryParse(DepthBox.Text, out depth)) {
                int sqInt = width * depth;
                SquareInLabel.Text = sqInt.ToString();
                if (sqInt > 1000) {//Display inches over 1,000
                    SizeOverageLabel.Text = (sqInt - 1000).ToString() + " in²";
                    SizeCostLabel.Text = (sqInt - 1000).ToString() + ".00";
                }
                else {
                    SizeOverageLabel.Text = "0 in²";
                    SizeCostLabel.Text = "0.00";
                }
            }
            TotalCost();
        }

        //Calculate Drawer Cost
        private void DrawerBox_ValueChanged(object sender, EventArgs e) {
            DrawerCost();
        }
        private void DrawerCost() {
            int drawers = Convert.ToInt32(DrawerBox.Value);
            int drawerPrice = drawers * 50;
            DrawerCostLabel.Text = drawerPrice.ToString() + ".00";
            TotalCost();
        }

        //Calculate Material Cost
        private void MaterialBox_SelectedIndexChanged(object sender, EventArgs e) {
            MaterialCost();
        }
        private void MaterialCost() {
            //var material = Enum.DesktopMaterial();
            switch (MaterialBox.SelectedIndex) {
                case 0://Oak
                    MaterialCostLabel.Text = "200.00";
                    break;
                case 1://Laminate
                    MaterialCostLabel.Text = "100.00";
                    break;
                case 2://Pine
                    MaterialCostLabel.Text = "50.00";
                    break;
                case 3://Rosewood
                    MaterialCostLabel.Text = "300.00";
                    break;
                case 4://Veneer
                    MaterialCostLabel.Text = "125.00";
                    break;
            }
            TotalCost();
        }

        //Calculate Rush Order
        private void RushBox_SelectedIndexChanged(object sender, EventArgs e) {
            ShippingCost();
        }
        private void ShippingCost() {
            int width;
            int depth;
            int sqInt;
            if (int.TryParse(WidthBox.Text, out width) && int.TryParse(DepthBox.Text, out depth)) {
                sqInt = width * depth;
                switch (RushBox.SelectedIndex) {
                    case 0://3 Day
                        if (sqInt < 1000)
                            ShipCostLabel.Text = "60.00";
                        else if (sqInt > 2000)
                            ShipCostLabel.Text = "80.00";
                        else
                            ShipCostLabel.Text = "70.00";
                        break;
                    case 1://5 Day
                        if (sqInt < 1000)
                            ShipCostLabel.Text = "40.00";
                        else if (sqInt > 2000)
                            ShipCostLabel.Text = "60.00";
                        else
                            ShipCostLabel.Text = "50.00";
                        break;
                    case 2://7 Day
                        if (sqInt < 1000)
                            ShipCostLabel.Text = "30.00";
                        else if (sqInt > 2000)
                            ShipCostLabel.Text = "40.00";
                        else
                            ShipCostLabel.Text = "35.00";
                        break;
                    case 3://Normal
                        ShipCostLabel.Text = "0.00";
                        break;
                }
            }
            else
                ShipCostLabel.Text = "0.00";
            TotalCost();
        }

        //Show Total Cost
        private void TotalCost() {
            double shipping = double.Parse(ShipCostLabel.Text);
            double material = double.Parse(MaterialCostLabel.Text);
            double drawer = double.Parse(DrawerCostLabel.Text);
            double size = double.Parse(SizeCostLabel.Text);
            double total = shipping + material + drawer + size + 200;
            TotalCostLabel.Text = total.ToString() + ".00";
        }

        //Highlight all text in boxes
        private void tabInEvent_Enter(object sender, EventArgs e) {
            //Select the whole answer in the control.
            NumericUpDown answerBox = sender as NumericUpDown;
            TextBox answerBox2 = sender as TextBox;
            if (answerBox != null) {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
            else if (answerBox2 != null) {
                int lengthOfAnswer = answerBox2.Text.Length;
                answerBox2.Select(0, lengthOfAnswer);
            }
        }

    }
}
