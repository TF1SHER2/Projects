namespace PokemonStatConverter
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
            this.NameInput = new System.Windows.Forms.Label();
            this.hClassLabel = new System.Windows.Forms.Label();
            this.HeightOutput = new System.Windows.Forms.Label();
            this.wClassLabel = new System.Windows.Forms.Label();
            this.WeightOutput = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.Label();
            this.WeightInput = new System.Windows.Forms.Label();
            this.LabelInput = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tWeight = new System.Windows.Forms.TextBox();
            this.tHeight = new System.Windows.Forms.TextBox();
            this.tWeightOut = new System.Windows.Forms.TextBox();
            this.tWclass = new System.Windows.Forms.TextBox();
            this.tHeightOut = new System.Windows.Forms.TextBox();
            this.tHclass = new System.Windows.Forms.TextBox();
            this.convertB = new System.Windows.Forms.Button();
            this.closeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.AutoSize = true;
            this.NameInput.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(265, 73);
            this.NameInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(74, 27);
            this.NameInput.TabIndex = 0;
            this.NameInput.Text = "Name";
            // 
            // hClassLabel
            // 
            this.hClassLabel.AutoSize = true;
            this.hClassLabel.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hClassLabel.Location = new System.Drawing.Point(194, 528);
            this.hClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hClassLabel.Name = "hClassLabel";
            this.hClassLabel.Size = new System.Drawing.Size(145, 27);
            this.hClassLabel.TabIndex = 1;
            this.hClassLabel.Text = "Height Class";
            // 
            // HeightOutput
            // 
            this.HeightOutput.AutoSize = true;
            this.HeightOutput.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightOutput.Location = new System.Drawing.Point(209, 461);
            this.HeightOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightOutput.Name = "HeightOutput";
            this.HeightOutput.Size = new System.Drawing.Size(130, 27);
            this.HeightOutput.TabIndex = 2;
            this.HeightOutput.Text = "Height (in)";
            // 
            // wClassLabel
            // 
            this.wClassLabel.AutoSize = true;
            this.wClassLabel.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wClassLabel.Location = new System.Drawing.Point(194, 399);
            this.wClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wClassLabel.Name = "wClassLabel";
            this.wClassLabel.Size = new System.Drawing.Size(149, 27);
            this.wClassLabel.TabIndex = 3;
            this.wClassLabel.Text = "Weight Class";
            // 
            // WeightOutput
            // 
            this.WeightOutput.AutoSize = true;
            this.WeightOutput.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightOutput.Location = new System.Drawing.Point(203, 338);
            this.WeightOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeightOutput.Name = "WeightOutput";
            this.WeightOutput.Size = new System.Drawing.Size(136, 27);
            this.WeightOutput.TabIndex = 4;
            this.WeightOutput.Text = "Weight (oz)";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(45, 338);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(88, 27);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "Output";
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // HeightInput
            // 
            this.HeightInput.AutoSize = true;
            this.HeightInput.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(214, 195);
            this.HeightInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(129, 27);
            this.HeightInput.TabIndex = 6;
            this.HeightInput.Text = "Height (m)";
            // 
            // WeightInput
            // 
            this.WeightInput.AutoSize = true;
            this.WeightInput.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInput.Location = new System.Drawing.Point(203, 134);
            this.WeightInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(137, 27);
            this.WeightInput.TabIndex = 7;
            this.WeightInput.Text = "Weight (kg)";
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInput.Location = new System.Drawing.Point(45, 71);
            this.LabelInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(72, 27);
            this.LabelInput.TabIndex = 8;
            this.LabelInput.Text = "Input";
            this.LabelInput.Click += new System.EventHandler(this.LabelInput_Click);
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(397, 69);
            this.tName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(407, 31);
            this.tName.TabIndex = 9;
            this.tName.TextChanged += new System.EventHandler(this.tName_TextChanged);
            // 
            // tWeight
            // 
            this.tWeight.Enabled = false;
            this.tWeight.Location = new System.Drawing.Point(397, 131);
            this.tWeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tWeight.Name = "tWeight";
            this.tWeight.Size = new System.Drawing.Size(407, 31);
            this.tWeight.TabIndex = 10;
            // 
            // tHeight
            // 
            this.tHeight.Enabled = false;
            this.tHeight.Location = new System.Drawing.Point(397, 192);
            this.tHeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tHeight.Name = "tHeight";
            this.tHeight.Size = new System.Drawing.Size(407, 31);
            this.tHeight.TabIndex = 11;
            // 
            // tWeightOut
            // 
            this.tWeightOut.Location = new System.Drawing.Point(397, 336);
            this.tWeightOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tWeightOut.Name = "tWeightOut";
            this.tWeightOut.ReadOnly = true;
            this.tWeightOut.Size = new System.Drawing.Size(407, 31);
            this.tWeightOut.TabIndex = 12;
            // 
            // tWclass
            // 
            this.tWclass.Location = new System.Drawing.Point(397, 397);
            this.tWclass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tWclass.Name = "tWclass";
            this.tWclass.ReadOnly = true;
            this.tWclass.Size = new System.Drawing.Size(407, 31);
            this.tWclass.TabIndex = 13;
            // 
            // tHeightOut
            // 
            this.tHeightOut.Location = new System.Drawing.Point(397, 459);
            this.tHeightOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tHeightOut.Name = "tHeightOut";
            this.tHeightOut.ReadOnly = true;
            this.tHeightOut.Size = new System.Drawing.Size(407, 31);
            this.tHeightOut.TabIndex = 14;
            // 
            // tHclass
            // 
            this.tHclass.Location = new System.Drawing.Point(397, 526);
            this.tHclass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tHclass.Name = "tHclass";
            this.tHclass.ReadOnly = true;
            this.tHclass.Size = new System.Drawing.Size(407, 31);
            this.tHclass.TabIndex = 15;
            // 
            // convertB
            // 
            this.convertB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.convertB.Enabled = false;
            this.convertB.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertB.Location = new System.Drawing.Point(397, 605);
            this.convertB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.convertB.Name = "convertB";
            this.convertB.Size = new System.Drawing.Size(154, 42);
            this.convertB.TabIndex = 16;
            this.convertB.Text = "Convert";
            this.convertB.UseVisualStyleBackColor = true;
            this.convertB.Click += new System.EventHandler(this.convertB_Click);
            // 
            // closeB
            // 
            this.closeB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeB.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeB.Location = new System.Drawing.Point(650, 605);
            this.closeB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(154, 42);
            this.closeB.TabIndex = 17;
            this.closeB.Text = "Close";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click_1);
            // 
            // frmMain
            // 
            this.AcceptButton = this.convertB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeB;
            this.ClientSize = new System.Drawing.Size(881, 686);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.convertB);
            this.Controls.Add(this.tHclass);
            this.Controls.Add(this.tHeightOut);
            this.Controls.Add(this.tWclass);
            this.Controls.Add(this.tWeightOut);
            this.Controls.Add(this.tHeight);
            this.Controls.Add(this.tWeight);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.LabelInput);
            this.Controls.Add(this.WeightInput);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.WeightOutput);
            this.Controls.Add(this.wClassLabel);
            this.Controls.Add(this.HeightOutput);
            this.Controls.Add(this.hClassLabel);
            this.Controls.Add(this.NameInput);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokemonStatConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameInput;
        private System.Windows.Forms.Label hClassLabel;
        private System.Windows.Forms.Label HeightOutput;
        private System.Windows.Forms.Label wClassLabel;
        private System.Windows.Forms.Label WeightOutput;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label HeightInput;
        private System.Windows.Forms.Label WeightInput;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tWeight;
        private System.Windows.Forms.TextBox tHeight;
        private System.Windows.Forms.TextBox tWeightOut;
        private System.Windows.Forms.TextBox tWclass;
        private System.Windows.Forms.TextBox tHeightOut;
        private System.Windows.Forms.TextBox tHclass;
        private System.Windows.Forms.Button convertB;
        private System.Windows.Forms.Button closeB;
    }
}

