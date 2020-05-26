namespace MegaDesk_Hubble
{
    partial class SearchQuotes
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.QuoteDataGrid = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeskDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialSearchBox = new System.Windows.Forms.ComboBox();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QuoteDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(264, 335);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(75, 23);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "&Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            this.mainMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainMenu_KeyPress);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(345, 335);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            this.exit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Exit_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(140, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // QuoteDataGrid
            // 
            this.QuoteDataGrid.AllowUserToDeleteRows = false;
            this.QuoteDataGrid.BackgroundColor = System.Drawing.SystemColors.InfoText;
            this.QuoteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuoteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.QuoteDate,
            this.Material,
            this.DeskWidth,
            this.DeskDepth,
            this.PriceQuote});
            this.QuoteDataGrid.Location = new System.Drawing.Point(12, 49);
            this.QuoteDataGrid.Name = "QuoteDataGrid";
            this.QuoteDataGrid.ReadOnly = true;
            this.QuoteDataGrid.Size = new System.Drawing.Size(736, 280);
            this.QuoteDataGrid.TabIndex = 6;
            this.QuoteDataGrid.TabStop = false;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 110;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // QuoteDate
            // 
            this.QuoteDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuoteDate.HeaderText = "Quote Date";
            this.QuoteDate.MinimumWidth = 80;
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // DeskWidth
            // 
            this.DeskWidth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeskWidth.HeaderText = "Desk Width";
            this.DeskWidth.MinimumWidth = 80;
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.ReadOnly = true;
            // 
            // DeskDepth
            // 
            this.DeskDepth.HeaderText = "Desk Depth";
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.ReadOnly = true;
            // 
            // PriceQuote
            // 
            this.PriceQuote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceQuote.HeaderText = "Price Quote ($)";
            this.PriceQuote.MinimumWidth = 110;
            this.PriceQuote.Name = "PriceQuote";
            this.PriceQuote.ReadOnly = true;
            // 
            // MaterialSearchBox
            // 
            this.MaterialSearchBox.FormattingEnabled = true;
            this.MaterialSearchBox.Location = new System.Drawing.Point(13, 12);
            this.MaterialSearchBox.Name = "MaterialSearchBox";
            this.MaterialSearchBox.Size = new System.Drawing.Size(121, 21);
            this.MaterialSearchBox.TabIndex = 7;
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk_Hubble.Desk);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 361);
            this.Controls.Add(this.MaterialSearchBox);
            this.Controls.Add(this.QuoteDataGrid);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mainMenu);
            this.MaximizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.QuoteDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView QuoteDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceQuote;
        private System.Windows.Forms.ComboBox MaterialSearchBox;
        private System.Windows.Forms.BindingSource deskBindingSource;
    }
}