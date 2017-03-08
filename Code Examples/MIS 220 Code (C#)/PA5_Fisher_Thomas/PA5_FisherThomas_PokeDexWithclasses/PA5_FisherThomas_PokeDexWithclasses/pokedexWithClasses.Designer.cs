namespace PA5_FisherThomas_PokeDexWithclasses
{
    partial class frmMain
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
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.btnType = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.btnHeight = new System.Windows.Forms.Button();
            this.btnWeight = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.gbCurrentSort = new System.Windows.Forms.GroupBox();
            this.rbType = new System.Windows.Forms.RadioButton();
            this.rbHeight = new System.Windows.Forms.RadioButton();
            this.rbHP = new System.Windows.Forms.RadioButton();
            this.rbWeight = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDataFill = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvPokeDex = new System.Windows.Forms.DataGridView();
            this.gbSortBy.SuspendLayout();
            this.gbCurrentSort.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokeDex)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSortBy
            // 
            this.gbSortBy.Controls.Add(this.btnType);
            this.gbSortBy.Controls.Add(this.btnHP);
            this.gbSortBy.Controls.Add(this.btnHeight);
            this.gbSortBy.Controls.Add(this.btnWeight);
            this.gbSortBy.Controls.Add(this.btnName);
            this.gbSortBy.Location = new System.Drawing.Point(689, 13);
            this.gbSortBy.Margin = new System.Windows.Forms.Padding(4);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Padding = new System.Windows.Forms.Padding(4);
            this.gbSortBy.Size = new System.Drawing.Size(243, 175);
            this.gbSortBy.TabIndex = 6;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort By";
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(8, 121);
            this.btnType.Margin = new System.Windows.Forms.Padding(4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(106, 37);
            this.btnType.TabIndex = 2;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnHP
            // 
            this.btnHP.Location = new System.Drawing.Point(8, 75);
            this.btnHP.Margin = new System.Windows.Forms.Padding(4);
            this.btnHP.Name = "btnHP";
            this.btnHP.Size = new System.Drawing.Size(106, 38);
            this.btnHP.TabIndex = 1;
            this.btnHP.Text = "HP";
            this.btnHP.UseVisualStyleBackColor = true;
            this.btnHP.Click += new System.EventHandler(this.btnHP_Click);
            // 
            // btnHeight
            // 
            this.btnHeight.Location = new System.Drawing.Point(122, 75);
            this.btnHeight.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeight.Name = "btnHeight";
            this.btnHeight.Size = new System.Drawing.Size(106, 38);
            this.btnHeight.TabIndex = 4;
            this.btnHeight.Text = "Height";
            this.btnHeight.UseVisualStyleBackColor = true;
            this.btnHeight.Click += new System.EventHandler(this.btnHeight_Click);
            // 
            // btnWeight
            // 
            this.btnWeight.Location = new System.Drawing.Point(122, 29);
            this.btnWeight.Margin = new System.Windows.Forms.Padding(4);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(106, 38);
            this.btnWeight.TabIndex = 3;
            this.btnWeight.Text = "Weight";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(8, 29);
            this.btnName.Margin = new System.Windows.Forms.Padding(4);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(106, 38);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // gbCurrentSort
            // 
            this.gbCurrentSort.Controls.Add(this.rbType);
            this.gbCurrentSort.Controls.Add(this.rbHeight);
            this.gbCurrentSort.Controls.Add(this.rbHP);
            this.gbCurrentSort.Controls.Add(this.rbWeight);
            this.gbCurrentSort.Controls.Add(this.rbName);
            this.gbCurrentSort.Location = new System.Drawing.Point(689, 196);
            this.gbCurrentSort.Margin = new System.Windows.Forms.Padding(4);
            this.gbCurrentSort.Name = "gbCurrentSort";
            this.gbCurrentSort.Padding = new System.Windows.Forms.Padding(4);
            this.gbCurrentSort.Size = new System.Drawing.Size(243, 316);
            this.gbCurrentSort.TabIndex = 1;
            this.gbCurrentSort.TabStop = false;
            this.gbCurrentSort.Text = "Current Sort";
            // 
            // rbType
            // 
            this.rbType.AutoSize = true;
            this.rbType.Enabled = false;
            this.rbType.Location = new System.Drawing.Point(8, 167);
            this.rbType.Margin = new System.Windows.Forms.Padding(4);
            this.rbType.Name = "rbType";
            this.rbType.Size = new System.Drawing.Size(88, 29);
            this.rbType.TabIndex = 2;
            this.rbType.TabStop = true;
            this.rbType.Text = "Type";
            this.rbType.UseVisualStyleBackColor = true;
            // 
            // rbHeight
            // 
            this.rbHeight.AutoSize = true;
            this.rbHeight.Enabled = false;
            this.rbHeight.Location = new System.Drawing.Point(8, 276);
            this.rbHeight.Margin = new System.Windows.Forms.Padding(4);
            this.rbHeight.Name = "rbHeight";
            this.rbHeight.Size = new System.Drawing.Size(104, 29);
            this.rbHeight.TabIndex = 4;
            this.rbHeight.TabStop = true;
            this.rbHeight.Text = "Height";
            this.rbHeight.UseVisualStyleBackColor = true;
            // 
            // rbHP
            // 
            this.rbHP.AutoSize = true;
            this.rbHP.Enabled = false;
            this.rbHP.Location = new System.Drawing.Point(8, 113);
            this.rbHP.Margin = new System.Windows.Forms.Padding(4);
            this.rbHP.Name = "rbHP";
            this.rbHP.Size = new System.Drawing.Size(69, 29);
            this.rbHP.TabIndex = 1;
            this.rbHP.TabStop = true;
            this.rbHP.Text = "HP";
            this.rbHP.UseVisualStyleBackColor = true;
            // 
            // rbWeight
            // 
            this.rbWeight.AutoSize = true;
            this.rbWeight.Enabled = false;
            this.rbWeight.Location = new System.Drawing.Point(8, 221);
            this.rbWeight.Margin = new System.Windows.Forms.Padding(4);
            this.rbWeight.Name = "rbWeight";
            this.rbWeight.Size = new System.Drawing.Size(109, 29);
            this.rbWeight.TabIndex = 3;
            this.rbWeight.TabStop = true;
            this.rbWeight.Text = "Weight";
            this.rbWeight.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Enabled = false;
            this.rbName.Location = new System.Drawing.Point(8, 61);
            this.rbName.Margin = new System.Windows.Forms.Padding(4);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(97, 29);
            this.rbName.TabIndex = 0;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tbHeight);
            this.gbDetails.Controls.Add(this.tbWeight);
            this.gbDetails.Controls.Add(this.tbType);
            this.gbDetails.Controls.Add(this.tbHP);
            this.gbDetails.Controls.Add(this.tbName);
            this.gbDetails.Controls.Add(this.lblHeight);
            this.gbDetails.Controls.Add(this.lblWeight);
            this.gbDetails.Controls.Add(this.lblType);
            this.gbDetails.Controls.Add(this.lblHP);
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Location = new System.Drawing.Point(20, 229);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetails.Size = new System.Drawing.Size(661, 283);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(129, 242);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(4);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.ReadOnly = true;
            this.tbHeight.Size = new System.Drawing.Size(516, 33);
            this.tbHeight.TabIndex = 9;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(129, 187);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.ReadOnly = true;
            this.tbWeight.Size = new System.Drawing.Size(516, 33);
            this.tbWeight.TabIndex = 8;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(129, 133);
            this.tbType.Margin = new System.Windows.Forms.Padding(4);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(516, 33);
            this.tbType.TabIndex = 7;
            // 
            // tbHP
            // 
            this.tbHP.Location = new System.Drawing.Point(129, 79);
            this.tbHP.Margin = new System.Windows.Forms.Padding(4);
            this.tbHP.Name = "tbHP";
            this.tbHP.ReadOnly = true;
            this.tbHP.Size = new System.Drawing.Size(516, 33);
            this.tbHP.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(129, 27);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(516, 33);
            this.tbName.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 245);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(73, 25);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(8, 190);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(78, 25);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(8, 136);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(57, 25);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(8, 82);
            this.lblHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(38, 25);
            this.lblHP.TabIndex = 1;
            this.lblHP.Text = "HP";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // btnDataFill
            // 
            this.btnDataFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataFill.Location = new System.Drawing.Point(598, 534);
            this.btnDataFill.Margin = new System.Windows.Forms.Padding(4);
            this.btnDataFill.Name = "btnDataFill";
            this.btnDataFill.Size = new System.Drawing.Size(106, 37);
            this.btnDataFill.TabIndex = 5;
            this.btnDataFill.Text = "DataFill";
            this.btnDataFill.UseVisualStyleBackColor = true;
            this.btnDataFill.Click += new System.EventHandler(this.btnDataFill_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(712, 534);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(826, 534);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(8, 754);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(328, 25);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "The Pokedex Contains 0 Pokemon";
            // 
            // dgvPokeDex
            // 
            this.dgvPokeDex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokeDex.Location = new System.Drawing.Point(20, 12);
            this.dgvPokeDex.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPokeDex.Name = "dgvPokeDex";
            this.dgvPokeDex.RowHeadersVisible = false;
            this.dgvPokeDex.RowTemplate.Height = 33;
            this.dgvPokeDex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokeDex.Size = new System.Drawing.Size(661, 210);
            this.dgvPokeDex.TabIndex = 9;
            this.dgvPokeDex.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPokeDex_CellClick);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(961, 597);
            this.Controls.Add(this.dgvPokeDex);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnDataFill);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbCurrentSort);
            this.Controls.Add(this.gbSortBy);
            this.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PA5 Fisher Thomas Pokedex";
            this.gbSortBy.ResumeLayout(false);
            this.gbCurrentSort.ResumeLayout(false);
            this.gbCurrentSort.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokeDex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button btnHeight;
        private System.Windows.Forms.Button btnWeight;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.GroupBox gbCurrentSort;
        private System.Windows.Forms.RadioButton rbType;
        private System.Windows.Forms.RadioButton rbHeight;
        private System.Windows.Forms.RadioButton rbHP;
        private System.Windows.Forms.RadioButton rbWeight;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbHP;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDataFill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvPokeDex;
    }
}

