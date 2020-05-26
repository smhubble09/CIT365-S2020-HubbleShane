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

            //Bind ComboBox with Enum
            MaterialBox.DataSource = System.Enum.GetValues(typeof(Enum.DesktopMaterial));

            //Populate Date
            QuoteDateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
            dq.setQuoteDate(QuoteDateLabel.Text);
        }
        //Main Menu
        MainMenu form = new MainMenu();
        private void MainMenu_Click(object sender, EventArgs e) {
            form.Show();
            this.Close();
        }
        private void MainMenu_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.M) {
                form.Show();
                this.Close();
            }
        }
        //Submit
        private void SubmitButton_Click(object sender, EventArgs e) {

            Close();
            form.Show();
        }
        private void SubmitButton_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.S) {
                Close();
                form.Show();
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

        //Highlight all text in boxes
        private void TabInEvent_Enter(object sender, EventArgs e) {
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

        //---------------------VALIDATION-------------------------------------------------
        Desk de = new Desk();
        DeskQuote dq = new DeskQuote();
        //NameBox Validation
        private void NameBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.ShiftKey || e.KeyChar == (char)Keys.Space);
        }
        private void NameBox_TextChanged(object sender, EventArgs e) {
            dq.setCustName(NameBox.Text); 
        }
        private void NameBox_Validating(object sender, CancelEventArgs e) {
            string errorMsg;
            if (!ValidName(NameBox.Text, out errorMsg)) {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                NameBox.Select(0, NameBox.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider3.SetError(NameBox, errorMsg);
            }
        }
        private void NameBox_Validated(object sender, EventArgs e) {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider3.SetError(NameBox, "");
        }
        public bool ValidName(string name, out string errorMessage) {
            if (NameBox.TextLength == 0) {//Confirm that the width box is not empty.
                errorMessage = "Required";
                return false;
            }
            else {
                errorMessage = null;
                return true;
            }
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

                else if (int.Parse(width) < de.getWMin() || int.Parse(width) > de.getWMax()) {//Number is between 24 and 96
                    errorMessage = "Please enter a number between 24 and 96";
                    return false;
                }
                else {
                    de.setWidth(int.Parse(WidthBox.Text));
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

            else if (int.Parse(depth) < de.getDMin() || int.Parse(depth) > de.getDMax()) {//Number is between 12 and 48
                errorMessage = "Please enter a number between 12 and 48";
                return false;
            }
            else {
                de.setDepth(int.Parse(DepthBox.Text));
                errorMessage = null;
                return true;
            }
        }

        //Find square inch
        private void WidthBox_TextChanged(object sender, EventArgs e) { 
            ReturnSqIn();
        }
        private void DepthBox_TextChanged(object sender, EventArgs e) {
            ReturnSqIn();
        }
        private void ReturnSqIn() {
            int width;
            int depth;
            if (int.TryParse(WidthBox.Text, out width) && int.TryParse(DepthBox.Text, out depth)) {
            int sqInt = width * depth;
                de.setWidth(width);
                de.setDepth(depth);
                SquareInLabel.Text = sqInt.ToString();
                if (sqInt > 1000) {//Display inches over 1,000
                    SizeOverageLabel.Text = (sqInt - 1000).ToString("#,##0") + " in²";
                    SizeCostLabel.Text = (sqInt - 1000).ToString("#,##0.00");
                    dq.SetExtraSizeCost(sqInt);
                }
                else {
                    dq.SetExtraSizeCost(0);
                    SizeOverageLabel.Text = "0 in²";
                    SizeCostLabel.Text = "0.00";
                }
            }
            TotalCost();
        }

        //Show Drawer Cost
        private void DrawerBox_ValueChanged(object sender, EventArgs e) {
            SetDrawers();
            SetDrawerPrice();
            TotalCost();
        }
        private void SetDrawers() {
            int drawers = Convert.ToInt32(DrawerBox.Value);
            de.setNumberDrawers(drawers);
        }
        private void SetDrawerPrice() {
            DrawerCostLabel.Text = dq.DrawerCost(de.getNumberDrawers()).ToString() + ".00";
        }

        //Show Material Cost
        private void MaterialBox_SelectedIndexChanged(object sender, EventArgs e) {
            SetMaterial();
            SetMaterialPrice();
            TotalCost();
        }
        private void SetMaterial() {
            de.setMaterial(MaterialBox.Text);
        }
        private void SetMaterialPrice() {
            MaterialCostLabel.Text = dq.MaterialCost(de.getMaterial()).ToString() + ".00";
        }

        //Show Rush Order
        private void RushBox_SelectedIndexChanged(object sender, EventArgs e) {
            ShippingCost();
            TotalCost();
        }
        private void ShippingCost() {
            dq.setRushDays(RushBox.SelectedIndex);
            int width;
            int depth;
            int sqInt;
            if (int.TryParse(WidthBox.Text, out width) && int.TryParse(DepthBox.Text, out depth)) {
                sqInt = width * depth;
                //dq.ShippingCost(sqInt);
                ShipCostLabel.Text = dq.ShippingCost(sqInt).ToString() + ".00";
            }
            else
                ShipCostLabel.Text = "0.00";
        }

        //Show Total Cost
        private void TotalCost() {
            dq.TotalCost();
            TotalCostLabel.Text = dq.getPrice().ToString("#,##0.00");
        }

        
    }
}
