namespace RoundingAllisonC
{
    partial class frmRounding
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
            this.btnRound = new System.Windows.Forms.Button();
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.numRound = new System.Windows.Forms.NumericUpDown();
            this.lblRound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRound)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(175, 156);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(85, 27);
            this.btnRound.TabIndex = 0;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEnter.Location = new System.Drawing.Point(12, 34);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(172, 20);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter a decimal number:";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(205, 34);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 2;
            // 
            // numRound
            // 
            this.numRound.Location = new System.Drawing.Point(382, 86);
            this.numRound.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRound.Name = "numRound";
            this.numRound.Size = new System.Drawing.Size(33, 20);
            this.numRound.TabIndex = 3;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRound.Location = new System.Drawing.Point(12, 86);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(364, 20);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "Enter how many decimals you would like to round to:";
            // 
            // frmRounding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(447, 220);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.numRound);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.btnRound);
            this.Name = "frmRounding";
            this.Text = "Rounding Program by Allison C";
            ((System.ComponentModel.ISupportInitialize)(this.numRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.NumericUpDown numRound;
        private System.Windows.Forms.Label lblRound;
    }
}

