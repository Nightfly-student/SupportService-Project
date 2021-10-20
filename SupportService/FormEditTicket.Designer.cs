
namespace SupportService
{
    partial class FormEditTicket
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
            this.lstEditTicket = new System.Windows.Forms.ListView();
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssignedTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbPriorityEdit = new System.Windows.Forms.ComboBox();
            this.cbAssignedToEdit = new System.Windows.Forms.ComboBox();
            this.cbStatusEdit = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnAssignedTo = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEditTicket
            // 
            this.lstEditTicket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Subject,
            this.Status,
            this.AssignedTo,
            this.Priority});
            this.lstEditTicket.HideSelection = false;
            this.lstEditTicket.Location = new System.Drawing.Point(12, 25);
            this.lstEditTicket.Name = "lstEditTicket";
            this.lstEditTicket.Size = new System.Drawing.Size(776, 176);
            this.lstEditTicket.TabIndex = 0;
            this.lstEditTicket.UseCompatibleStateImageBehavior = false;
            this.lstEditTicket.View = System.Windows.Forms.View.Details;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 140;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 120;
            // 
            // AssignedTo
            // 
            this.AssignedTo.Text = "Assigned to";
            this.AssignedTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AssignedTo.Width = 140;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Priority.Width = 120;
            // 
            // cbPriorityEdit
            // 
            this.cbPriorityEdit.FormattingEnabled = true;
            this.cbPriorityEdit.Location = new System.Drawing.Point(12, 396);
            this.cbPriorityEdit.Name = "cbPriorityEdit";
            this.cbPriorityEdit.Size = new System.Drawing.Size(160, 33);
            this.cbPriorityEdit.TabIndex = 1;
            // 
            // cbAssignedToEdit
            // 
            this.cbAssignedToEdit.FormattingEnabled = true;
            this.cbAssignedToEdit.Location = new System.Drawing.Point(12, 321);
            this.cbAssignedToEdit.Name = "cbAssignedToEdit";
            this.cbAssignedToEdit.Size = new System.Drawing.Size(160, 33);
            this.cbAssignedToEdit.TabIndex = 2;
            // 
            // cbStatusEdit
            // 
            this.cbStatusEdit.FormattingEnabled = true;
            this.cbStatusEdit.Location = new System.Drawing.Point(12, 234);
            this.cbStatusEdit.Name = "cbStatusEdit";
            this.cbStatusEdit.Size = new System.Drawing.Size(160, 33);
            this.cbStatusEdit.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 206);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Location = new System.Drawing.Point(7, 284);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(125, 25);
            this.lblAssignedTo.TabIndex = 7;
            this.lblAssignedTo.Text = "Assigned to";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(12, 357);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(79, 25);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Priority";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(235, 207);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(144, 85);
            this.btnStatus.TabIndex = 9;
            this.btnStatus.Text = "Status aanpassen";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnAssignedTo
            // 
            this.btnAssignedTo.Location = new System.Drawing.Point(429, 207);
            this.btnAssignedTo.Name = "btnAssignedTo";
            this.btnAssignedTo.Size = new System.Drawing.Size(144, 85);
            this.btnAssignedTo.TabIndex = 10;
            this.btnAssignedTo.Text = "Assigned to aanpassen";
            this.btnAssignedTo.UseVisualStyleBackColor = true;
            this.btnAssignedTo.Click += new System.EventHandler(this.btnAssignedTo_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Location = new System.Drawing.Point(603, 207);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(144, 85);
            this.btnPriority.TabIndex = 11;
            this.btnPriority.Text = "Priority aanpassen";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // FormEditTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.btnAssignedTo);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblAssignedTo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatusEdit);
            this.Controls.Add(this.cbAssignedToEdit);
            this.Controls.Add(this.cbPriorityEdit);
            this.Controls.Add(this.lstEditTicket);
            this.Name = "FormEditTicket";
            this.Text = "FormEditTicket";
            this.Load += new System.EventHandler(this.FormEditTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstEditTicket;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader AssignedTo;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ComboBox cbPriorityEdit;
        private System.Windows.Forms.ComboBox cbAssignedToEdit;
        private System.Windows.Forms.ComboBox cbStatusEdit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnAssignedTo;
        private System.Windows.Forms.Button btnPriority;
    }
}