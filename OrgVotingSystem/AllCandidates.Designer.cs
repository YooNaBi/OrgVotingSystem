namespace OrgVotingSystem
{
    partial class AllCandidates
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CandidatedataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CandidatedataGridView
            // 
            this.CandidatedataGridView.AllowUserToAddRows = false;
            this.CandidatedataGridView.AllowUserToDeleteRows = false;
            this.CandidatedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CandidatedataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CandidatedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.CandidatedataGridView.Location = new System.Drawing.Point(18, 11);
            this.CandidatedataGridView.Name = "CandidatedataGridView";
            this.CandidatedataGridView.ReadOnly = true;
            this.CandidatedataGridView.RowHeadersVisible = false;
            this.CandidatedataGridView.Size = new System.Drawing.Size(1148, 605);
            this.CandidatedataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cds_name";
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cds_year_level";
            this.Column2.HeaderText = "Year Level";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cds_course";
            this.Column3.HeaderText = "Course";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cds_position";
            this.Column4.HeaderText = "Position";
            this.Column4.MinimumWidth = 9;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cds_pictures";
            this.Column5.HeaderText = "Pictures";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // AllCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrgVotingSystem.Properties.Resources.SystemBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.CandidatedataGridView);
            this.DoubleBuffered = true;
            this.Name = "AllCandidates";
            this.Size = new System.Drawing.Size(1184, 627);
            this.Load += new System.EventHandler(this.AllCandidates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CandidatedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CandidatedataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
