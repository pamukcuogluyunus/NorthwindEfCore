namespace UIWinFormss
{
    partial class frmSuppliers
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
            dgwSuppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgwSuppliers
            // 
            dgwSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSuppliers.Location = new Point(12, 12);
            dgwSuppliers.Name = "dgwSuppliers";
            dgwSuppliers.RowTemplate.Height = 25;
            dgwSuppliers.Size = new Size(521, 297);
            dgwSuppliers.TabIndex = 0;
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwSuppliers);
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            Load += frmSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dgwSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwSuppliers;
    }
}