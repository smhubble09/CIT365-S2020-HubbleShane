using System.Reflection;

namespace MegaDesk_Hubble
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MaterialBox = new System.Windows.Forms.ComboBox();
            this.RushBox = new System.Windows.Forms.ComboBox();
            this.DrawerBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.SquareInLabel = new System.Windows.Forms.Label();
            this.groupBoxSpec = new System.Windows.Forms.GroupBox();
            this.groupBoxShip = new System.Windows.Forms.GroupBox();
            this.groupBoxQuote = new System.Windows.Forms.GroupBox();
            this.QuoteDateLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.ShipCostLabel = new System.Windows.Forms.Label();
            this.MaterialCostLabel = new System.Windows.Forms.Label();
            this.DrawerCostLabel = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.SizeCostLabel = new System.Windows.Forms.Label();
            this.SizeOverageLabel = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxSpec.SuspendLayout();
            this.groupBoxShip.SuspendLayout();
            this.groupBoxQuote.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(21, 463);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(100, 28);
            this.mainMenu.TabIndex = 8;
            this.mainMenu.Text = "&Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            this.mainMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainMenu_KeyPress);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(237, 463);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 28);
            this.exit.TabIndex = 9;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            this.exit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Exit_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(189, 11);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(187, 26);
            this.NameBox.TabIndex = 0;
            this.NameBox.Enter += new System.EventHandler(this.tabInEvent_Enter);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desk Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desk Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Drawers";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(129, 463);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 28);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "&Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.SubmitButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubmitButton_KeyPress);
            // 
            // MaterialBox
            // 
            this.MaterialBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.MaterialBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MaterialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialBox.FormattingEnabled = true;
            this.MaterialBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.MaterialBox.Location = new System.Drawing.Point(133, 74);
            this.MaterialBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(132, 28);
            this.MaterialBox.TabIndex = 4;
            this.MaterialBox.SelectedIndexChanged += new System.EventHandler(this.MaterialBox_SelectedIndexChanged);
            // 
            // RushBox
            // 
            this.RushBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.RushBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RushBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushBox.FormattingEnabled = true;
            this.RushBox.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "Normal - 14 Days"});
            this.RushBox.Location = new System.Drawing.Point(131, 37);
            this.RushBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RushBox.Name = "RushBox";
            this.RushBox.Size = new System.Drawing.Size(171, 28);
            this.RushBox.TabIndex = 5;
            this.RushBox.SelectedIndexChanged += new System.EventHandler(this.RushBox_SelectedIndexChanged);
            // 
            // DrawerBox
            // 
            this.DrawerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerBox.Location = new System.Drawing.Point(137, 31);
            this.DrawerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawerBox.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawerBox.Name = "DrawerBox";
            this.DrawerBox.Size = new System.Drawing.Size(68, 26);
            this.DrawerBox.TabIndex = 3;
            this.DrawerBox.ValueChanged += new System.EventHandler(this.DrawerBox_ValueChanged);
            this.DrawerBox.Enter += new System.EventHandler(this.tabInEvent_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Inches";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Inches";
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconPadding(this.WidthBox, -65);
            this.WidthBox.Location = new System.Drawing.Point(172, 26);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(64, 26);
            this.WidthBox.TabIndex = 1;
            this.WidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthBox_TextChanged);
            this.WidthBox.Enter += new System.EventHandler(this.tabInEvent_Enter);
            this.WidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            this.WidthBox.Validated += new System.EventHandler(this.WidthBox_Validated);
            // 
            // DepthBox
            // 
            this.DepthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider2.SetIconPadding(this.DepthBox, -65);
            this.DepthBox.Location = new System.Drawing.Point(172, 71);
            this.DepthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(64, 26);
            this.DepthBox.TabIndex = 2;
            this.DepthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DepthBox.TextChanged += new System.EventHandler(this.DepthBox_TextChanged);
            this.DepthBox.Enter += new System.EventHandler(this.tabInEvent_Enter);
            this.DepthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthBox_KeyPress);
            this.DepthBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthBox_Validating);
            this.DepthBox.Validated += new System.EventHandler(this.DepthBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(244, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Inches²";
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.SquareInLabel);
            this.groupBoxSize.Controls.Add(this.label2);
            this.groupBoxSize.Controls.Add(this.label11);
            this.groupBoxSize.Controls.Add(this.label3);
            this.groupBoxSize.Controls.Add(this.label10);
            this.groupBoxSize.Controls.Add(this.WidthBox);
            this.groupBoxSize.Controls.Add(this.DepthBox);
            this.groupBoxSize.Controls.Add(this.label8);
            this.groupBoxSize.Controls.Add(this.label9);
            this.groupBoxSize.Location = new System.Drawing.Point(21, 48);
            this.groupBoxSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSize.Size = new System.Drawing.Size(356, 150);
            this.groupBoxSize.TabIndex = 1;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // SquareInLabel
            // 
            this.SquareInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareInLabel.Location = new System.Drawing.Point(172, 108);
            this.SquareInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SquareInLabel.Name = "SquareInLabel";
            this.SquareInLabel.Size = new System.Drawing.Size(65, 28);
            this.SquareInLabel.TabIndex = 23;
            this.SquareInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxSpec
            // 
            this.groupBoxSpec.Controls.Add(this.label6);
            this.groupBoxSpec.Controls.Add(this.DrawerBox);
            this.groupBoxSpec.Controls.Add(this.label5);
            this.groupBoxSpec.Controls.Add(this.MaterialBox);
            this.groupBoxSpec.Location = new System.Drawing.Point(21, 217);
            this.groupBoxSpec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSpec.Name = "groupBoxSpec";
            this.groupBoxSpec.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSpec.Size = new System.Drawing.Size(356, 132);
            this.groupBoxSpec.TabIndex = 2;
            this.groupBoxSpec.TabStop = false;
            this.groupBoxSpec.Text = "Specifications";
            // 
            // groupBoxShip
            // 
            this.groupBoxShip.Controls.Add(this.label4);
            this.groupBoxShip.Controls.Add(this.RushBox);
            this.groupBoxShip.Location = new System.Drawing.Point(21, 370);
            this.groupBoxShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxShip.Name = "groupBoxShip";
            this.groupBoxShip.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxShip.Size = new System.Drawing.Size(356, 85);
            this.groupBoxShip.TabIndex = 3;
            this.groupBoxShip.TabStop = false;
            this.groupBoxShip.Text = "Shipping";
            // 
            // groupBoxQuote
            // 
            this.groupBoxQuote.Controls.Add(this.QuoteDateLabel);
            this.groupBoxQuote.Controls.Add(this.label22);
            this.groupBoxQuote.Controls.Add(this.TotalCostLabel);
            this.groupBoxQuote.Controls.Add(this.ShipCostLabel);
            this.groupBoxQuote.Controls.Add(this.MaterialCostLabel);
            this.groupBoxQuote.Controls.Add(this.DrawerCostLabel);
            this.groupBoxQuote.Controls.Add(this.label36);
            this.groupBoxQuote.Controls.Add(this.SizeCostLabel);
            this.groupBoxQuote.Controls.Add(this.SizeOverageLabel);
            this.groupBoxQuote.Controls.Add(this.label33);
            this.groupBoxQuote.Controls.Add(this.label32);
            this.groupBoxQuote.Controls.Add(this.label31);
            this.groupBoxQuote.Controls.Add(this.label27);
            this.groupBoxQuote.Controls.Add(this.label28);
            this.groupBoxQuote.Controls.Add(this.label29);
            this.groupBoxQuote.Controls.Add(this.label30);
            this.groupBoxQuote.Controls.Add(this.label24);
            this.groupBoxQuote.Controls.Add(this.label25);
            this.groupBoxQuote.Controls.Add(this.label23);
            this.groupBoxQuote.Controls.Add(this.label17);
            this.groupBoxQuote.Controls.Add(this.label18);
            this.groupBoxQuote.Controls.Add(this.label19);
            this.groupBoxQuote.Controls.Add(this.label20);
            this.groupBoxQuote.Controls.Add(this.label21);
            this.groupBoxQuote.Controls.Add(this.label14);
            this.groupBoxQuote.Controls.Add(this.label15);
            this.groupBoxQuote.Controls.Add(this.label16);
            this.groupBoxQuote.Controls.Add(this.label13);
            this.groupBoxQuote.Controls.Add(this.label12);
            this.groupBoxQuote.Controls.Add(this.label7);
            this.groupBoxQuote.Location = new System.Drawing.Point(403, 11);
            this.groupBoxQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxQuote.Name = "groupBoxQuote";
            this.groupBoxQuote.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxQuote.Size = new System.Drawing.Size(352, 480);
            this.groupBoxQuote.TabIndex = 26;
            this.groupBoxQuote.TabStop = false;
            this.groupBoxQuote.Text = "Quote";
            // 
            // QuoteDateLabel
            // 
            this.QuoteDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDateLabel.Location = new System.Drawing.Point(212, 14);
            this.QuoteDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuoteDateLabel.Name = "QuoteDateLabel";
            this.QuoteDateLabel.Size = new System.Drawing.Size(123, 42);
            this.QuoteDateLabel.TabIndex = 31;
            this.QuoteDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(89, 14);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 42);
            this.label22.TabIndex = 30;
            this.label22.Text = "Quote Date";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(251, 432);
            this.TotalCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(84, 42);
            this.TotalCostLabel.TabIndex = 29;
            this.TotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShipCostLabel
            // 
            this.ShipCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipCostLabel.Location = new System.Drawing.Point(251, 390);
            this.ShipCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShipCostLabel.Name = "ShipCostLabel";
            this.ShipCostLabel.Size = new System.Drawing.Size(84, 42);
            this.ShipCostLabel.TabIndex = 28;
            this.ShipCostLabel.Text = "0.00";
            this.ShipCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaterialCostLabel
            // 
            this.MaterialCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialCostLabel.Location = new System.Drawing.Point(251, 348);
            this.MaterialCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaterialCostLabel.Name = "MaterialCostLabel";
            this.MaterialCostLabel.Size = new System.Drawing.Size(84, 42);
            this.MaterialCostLabel.TabIndex = 27;
            this.MaterialCostLabel.Text = "0.00";
            this.MaterialCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrawerCostLabel
            // 
            this.DrawerCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerCostLabel.Location = new System.Drawing.Point(251, 306);
            this.DrawerCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrawerCostLabel.Name = "DrawerCostLabel";
            this.DrawerCostLabel.Size = new System.Drawing.Size(84, 42);
            this.DrawerCostLabel.TabIndex = 26;
            this.DrawerCostLabel.Text = "0.00";
            this.DrawerCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(251, 265);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(84, 42);
            this.label36.TabIndex = 25;
            this.label36.Text = "50.00";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizeCostLabel
            // 
            this.SizeCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeCostLabel.Location = new System.Drawing.Point(251, 223);
            this.SizeCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SizeCostLabel.Name = "SizeCostLabel";
            this.SizeCostLabel.Size = new System.Drawing.Size(84, 42);
            this.SizeCostLabel.TabIndex = 24;
            this.SizeCostLabel.Text = "0.00";
            this.SizeCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizeOverageLabel
            // 
            this.SizeOverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeOverageLabel.Location = new System.Drawing.Point(251, 181);
            this.SizeOverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SizeOverageLabel.Name = "SizeOverageLabel";
            this.SizeOverageLabel.Size = new System.Drawing.Size(84, 42);
            this.SizeOverageLabel.TabIndex = 23;
            this.SizeOverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(251, 139);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 42);
            this.label33.TabIndex = 22;
            this.label33.Text = "1.00";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(251, 97);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(84, 42);
            this.label32.TabIndex = 21;
            this.label32.Text = "1,000";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(251, 55);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 42);
            this.label31.TabIndex = 20;
            this.label31.Text = "200.00";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(208, 432);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 42);
            this.label27.TabIndex = 19;
            this.label27.Text = "$";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(208, 390);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 42);
            this.label28.TabIndex = 18;
            this.label28.Text = "$";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(208, 348);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 42);
            this.label29.TabIndex = 17;
            this.label29.Text = "$";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(208, 306);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 42);
            this.label30.TabIndex = 16;
            this.label30.Text = "$";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(208, 265);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 42);
            this.label24.TabIndex = 15;
            this.label24.Text = "$";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(208, 223);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 42);
            this.label25.TabIndex = 14;
            this.label25.Text = "$";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(208, 139);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 42);
            this.label23.TabIndex = 12;
            this.label23.Text = "$";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(208, 55);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 42);
            this.label17.TabIndex = 10;
            this.label17.Text = "$";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(96, 432);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 42);
            this.label18.TabIndex = 9;
            this.label18.Text = "Total Cost";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(63, 390);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 42);
            this.label19.TabIndex = 8;
            this.label19.Text = "Shipping Cost";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(72, 348);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 42);
            this.label20.TabIndex = 7;
            this.label20.Text = "Material Cost";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(72, 306);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 42);
            this.label21.TabIndex = 6;
            this.label21.Text = "Drawer Cost";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 265);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 42);
            this.label14.TabIndex = 5;
            this.label14.Text = "Price per Drawer";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(108, 223);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 42);
            this.label15.TabIndex = 4;
            this.label15.Text = "Size Cost";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(72, 181);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 42);
            this.label16.TabIndex = 3;
            this.label16.Text = "Size Overage";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 42);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cost per in²";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 42);
            this.label12.TabIndex = 1;
            this.label12.Text = "Base Size incl.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "Base Price";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 500);
            this.Controls.Add(this.groupBoxQuote);
            this.Controls.Add(this.groupBoxShip);
            this.Controls.Add(this.groupBoxSpec);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mainMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.DrawerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxSpec.ResumeLayout(false);
            this.groupBoxSpec.PerformLayout();
            this.groupBoxShip.ResumeLayout(false);
            this.groupBoxShip.PerformLayout();
            this.groupBoxQuote.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox MaterialBox;
        private System.Windows.Forms.ComboBox RushBox;
        private System.Windows.Forms.NumericUpDown DrawerBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxQuote;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label ShipCostLabel;
        private System.Windows.Forms.Label MaterialCostLabel;
        private System.Windows.Forms.Label DrawerCostLabel;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label SizeCostLabel;
        private System.Windows.Forms.Label SizeOverageLabel;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxShip;
        private System.Windows.Forms.GroupBox groupBoxSpec;
        private System.Windows.Forms.Label SquareInLabel;
        private System.Windows.Forms.Label QuoteDateLabel;
        private System.Windows.Forms.Label label22;
    }
}