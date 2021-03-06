namespace ReportingServerManager.Forms
{
    partial class FormDependantItems
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
            this.lblDependantItems = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.ReportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompatible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDependantItems
            // 
            this.lblDependantItems.AutoSize = true;
            this.lblDependantItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependantItems.Location = new System.Drawing.Point(9, 15);
            this.lblDependantItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDependantItems.Name = "lblDependantItems";
            this.lblDependantItems.Size = new System.Drawing.Size(107, 13);
            this.lblDependantItems.TabIndex = 1;
            this.lblDependantItems.Text = "Dependant Items:";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportName,
            this.isCompatible});
            this.dgvResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResults.Location = new System.Drawing.Point(11, 32);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(384, 189);
            this.dgvResults.TabIndex = 2;
            // 
            // ReportName
            // 
            this.ReportName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReportName.HeaderText = "Report name";
            this.ReportName.Name = "ReportName";
            this.ReportName.ReadOnly = true;
            this.ReportName.Width = 93;
            // 
            // isCompatible
            // 
            this.isCompatible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isCompatible.HeaderText = "Compatible";
            this.isCompatible.Name = "isCompatible";
            this.isCompatible.ReadOnly = true;
            this.isCompatible.Width = 65;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(318, 225);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // FormDependantItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 255);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblDependantItems);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDependantItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dependant Items";
            this.Load += new System.EventHandler(this.FormDependantItemsLoad);
            this.Resize += new System.EventHandler(this.FormDependantItemsResize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDependantItems;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompatible;
    }
}