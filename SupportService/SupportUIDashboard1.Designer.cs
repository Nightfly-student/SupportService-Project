
namespace SupportService
{
    partial class SupportUIDashboard1
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
            this.lblExit = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lvRecentTickets = new System.Windows.Forms.ListView();
            this.chSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDueBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAssignedTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTicketMade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlOpenTickets = new System.Windows.Forms.Panel();
            this.pnlOpenAmount = new System.Windows.Forms.Panel();
            this.lblOpenAmount = new System.Windows.Forms.Label();
            this.lblOpenTickets = new System.Windows.Forms.Label();
            this.pnlHighPriority = new System.Windows.Forms.Panel();
            this.pnlHighAmount = new System.Windows.Forms.Panel();
            this.lblHighAmount = new System.Windows.Forms.Label();
            this.lblHighPriority = new System.Windows.Forms.Label();
            this.pnlNormalPriority = new System.Windows.Forms.Panel();
            this.pnlNormalAmount = new System.Windows.Forms.Panel();
            this.lblNormalAmount = new System.Windows.Forms.Label();
            this.lblNormalPriority = new System.Windows.Forms.Label();
            this.pnlLowPriority = new System.Windows.Forms.Panel();
            this.pnlLowAmount = new System.Windows.Forms.Panel();
            this.lblLowAmount = new System.Windows.Forms.Label();
            this.lblLowPriority = new System.Windows.Forms.Label();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.pnlSortBy = new System.Windows.Forms.Panel();
            this.pnlSortOptions = new System.Windows.Forms.Panel();
            this.lblDueByHL = new System.Windows.Forms.Label();
            this.lblRecentON = new System.Windows.Forms.Label();
            this.lblDueByLH = new System.Windows.Forms.Label();
            this.lblRecentNO = new System.Windows.Forms.Label();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlDashboard.SuspendLayout();
            this.pnlOpenTickets.SuspendLayout();
            this.pnlOpenAmount.SuspendLayout();
            this.pnlHighPriority.SuspendLayout();
            this.pnlHighAmount.SuspendLayout();
            this.pnlNormalPriority.SuspendLayout();
            this.pnlNormalAmount.SuspendLayout();
            this.pnlLowPriority.SuspendLayout();
            this.pnlLowAmount.SuspendLayout();
            this.pnlSortBy.SuspendLayout();
            this.pnlSortOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlDashboard.Controls.Add(this.lblExit);
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1200, 42);
            this.pnlDashboard.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExit.Location = new System.Drawing.Point(1174, -2);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 29);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial", 15F);
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDashboard.Location = new System.Drawing.Point(12, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(106, 23);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lvRecentTickets
            // 
            this.lvRecentTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvRecentTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPriority,
            this.chSubject,
            this.chStatus,
            this.chDueBy,
            this.chAssignedTo,
            this.chTicketMade});
            this.lvRecentTickets.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRecentTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvRecentTickets.FullRowSelect = true;
            this.lvRecentTickets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRecentTickets.HideSelection = false;
            this.lvRecentTickets.Location = new System.Drawing.Point(12, 186);
            this.lvRecentTickets.MultiSelect = false;
            this.lvRecentTickets.Name = "lvRecentTickets";
            this.lvRecentTickets.Size = new System.Drawing.Size(925, 523);
            this.lvRecentTickets.TabIndex = 7;
            this.lvRecentTickets.TabStop = false;
            this.lvRecentTickets.UseCompatibleStateImageBehavior = false;
            this.lvRecentTickets.View = System.Windows.Forms.View.Details;
            // 
            // chSubject
            // 
            this.chSubject.DisplayIndex = 0;
            this.chSubject.Text = "Subject";
            this.chSubject.Width = 240;
            // 
            // chStatus
            // 
            this.chStatus.DisplayIndex = 1;
            this.chStatus.Text = "Status";
            this.chStatus.Width = 150;
            // 
            // chDueBy
            // 
            this.chDueBy.DisplayIndex = 2;
            this.chDueBy.Text = "Due By";
            this.chDueBy.Width = 150;
            // 
            // chAssignedTo
            // 
            this.chAssignedTo.DisplayIndex = 3;
            this.chAssignedTo.Text = "Assigned To";
            this.chAssignedTo.Width = 204;
            // 
            // chTicketMade
            // 
            this.chTicketMade.Text = "Ticket Made";
            this.chTicketMade.Width = 181;
            // 
            // pnlOpenTickets
            // 
            this.pnlOpenTickets.BackColor = System.Drawing.Color.White;
            this.pnlOpenTickets.Controls.Add(this.pnlOpenAmount);
            this.pnlOpenTickets.Controls.Add(this.lblOpenTickets);
            this.pnlOpenTickets.Location = new System.Drawing.Point(12, 71);
            this.pnlOpenTickets.Name = "pnlOpenTickets";
            this.pnlOpenTickets.Padding = new System.Windows.Forms.Padding(20);
            this.pnlOpenTickets.Size = new System.Drawing.Size(167, 85);
            this.pnlOpenTickets.TabIndex = 8;
            // 
            // pnlOpenAmount
            // 
            this.pnlOpenAmount.Controls.Add(this.lblOpenAmount);
            this.pnlOpenAmount.Location = new System.Drawing.Point(0, 39);
            this.pnlOpenAmount.Name = "pnlOpenAmount";
            this.pnlOpenAmount.Size = new System.Drawing.Size(167, 41);
            this.pnlOpenAmount.TabIndex = 1;
            // 
            // lblOpenAmount
            // 
            this.lblOpenAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOpenAmount.Font = new System.Drawing.Font("Arial", 17F);
            this.lblOpenAmount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOpenAmount.Location = new System.Drawing.Point(0, 0);
            this.lblOpenAmount.Name = "lblOpenAmount";
            this.lblOpenAmount.Size = new System.Drawing.Size(167, 41);
            this.lblOpenAmount.TabIndex = 0;
            this.lblOpenAmount.Text = "0";
            this.lblOpenAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpenTickets
            // 
            this.lblOpenTickets.AutoSize = true;
            this.lblOpenTickets.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblOpenTickets.Location = new System.Drawing.Point(22, 11);
            this.lblOpenTickets.Name = "lblOpenTickets";
            this.lblOpenTickets.Size = new System.Drawing.Size(130, 24);
            this.lblOpenTickets.TabIndex = 0;
            this.lblOpenTickets.Text = "Open tickets";
            // 
            // pnlHighPriority
            // 
            this.pnlHighPriority.BackColor = System.Drawing.Color.White;
            this.pnlHighPriority.Controls.Add(this.pnlHighAmount);
            this.pnlHighPriority.Controls.Add(this.lblHighPriority);
            this.pnlHighPriority.Location = new System.Drawing.Point(204, 71);
            this.pnlHighPriority.Name = "pnlHighPriority";
            this.pnlHighPriority.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHighPriority.Size = new System.Drawing.Size(167, 85);
            this.pnlHighPriority.TabIndex = 8;
            // 
            // pnlHighAmount
            // 
            this.pnlHighAmount.Controls.Add(this.lblHighAmount);
            this.pnlHighAmount.Location = new System.Drawing.Point(0, 38);
            this.pnlHighAmount.Name = "pnlHighAmount";
            this.pnlHighAmount.Size = new System.Drawing.Size(167, 41);
            this.pnlHighAmount.TabIndex = 1;
            // 
            // lblHighAmount
            // 
            this.lblHighAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHighAmount.Font = new System.Drawing.Font("Arial", 17F);
            this.lblHighAmount.ForeColor = System.Drawing.Color.Red;
            this.lblHighAmount.Location = new System.Drawing.Point(0, 0);
            this.lblHighAmount.Name = "lblHighAmount";
            this.lblHighAmount.Size = new System.Drawing.Size(167, 41);
            this.lblHighAmount.TabIndex = 0;
            this.lblHighAmount.Text = "0";
            this.lblHighAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighPriority
            // 
            this.lblHighPriority.AutoSize = true;
            this.lblHighPriority.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblHighPriority.Location = new System.Drawing.Point(22, 11);
            this.lblHighPriority.Name = "lblHighPriority";
            this.lblHighPriority.Size = new System.Drawing.Size(128, 24);
            this.lblHighPriority.TabIndex = 0;
            this.lblHighPriority.Text = "High Priority";
            // 
            // pnlNormalPriority
            // 
            this.pnlNormalPriority.BackColor = System.Drawing.Color.White;
            this.pnlNormalPriority.Controls.Add(this.pnlNormalAmount);
            this.pnlNormalPriority.Controls.Add(this.lblNormalPriority);
            this.pnlNormalPriority.Location = new System.Drawing.Point(397, 71);
            this.pnlNormalPriority.Name = "pnlNormalPriority";
            this.pnlNormalPriority.Padding = new System.Windows.Forms.Padding(20);
            this.pnlNormalPriority.Size = new System.Drawing.Size(167, 85);
            this.pnlNormalPriority.TabIndex = 8;
            // 
            // pnlNormalAmount
            // 
            this.pnlNormalAmount.Controls.Add(this.lblNormalAmount);
            this.pnlNormalAmount.Location = new System.Drawing.Point(0, 38);
            this.pnlNormalAmount.Name = "pnlNormalAmount";
            this.pnlNormalAmount.Size = new System.Drawing.Size(167, 41);
            this.pnlNormalAmount.TabIndex = 1;
            // 
            // lblNormalAmount
            // 
            this.lblNormalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNormalAmount.Font = new System.Drawing.Font("Arial", 17F);
            this.lblNormalAmount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNormalAmount.Location = new System.Drawing.Point(0, 0);
            this.lblNormalAmount.Name = "lblNormalAmount";
            this.lblNormalAmount.Size = new System.Drawing.Size(167, 41);
            this.lblNormalAmount.TabIndex = 0;
            this.lblNormalAmount.Text = "0";
            this.lblNormalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNormalPriority
            // 
            this.lblNormalPriority.AutoSize = true;
            this.lblNormalPriority.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblNormalPriority.Location = new System.Drawing.Point(8, 11);
            this.lblNormalPriority.Name = "lblNormalPriority";
            this.lblNormalPriority.Size = new System.Drawing.Size(152, 24);
            this.lblNormalPriority.TabIndex = 0;
            this.lblNormalPriority.Text = "Normal Priority";
            // 
            // pnlLowPriority
            // 
            this.pnlLowPriority.BackColor = System.Drawing.Color.White;
            this.pnlLowPriority.Controls.Add(this.pnlLowAmount);
            this.pnlLowPriority.Controls.Add(this.lblLowPriority);
            this.pnlLowPriority.Location = new System.Drawing.Point(589, 71);
            this.pnlLowPriority.Name = "pnlLowPriority";
            this.pnlLowPriority.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLowPriority.Size = new System.Drawing.Size(167, 85);
            this.pnlLowPriority.TabIndex = 8;
            // 
            // pnlLowAmount
            // 
            this.pnlLowAmount.Controls.Add(this.lblLowAmount);
            this.pnlLowAmount.Location = new System.Drawing.Point(0, 38);
            this.pnlLowAmount.Name = "pnlLowAmount";
            this.pnlLowAmount.Size = new System.Drawing.Size(167, 41);
            this.pnlLowAmount.TabIndex = 1;
            // 
            // lblLowAmount
            // 
            this.lblLowAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowAmount.Font = new System.Drawing.Font("Arial", 17F);
            this.lblLowAmount.ForeColor = System.Drawing.Color.Green;
            this.lblLowAmount.Location = new System.Drawing.Point(0, 0);
            this.lblLowAmount.Name = "lblLowAmount";
            this.lblLowAmount.Size = new System.Drawing.Size(167, 41);
            this.lblLowAmount.TabIndex = 0;
            this.lblLowAmount.Text = "0";
            this.lblLowAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowPriority
            // 
            this.lblLowPriority.AutoSize = true;
            this.lblLowPriority.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblLowPriority.Location = new System.Drawing.Point(29, 11);
            this.lblLowPriority.Name = "lblLowPriority";
            this.lblLowPriority.Size = new System.Drawing.Size(124, 24);
            this.lblLowPriority.TabIndex = 0;
            this.lblLowPriority.Text = "Low Priority";
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(3, 3);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(77, 22);
            this.lblSortBy.TabIndex = 9;
            this.lblSortBy.Text = "Sort by";
            // 
            // pnlSortBy
            // 
            this.pnlSortBy.BackColor = System.Drawing.Color.White;
            this.pnlSortBy.Controls.Add(this.pnlSortOptions);
            this.pnlSortBy.Controls.Add(this.lblSortBy);
            this.pnlSortBy.Location = new System.Drawing.Point(953, 186);
            this.pnlSortBy.Name = "pnlSortBy";
            this.pnlSortBy.Size = new System.Drawing.Size(235, 158);
            this.pnlSortBy.TabIndex = 10;
            // 
            // pnlSortOptions
            // 
            this.pnlSortOptions.Controls.Add(this.lblDueByHL);
            this.pnlSortOptions.Controls.Add(this.lblRecentON);
            this.pnlSortOptions.Controls.Add(this.lblDueByLH);
            this.pnlSortOptions.Controls.Add(this.lblRecentNO);
            this.pnlSortOptions.Location = new System.Drawing.Point(35, 34);
            this.pnlSortOptions.Name = "pnlSortOptions";
            this.pnlSortOptions.Size = new System.Drawing.Size(197, 112);
            this.pnlSortOptions.TabIndex = 10;
            // 
            // lblDueByHL
            // 
            this.lblDueByHL.AutoSize = true;
            this.lblDueByHL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDueByHL.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDueByHL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDueByHL.Location = new System.Drawing.Point(15, 87);
            this.lblDueByHL.Name = "lblDueByHL";
            this.lblDueByHL.Size = new System.Drawing.Size(149, 18);
            this.lblDueByHL.TabIndex = 9;
            this.lblDueByHL.Text = "Due By: High to Low";
            this.lblDueByHL.Click += new System.EventHandler(this.lblDueByHL_Click);
            // 
            // lblRecentON
            // 
            this.lblRecentON.AutoSize = true;
            this.lblRecentON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecentON.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRecentON.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecentON.Location = new System.Drawing.Point(15, 33);
            this.lblRecentON.Name = "lblRecentON";
            this.lblRecentON.Size = new System.Drawing.Size(141, 18);
            this.lblRecentON.TabIndex = 9;
            this.lblRecentON.Text = "Recent: Old to New";
            this.lblRecentON.Click += new System.EventHandler(this.lblRecentON_Click);
            // 
            // lblDueByLH
            // 
            this.lblDueByLH.AutoSize = true;
            this.lblDueByLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDueByLH.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDueByLH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDueByLH.Location = new System.Drawing.Point(15, 60);
            this.lblDueByLH.Name = "lblDueByLH";
            this.lblDueByLH.Size = new System.Drawing.Size(149, 18);
            this.lblDueByLH.TabIndex = 9;
            this.lblDueByLH.Text = "Due By: Low to High";
            this.lblDueByLH.Click += new System.EventHandler(this.lblDueByLH_Click);
            // 
            // lblRecentNO
            // 
            this.lblRecentNO.AutoSize = true;
            this.lblRecentNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecentNO.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRecentNO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecentNO.Location = new System.Drawing.Point(15, 6);
            this.lblRecentNO.Name = "lblRecentNO";
            this.lblRecentNO.Size = new System.Drawing.Size(141, 18);
            this.lblRecentNO.TabIndex = 9;
            this.lblRecentNO.Text = "Recent: New to Old";
            this.lblRecentNO.Click += new System.EventHandler(this.lblRecentNO_Click);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Font = new System.Drawing.Font("Arial", 12F);
            this.tbSearchBox.Location = new System.Drawing.Point(3, 28);
            this.tbSearchBox.MaxLength = 50;
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(229, 26);
            this.tbSearchBox.TabIndex = 1;
            this.tbSearchBox.TabStop = false;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(3, 3);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 22);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbSearchBox);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Location = new System.Drawing.Point(953, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 61);
            this.panel1.TabIndex = 12;
            // 
            // chPriority
            // 
            this.chPriority.Text = "";
            this.chPriority.Width = 5;
            // 
            // SupportUIDashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSortBy);
            this.Controls.Add(this.pnlLowPriority);
            this.Controls.Add(this.pnlNormalPriority);
            this.Controls.Add(this.pnlHighPriority);
            this.Controls.Add(this.pnlOpenTickets);
            this.Controls.Add(this.lvRecentTickets);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupportUIDashboard1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupportUIDashboard1";
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlOpenTickets.ResumeLayout(false);
            this.pnlOpenTickets.PerformLayout();
            this.pnlOpenAmount.ResumeLayout(false);
            this.pnlHighPriority.ResumeLayout(false);
            this.pnlHighPriority.PerformLayout();
            this.pnlHighAmount.ResumeLayout(false);
            this.pnlNormalPriority.ResumeLayout(false);
            this.pnlNormalPriority.PerformLayout();
            this.pnlNormalAmount.ResumeLayout(false);
            this.pnlLowPriority.ResumeLayout(false);
            this.pnlLowPriority.PerformLayout();
            this.pnlLowAmount.ResumeLayout(false);
            this.pnlSortBy.ResumeLayout(false);
            this.pnlSortBy.PerformLayout();
            this.pnlSortOptions.ResumeLayout(false);
            this.pnlSortOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.ListView lvRecentTickets;
        private System.Windows.Forms.ColumnHeader chSubject;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.ColumnHeader chDueBy;
        private System.Windows.Forms.Panel pnlOpenTickets;
        private System.Windows.Forms.Panel pnlOpenAmount;
        private System.Windows.Forms.Label lblOpenAmount;
        private System.Windows.Forms.Label lblOpenTickets;
        private System.Windows.Forms.Panel pnlHighPriority;
        private System.Windows.Forms.Panel pnlHighAmount;
        private System.Windows.Forms.Label lblHighAmount;
        private System.Windows.Forms.Label lblHighPriority;
        private System.Windows.Forms.Panel pnlNormalPriority;
        private System.Windows.Forms.Panel pnlNormalAmount;
        private System.Windows.Forms.Label lblNormalAmount;
        private System.Windows.Forms.Label lblNormalPriority;
        private System.Windows.Forms.Panel pnlLowPriority;
        private System.Windows.Forms.Panel pnlLowAmount;
        private System.Windows.Forms.Label lblLowAmount;
        private System.Windows.Forms.Label lblLowPriority;
        private System.Windows.Forms.ColumnHeader chAssignedTo;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Panel pnlSortBy;
        private System.Windows.Forms.Label lblRecentNO;
        private System.Windows.Forms.Label lblDueByHL;
        private System.Windows.Forms.Label lblDueByLH;
        private System.Windows.Forms.Label lblRecentON;
        private System.Windows.Forms.Panel pnlSortOptions;
        private System.Windows.Forms.ColumnHeader chTicketMade;
        private System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader chPriority;
    }
}