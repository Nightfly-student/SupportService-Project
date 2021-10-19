namespace SupportService
{
    partial class FormMain
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
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(12, 9);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(81, 13);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "Not connected.";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(15, 43);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(191, 67);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(15, 130);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(191, 67);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "USERS/ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.Location = new System.Drawing.Point(15, 218);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(191, 67);
            this.btnAddTicket.TabIndex = 11;
            this.btnAddTicket.Text = "ADD TICKET";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 323);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblConnectionStatus);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddTicket;
    }
}

