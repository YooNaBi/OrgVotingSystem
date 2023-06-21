namespace OrgVotingSystem
{
    partial class Submission
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSumbitVote = new System.Windows.Forms.Button();
            this.btnChangeVote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmissionPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SubmissionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 310);
            this.dataGridView1.TabIndex = 36;
            // 
            // btnSumbitVote
            // 
            this.btnSumbitVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSumbitVote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumbitVote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSumbitVote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSumbitVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnSumbitVote.ForeColor = System.Drawing.Color.Black;
            this.btnSumbitVote.Location = new System.Drawing.Point(300, 391);
            this.btnSumbitVote.Name = "btnSumbitVote";
            this.btnSumbitVote.Size = new System.Drawing.Size(166, 42);
            this.btnSumbitVote.TabIndex = 35;
            this.btnSumbitVote.Text = "Submit vote";
            this.btnSumbitVote.UseVisualStyleBackColor = false;
            this.btnSumbitVote.Click += new System.EventHandler(this.btnSumbitVote_Click);
            // 
            // btnChangeVote
            // 
            this.btnChangeVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangeVote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeVote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeVote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnChangeVote.ForeColor = System.Drawing.Color.Black;
            this.btnChangeVote.Location = new System.Drawing.Point(12, 391);
            this.btnChangeVote.Name = "btnChangeVote";
            this.btnChangeVote.Size = new System.Drawing.Size(171, 42);
            this.btnChangeVote.TabIndex = 34;
            this.btnChangeVote.Text = "Change Vote";
            this.btnChangeVote.UseVisualStyleBackColor = false;
            this.btnChangeVote.Click += new System.EventHandler(this.btnChangeVote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 65);
            this.label1.TabIndex = 33;
            this.label1.Text = "VOTE WISELY";
            // 
            // SubmissionPanel
            // 
            this.SubmissionPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.SubmissionPanel.Controls.Add(this.label1);
            this.SubmissionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmissionPanel.Location = new System.Drawing.Point(0, 0);
            this.SubmissionPanel.Name = "SubmissionPanel";
            this.SubmissionPanel.Size = new System.Drawing.Size(482, 450);
            this.SubmissionPanel.TabIndex = 37;
            // 
            // Submission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangeVote);
            this.Controls.Add(this.btnSumbitVote);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SubmissionPanel);
            this.MaximizeBox = false;
            this.Name = "Submission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submission";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SubmissionPanel.ResumeLayout(false);
            this.SubmissionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSumbitVote;
        private System.Windows.Forms.Button btnChangeVote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SubmissionPanel;
    }
}