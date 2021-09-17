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
            this.lblDatabase = new System.Windows.Forms.Label();
            this.btnConnectToClient = new System.Windows.Forms.Button();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.btnConnectToDatabase = new System.Windows.Forms.Button();
            this.lvSelectedTable = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(12, 64);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(81, 13);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "Not connected.";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(152, 103);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(114, 13);
            this.lblDatabase.TabIndex = 1;
            this.lblDatabase.Text = "No database selected!";
            // 
            // btnConnectToClient
            // 
            this.btnConnectToClient.Location = new System.Drawing.Point(12, 25);
            this.btnConnectToClient.Name = "btnConnectToClient";
            this.btnConnectToClient.Size = new System.Drawing.Size(128, 36);
            this.btnConnectToClient.TabIndex = 2;
            this.btnConnectToClient.Text = "Connect to Client";
            this.btnConnectToClient.UseVisualStyleBackColor = true;
            this.btnConnectToClient.Click += new System.EventHandler(this.btnConnectToClient_Click);
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(155, 25);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(128, 21);
            this.cbDatabase.TabIndex = 3;
            this.cbDatabase.DropDown += new System.EventHandler(this.cbDatabase_DropDown);
            // 
            // btnConnectToDatabase
            // 
            this.btnConnectToDatabase.Location = new System.Drawing.Point(155, 64);
            this.btnConnectToDatabase.Name = "btnConnectToDatabase";
            this.btnConnectToDatabase.Size = new System.Drawing.Size(128, 36);
            this.btnConnectToDatabase.TabIndex = 4;
            this.btnConnectToDatabase.Text = "Connect to Database";
            this.btnConnectToDatabase.UseVisualStyleBackColor = true;
            this.btnConnectToDatabase.Click += new System.EventHandler(this.btnConnectToDatabase_Click);
            // 
            // lvSelectedTable
            // 
            this.lvSelectedTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.DateOfBirth});
            this.lvSelectedTable.HideSelection = false;
            this.lvSelectedTable.Location = new System.Drawing.Point(427, 16);
            this.lvSelectedTable.Name = "lvSelectedTable";
            this.lvSelectedTable.Size = new System.Drawing.Size(312, 231);
            this.lvSelectedTable.TabIndex = 5;
            this.lvSelectedTable.UseCompatibleStateImageBehavior = false;
            this.lvSelectedTable.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 100;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 100;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Text = "DateOfBirth";
            this.DateOfBirth.Width = 250;
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(427, 266);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(128, 21);
            this.cbTables.TabIndex = 6;
            this.cbTables.DropDown += new System.EventHandler(this.cbTables_DropDown);
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Step 1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(159, 9);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 13);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Step 2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(159, 49);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(38, 13);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Step 3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(424, 250);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(38, 13);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "Step 4";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(15, 371);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(191, 67);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "DASHBOARD PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(597, 371);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(191, 67);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "ADD USER PREVIEW";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.Location = new System.Drawing.Point(400, 371);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(191, 67);
            this.btnAddTicket.TabIndex = 11;
            this.btnAddTicket.Text = "ADD TICKET PREVIEW";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.lvSelectedTable);
            this.Controls.Add(this.btnConnectToDatabase);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.btnConnectToClient);
            this.Controls.Add(this.lblDatabase);
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
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnConnectToClient;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Button btnConnectToDatabase;
        private System.Windows.Forms.ListView lvSelectedTable;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader DateOfBirth;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddTicket;
    }
}

