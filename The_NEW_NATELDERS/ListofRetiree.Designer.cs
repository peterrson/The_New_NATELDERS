namespace The_NEW_NATELDERS
{
    partial class ListofRetiree
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
            this.ListofRetireGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListofRetireGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListofRetireGrid
            // 
            this.ListofRetireGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListofRetireGrid.Location = new System.Drawing.Point(22, 41);
            this.ListofRetireGrid.Name = "ListofRetireGrid";
            this.ListofRetireGrid.Size = new System.Drawing.Size(240, 150);
            this.ListofRetireGrid.TabIndex = 0;
            // 
            // ListofRetiree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ListofRetireGrid);
            this.Name = "ListofRetiree";
            this.Text = "ListofRetiree";
            this.Load += new System.EventHandler(this.ListofRetiree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListofRetireGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListofRetireGrid;
    }
}