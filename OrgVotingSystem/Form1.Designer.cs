namespace OrgVotingSystem
{
    partial class MainForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::OrgVotingSystem.Properties.Resources.SystemBackground;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.btnEnter);
            this.MainPanel.Controls.Add(this.tbUserPassword);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.tbStudentID);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1184, 711);
            this.MainPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::OrgVotingSystem.Properties.Resources.QR;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(421, 329);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 65);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::OrgVotingSystem.Properties.Resources.ID;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(421, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 65);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Location = new System.Drawing.Point(554, 412);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(138, 36);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.BackColor = System.Drawing.Color.White;
            this.tbUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tbUserPassword.Location = new System.Drawing.Point(502, 363);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.PasswordChar = '*';
            this.tbUserPassword.Size = new System.Drawing.Size(261, 24);
            this.tbUserPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(496, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Code*";
            // 
            // tbStudentID
            // 
            this.tbStudentID.BackColor = System.Drawing.Color.White;
            this.tbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tbStudentID.Location = new System.Drawing.Point(502, 271);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(261, 31);
            this.tbStudentID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(496, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1043, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = " STICA VOTING ORGANIZATION SYSTEM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting System";
           
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

