
namespace SupportService
{
    partial class FormOverviewTickets
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
            this.lstTickets = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.txtFilterUsers = new System.Windows.Forms.TextBox();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstTickets
            // 
            this.lstTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Subject,
            this.User,
            this.Date,
            this.Status});
            this.lstTickets.HideSelection = false;
            this.lstTickets.Location = new System.Drawing.Point(34, 145);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(980, 845);
            this.lstTickets.TabIndex = 0;
            this.lstTickets.UseCompatibleStateImageBehavior = false;
            this.lstTickets.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Overview tickets";
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateIncident.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateIncident.Location = new System.Drawing.Point(826, 65);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(175, 60);
            this.btnCreateIncident.TabIndex = 2;
            this.btnCreateIncident.Text = "Create Incident";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // txtFilterUsers
            // 
            this.txtFilterUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterUsers.Location = new System.Drawing.Point(34, 85);
            this.txtFilterUsers.Margin = new System.Windows.Forms.Padding(6);
            this.txtFilterUsers.MaxLength = 120;
            this.txtFilterUsers.Name = "txtFilterUsers";
            this.txtFilterUsers.Size = new System.Drawing.Size(364, 26);
            this.txtFilterUsers.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 120;
            // 
            // User
            // 
            this.User.Text = "User";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 240;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 120;
            // 
            // FormOverviewTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 1002);
            this.Controls.Add(this.txtFilterUsers);
            this.Controls.Add(this.btnCreateIncident);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTickets);
            this.Name = "FormOverviewTickets";
            this.Text = "FormOverviewTickets";
            this.Load += new System.EventHandler(this.FormOverviewTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.TextBox txtFilterUsers;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
    }
}