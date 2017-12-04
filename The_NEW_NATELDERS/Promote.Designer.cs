namespace The_NEW_NATELDERS
{
    partial class Promote
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOtherNames = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRCCNO = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYearLastPromoted = new System.Windows.Forms.TextBox();
            this.btnPromote = new System.Windows.Forms.Button();
            this.lblCurrentDesignation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(149, 69);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(35, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "OtherNames";
            // 
            // lblOtherNames
            // 
            this.lblOtherNames.AutoSize = true;
            this.lblOtherNames.Location = new System.Drawing.Point(149, 107);
            this.lblOtherNames.Name = "lblOtherNames";
            this.lblOtherNames.Size = new System.Drawing.Size(35, 13);
            this.lblOtherNames.TabIndex = 3;
            this.lblOtherNames.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RCCNO";
            // 
            // lblRCCNO
            // 
            this.lblRCCNO.AutoSize = true;
            this.lblRCCNO.Location = new System.Drawing.Point(149, 28);
            this.lblRCCNO.Name = "lblRCCNO";
            this.lblRCCNO.Size = new System.Drawing.Size(35, 13);
            this.lblRCCNO.TabIndex = 5;
            this.lblRCCNO.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "YearLastPromoted";
            // 
            // txtYearLastPromoted
            // 
            this.txtYearLastPromoted.Location = new System.Drawing.Point(125, 169);
            this.txtYearLastPromoted.Name = "txtYearLastPromoted";
            this.txtYearLastPromoted.Size = new System.Drawing.Size(100, 20);
            this.txtYearLastPromoted.TabIndex = 7;
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(125, 215);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(75, 23);
            this.btnPromote.TabIndex = 8;
            this.btnPromote.Text = "Update";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // lblCurrentDesignation
            // 
            this.lblCurrentDesignation.AutoSize = true;
            this.lblCurrentDesignation.Location = new System.Drawing.Point(149, 140);
            this.lblCurrentDesignation.Name = "lblCurrentDesignation";
            this.lblCurrentDesignation.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentDesignation.TabIndex = 10;
            this.lblCurrentDesignation.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current Designation";
            // 
            // Promote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCurrentDesignation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.txtYearLastPromoted);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRCCNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOtherNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.label1);
            this.Name = "Promote";
            this.Text = "Promote";
            this.Load += new System.EventHandler(this.Promote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOtherNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRCCNO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYearLastPromoted;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Label lblCurrentDesignation;
        private System.Windows.Forms.Label label4;

    }
}