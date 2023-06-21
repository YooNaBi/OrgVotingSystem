namespace OrgVotingSystem
{
    partial class VotingForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAllCandidates = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VotingPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.VotingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.btnLogOut);
            this.MenuPanel.Controls.Add(this.pictureBox2);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.btnAllCandidates);
            this.MenuPanel.Controls.Add(this.btnCandidate);
            this.MenuPanel.Controls.Add(this.label4);
            this.MenuPanel.Controls.Add(this.label3);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1184, 65);
            this.MenuPanel.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(1056, 14);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(99, 39);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::OrgVotingSystem.Properties.Resources.all_candidate;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(779, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 39);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OrgVotingSystem.Properties.Resources.CANDIDATE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(548, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAllCandidates
            // 
            this.btnAllCandidates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAllCandidates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllCandidates.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAllCandidates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnAllCandidates.ForeColor = System.Drawing.Color.Black;
            this.btnAllCandidates.Location = new System.Drawing.Point(834, 14);
            this.btnAllCandidates.Name = "btnAllCandidates";
            this.btnAllCandidates.Size = new System.Drawing.Size(216, 39);
            this.btnAllCandidates.TabIndex = 7;
            this.btnAllCandidates.Text = "ALL CANDIDATES";
            this.btnAllCandidates.UseVisualStyleBackColor = false;
            this.btnAllCandidates.Click += new System.EventHandler(this.btnAllCandidates_Click);
            // 
            // btnCandidate
            // 
            this.btnCandidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCandidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCandidate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnCandidate.ForeColor = System.Drawing.Color.Black;
            this.btnCandidate.Location = new System.Drawing.Point(603, 14);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(167, 39);
            this.btnCandidate.TabIndex = 6;
            this.btnCandidate.Text = "CANDIDATES";
            this.btnCandidate.UseVisualStyleBackColor = false;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(407, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(148, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(303, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID:";
            // 
            // VotingPanel
            // 
            this.VotingPanel.BackColor = System.Drawing.Color.Transparent;
            this.VotingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VotingPanel.Controls.Add(this.label5);
            this.VotingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VotingPanel.Location = new System.Drawing.Point(0, 67);
            this.VotingPanel.Name = "VotingPanel";
            this.VotingPanel.Size = new System.Drawing.Size(1184, 644);
            this.VotingPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1115, 63);
            this.label5.TabIndex = 1;
            this.label5.Text = " STICA VOTING ORGANIZATION SYSTEM";
            // 
            // VotingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrgVotingSystem.Properties.Resources.SystemBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.VotingPanel);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.Name = "VotingForm";
            this.Size = new System.Drawing.Size(1184, 711);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.VotingPanel.ResumeLayout(false);
            this.VotingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAllCandidates;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel VotingPanel;
        private System.Windows.Forms.Label label5;
    }
}
