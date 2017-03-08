namespace PA5_FisherThomas_PokeDexWithclasses
{
    partial class frmPokemon
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
            this.gbNewPokemon = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbWeightUnit = new System.Windows.Forms.ComboBox();
            this.cbHeightUnit = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbNewPokemon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewPokemon
            // 
            this.gbNewPokemon.Controls.Add(this.lblHeight);
            this.gbNewPokemon.Controls.Add(this.lblWeight);
            this.gbNewPokemon.Controls.Add(this.lblType);
            this.gbNewPokemon.Controls.Add(this.lblHP);
            this.gbNewPokemon.Controls.Add(this.lblName);
            this.gbNewPokemon.Controls.Add(this.btnCancel);
            this.gbNewPokemon.Controls.Add(this.btnSave);
            this.gbNewPokemon.Controls.Add(this.cbWeightUnit);
            this.gbNewPokemon.Controls.Add(this.cbHeightUnit);
            this.gbNewPokemon.Controls.Add(this.cbType);
            this.gbNewPokemon.Controls.Add(this.txtHeight);
            this.gbNewPokemon.Controls.Add(this.txtWeight);
            this.gbNewPokemon.Controls.Add(this.txtHP);
            this.gbNewPokemon.Controls.Add(this.txtName);
            this.gbNewPokemon.Location = new System.Drawing.Point(13, 13);
            this.gbNewPokemon.Name = "gbNewPokemon";
            this.gbNewPokemon.Size = new System.Drawing.Size(735, 406);
            this.gbNewPokemon.TabIndex = 0;
            this.gbNewPokemon.TabStop = false;
            this.gbNewPokemon.Text = "New Pokemon";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(20, 294);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(80, 25);
            this.lblHeight.TabIndex = 13;
            this.lblHeight.Text = "Height:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(20, 233);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(85, 25);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Weight:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 170);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 25);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(20, 109);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(45, 25);
            this.lblHP.TabIndex = 10;
            this.lblHP.Text = "HP:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 25);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(441, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(241, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbWeightUnit
            // 
            this.cbWeightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeightUnit.FormattingEnabled = true;
            this.cbWeightUnit.Items.AddRange(new object[] {
            "oz",
            "kg"});
            this.cbWeightUnit.Location = new System.Drawing.Point(571, 230);
            this.cbWeightUnit.Name = "cbWeightUnit";
            this.cbWeightUnit.Size = new System.Drawing.Size(137, 33);
            this.cbWeightUnit.TabIndex = 4;
            // 
            // cbHeightUnit
            // 
            this.cbHeightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeightUnit.FormattingEnabled = true;
            this.cbHeightUnit.Items.AddRange(new object[] {
            "in",
            "m"});
            this.cbHeightUnit.Location = new System.Drawing.Point(571, 291);
            this.cbHeightUnit.Name = "cbHeightUnit";
            this.cbHeightUnit.Size = new System.Drawing.Size(137, 33);
            this.cbHeightUnit.TabIndex = 6;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Normal",
            "Fighting",
            "Flying",
            "Poison",
            "Ground",
            "Rock",
            "Bug",
            "Ghost",
            "Steel",
            "Fire",
            "Water",
            "Grass",
            "Electric",
            "Psychic",
            "Ice",
            "Dragon",
            "Dark",
            "Fairy"});
            this.cbType.Location = new System.Drawing.Point(241, 167);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(467, 33);
            this.cbType.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(241, 291);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(312, 33);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(241, 230);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(312, 33);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(241, 106);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(467, 33);
            this.txtHP.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(241, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(467, 33);
            this.txtName.TabIndex = 0;
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(760, 433);
            this.Controls.Add(this.gbNewPokemon);
            this.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Pokemon";
            this.gbNewPokemon.ResumeLayout(false);
            this.gbNewPokemon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewPokemon;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbWeightUnit;
        private System.Windows.Forms.ComboBox cbHeightUnit;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtName;
    }
}