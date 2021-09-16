
namespace SupportService
{
    partial class FormDashboard
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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblHighBorder = new System.Windows.Forms.Label();
            this.lblHighPriority = new System.Windows.Forms.Label();
            this.lblHighAmount = new System.Windows.Forms.Label();
            this.pnlHighPriority = new System.Windows.Forms.Panel();
            this.pnlNormalPriority = new System.Windows.Forms.Panel();
            this.lblNormalPriority = new System.Windows.Forms.Label();
            this.lblNormalAmount = new System.Windows.Forms.Label();
            this.lblNormalBorder = new System.Windows.Forms.Label();
            this.pnlLowPriority = new System.Windows.Forms.Panel();
            this.lblLowPriority = new System.Windows.Forms.Label();
            this.lblLowAmount = new System.Windows.Forms.Label();
            this.lblLowBorder = new System.Windows.Forms.Label();
            this.pnlPriorities = new System.Windows.Forms.Panel();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.lblRecent = new System.Windows.Forms.Label();
            this.lvRecentTickets = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDashboard.SuspendLayout();
            this.pnlHighPriority.SuspendLayout();
            this.pnlNormalPriority.SuspendLayout();
            this.pnlLowPriority.SuspendLayout();
            this.pnlPriorities.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDashboard.Controls.Add(this.label2);
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(800, 42);
            this.pnlDashboard.TabIndex = 0;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDashboard.Location = new System.Drawing.Point(12, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(113, 24);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lblHighBorder
            // 
            this.lblHighBorder.AutoSize = true;
            this.lblHighBorder.Font = new System.Drawing.Font("Arial Narrow", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighBorder.ForeColor = System.Drawing.Color.Red;
            this.lblHighBorder.Location = new System.Drawing.Point(2, 2);
            this.lblHighBorder.Name = "lblHighBorder";
            this.lblHighBorder.Size = new System.Drawing.Size(41, 66);
            this.lblHighBorder.TabIndex = 1;
            this.lblHighBorder.Text = "|";
            // 
            // lblHighPriority
            // 
            this.lblHighPriority.AutoSize = true;
            this.lblHighPriority.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHighPriority.Location = new System.Drawing.Point(32, 15);
            this.lblHighPriority.Name = "lblHighPriority";
            this.lblHighPriority.Size = new System.Drawing.Size(124, 24);
            this.lblHighPriority.TabIndex = 2;
            this.lblHighPriority.Text = "High Priority";
            // 
            // lblHighAmount
            // 
            this.lblHighAmount.AutoSize = true;
            this.lblHighAmount.Font = new System.Drawing.Font("Arial", 14F);
            this.lblHighAmount.ForeColor = System.Drawing.Color.Gray;
            this.lblHighAmount.Location = new System.Drawing.Point(32, 43);
            this.lblHighAmount.Name = "lblHighAmount";
            this.lblHighAmount.Size = new System.Drawing.Size(21, 22);
            this.lblHighAmount.TabIndex = 2;
            this.lblHighAmount.Text = "7";
            // 
            // pnlHighPriority
            // 
            this.pnlHighPriority.Controls.Add(this.lblHighPriority);
            this.pnlHighPriority.Controls.Add(this.lblHighAmount);
            this.pnlHighPriority.Controls.Add(this.lblHighBorder);
            this.pnlHighPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHighPriority.Location = new System.Drawing.Point(121, 32);
            this.pnlHighPriority.Name = "pnlHighPriority";
            this.pnlHighPriority.Size = new System.Drawing.Size(157, 80);
            this.pnlHighPriority.TabIndex = 3;
            // 
            // pnlNormalPriority
            // 
            this.pnlNormalPriority.Controls.Add(this.lblNormalPriority);
            this.pnlNormalPriority.Controls.Add(this.lblNormalAmount);
            this.pnlNormalPriority.Controls.Add(this.lblNormalBorder);
            this.pnlNormalPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNormalPriority.Location = new System.Drawing.Point(317, 32);
            this.pnlNormalPriority.Name = "pnlNormalPriority";
            this.pnlNormalPriority.Size = new System.Drawing.Size(180, 80);
            this.pnlNormalPriority.TabIndex = 4;
            // 
            // lblNormalPriority
            // 
            this.lblNormalPriority.AutoSize = true;
            this.lblNormalPriority.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNormalPriority.Location = new System.Drawing.Point(32, 15);
            this.lblNormalPriority.Name = "lblNormalPriority";
            this.lblNormalPriority.Size = new System.Drawing.Size(148, 24);
            this.lblNormalPriority.TabIndex = 2;
            this.lblNormalPriority.Text = "Normal Priority";
            // 
            // lblNormalAmount
            // 
            this.lblNormalAmount.AutoSize = true;
            this.lblNormalAmount.Font = new System.Drawing.Font("Arial", 14F);
            this.lblNormalAmount.ForeColor = System.Drawing.Color.Gray;
            this.lblNormalAmount.Location = new System.Drawing.Point(32, 43);
            this.lblNormalAmount.Name = "lblNormalAmount";
            this.lblNormalAmount.Size = new System.Drawing.Size(32, 22);
            this.lblNormalAmount.TabIndex = 2;
            this.lblNormalAmount.Text = "13";
            // 
            // lblNormalBorder
            // 
            this.lblNormalBorder.AutoSize = true;
            this.lblNormalBorder.Font = new System.Drawing.Font("Arial Narrow", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalBorder.ForeColor = System.Drawing.Color.Orange;
            this.lblNormalBorder.Location = new System.Drawing.Point(2, 2);
            this.lblNormalBorder.Name = "lblNormalBorder";
            this.lblNormalBorder.Size = new System.Drawing.Size(41, 66);
            this.lblNormalBorder.TabIndex = 1;
            this.lblNormalBorder.Text = "|";
            // 
            // pnlLowPriority
            // 
            this.pnlLowPriority.Controls.Add(this.lblLowPriority);
            this.pnlLowPriority.Controls.Add(this.lblLowAmount);
            this.pnlLowPriority.Controls.Add(this.lblLowBorder);
            this.pnlLowPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLowPriority.Location = new System.Drawing.Point(511, 32);
            this.pnlLowPriority.Name = "pnlLowPriority";
            this.pnlLowPriority.Size = new System.Drawing.Size(154, 80);
            this.pnlLowPriority.TabIndex = 5;
            // 
            // lblLowPriority
            // 
            this.lblLowPriority.AutoSize = true;
            this.lblLowPriority.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLowPriority.Location = new System.Drawing.Point(32, 15);
            this.lblLowPriority.Name = "lblLowPriority";
            this.lblLowPriority.Size = new System.Drawing.Size(122, 24);
            this.lblLowPriority.TabIndex = 2;
            this.lblLowPriority.Text = "Low Priority";
            // 
            // lblLowAmount
            // 
            this.lblLowAmount.AutoSize = true;
            this.lblLowAmount.Font = new System.Drawing.Font("Arial", 14F);
            this.lblLowAmount.ForeColor = System.Drawing.Color.Gray;
            this.lblLowAmount.Location = new System.Drawing.Point(32, 43);
            this.lblLowAmount.Name = "lblLowAmount";
            this.lblLowAmount.Size = new System.Drawing.Size(32, 22);
            this.lblLowAmount.TabIndex = 2;
            this.lblLowAmount.Text = "21";
            // 
            // lblLowBorder
            // 
            this.lblLowBorder.AutoSize = true;
            this.lblLowBorder.Font = new System.Drawing.Font("Arial Narrow", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowBorder.ForeColor = System.Drawing.Color.Green;
            this.lblLowBorder.Location = new System.Drawing.Point(2, 2);
            this.lblLowBorder.Name = "lblLowBorder";
            this.lblLowBorder.Size = new System.Drawing.Size(41, 66);
            this.lblLowBorder.TabIndex = 1;
            this.lblLowBorder.Text = "|";
            // 
            // pnlPriorities
            // 
            this.pnlPriorities.BackColor = System.Drawing.Color.White;
            this.pnlPriorities.Controls.Add(this.pnlHighPriority);
            this.pnlPriorities.Controls.Add(this.pnlLowPriority);
            this.pnlPriorities.Controls.Add(this.pnlNormalPriority);
            this.pnlPriorities.ForeColor = System.Drawing.Color.Maroon;
            this.pnlPriorities.Location = new System.Drawing.Point(0, 41);
            this.pnlPriorities.Name = "pnlPriorities";
            this.pnlPriorities.Size = new System.Drawing.Size(800, 172);
            this.pnlPriorities.TabIndex = 6;
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNewTicket.ForeColor = System.Drawing.Color.White;
            this.btnNewTicket.Location = new System.Drawing.Point(216, 191);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(185, 45);
            this.btnNewTicket.TabIndex = 1;
            this.btnNewTicket.Text = "Ticket Overview";
            this.btnNewTicket.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(421, 191);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(185, 45);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "User Overview";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecent.Location = new System.Drawing.Point(12, 273);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(144, 24);
            this.lblRecent.TabIndex = 2;
            this.lblRecent.Text = "Recent tickets";
            // 
            // lvRecentTickets
            // 
            this.lvRecentTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chSubject,
            this.chUser,
            this.chDate,
            this.chStatus});
            this.lvRecentTickets.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRecentTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvRecentTickets.HideSelection = false;
            this.lvRecentTickets.Location = new System.Drawing.Point(12, 300);
            this.lvRecentTickets.Name = "lvRecentTickets";
            this.lvRecentTickets.Size = new System.Drawing.Size(776, 241);
            this.lvRecentTickets.TabIndex = 7;
            this.lvRecentTickets.UseCompatibleStateImageBehavior = false;
            this.lvRecentTickets.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 50;
            // 
            // chSubject
            // 
            this.chSubject.Text = "Subject";
            this.chSubject.Width = 350;
            // 
            // chUser
            // 
            this.chUser.Text = "User";
            this.chUser.Width = 150;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 150;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(772, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.lvRecentTickets);
            this.Controls.Add(this.lblRecent);
            this.Controls.Add(this.btnNewTicket);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.pnlPriorities);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlHighPriority.ResumeLayout(false);
            this.pnlHighPriority.PerformLayout();
            this.pnlNormalPriority.ResumeLayout(false);
            this.pnlNormalPriority.PerformLayout();
            this.pnlLowPriority.ResumeLayout(false);
            this.pnlLowPriority.PerformLayout();
            this.pnlPriorities.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblHighBorder;
        private System.Windows.Forms.Label lblHighPriority;
        private System.Windows.Forms.Label lblHighAmount;
        private System.Windows.Forms.Panel pnlHighPriority;
        private System.Windows.Forms.Panel pnlNormalPriority;
        private System.Windows.Forms.Label lblNormalPriority;
        private System.Windows.Forms.Label lblNormalAmount;
        private System.Windows.Forms.Label lblNormalBorder;
        private System.Windows.Forms.Panel pnlLowPriority;
        private System.Windows.Forms.Label lblLowPriority;
        private System.Windows.Forms.Label lblLowAmount;
        private System.Windows.Forms.Label lblLowBorder;
        private System.Windows.Forms.Panel pnlPriorities;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.ListView lvRecentTickets;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chSubject;
        private System.Windows.Forms.ColumnHeader chUser;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.Label label2;
    }
}