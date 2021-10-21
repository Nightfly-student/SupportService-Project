
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
            this.btnRefreshEditTicket = new System.Windows.Forms.Button();
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
            this.lstEditTicket.Location = new System.Drawing.Point(6, 13);
            this.lstEditTicket.Margin = new System.Windows.Forms.Padding(2);
            this.lstEditTicket.Name = "lstEditTicket";
            this.lstEditTicket.Size = new System.Drawing.Size(572, 139);
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
            this.cbPriorityEdit.Location = new System.Drawing.Point(6, 327);
            this.cbPriorityEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cbPriorityEdit.Name = "cbPriorityEdit";
            this.cbPriorityEdit.Size = new System.Drawing.Size(82, 21);
            this.cbPriorityEdit.TabIndex = 1;
            this.cbPriorityEdit.SelectedIndexChanged += new System.EventHandler(this.cbPriorityEdit_SelectedIndexChanged);
            // 
            // cbAssignedToEdit
            // 
            this.cbAssignedToEdit.FormattingEnabled = true;
            this.cbAssignedToEdit.Location = new System.Drawing.Point(6, 266);
            this.cbAssignedToEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cbAssignedToEdit.Name = "cbAssignedToEdit";
            this.cbAssignedToEdit.Size = new System.Drawing.Size(82, 21);
            this.cbAssignedToEdit.TabIndex = 2;
            this.cbAssignedToEdit.SelectedIndexChanged += new System.EventHandler(this.cbAssignedToEdit_SelectedIndexChanged);
            // 
            // cbStatusEdit
            // 
            this.cbStatusEdit.FormattingEnabled = true;
            this.cbStatusEdit.Location = new System.Drawing.Point(6, 201);
            this.cbStatusEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatusEdit.Name = "cbStatusEdit";
            this.cbStatusEdit.Size = new System.Drawing.Size(82, 21);
            this.cbStatusEdit.TabIndex = 3;
            this.cbStatusEdit.SelectedIndexChanged += new System.EventHandler(this.cbStatusEdit_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 171);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 18);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedTo.Location = new System.Drawing.Point(6, 237);
            this.lblAssignedTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(85, 18);
            this.lblAssignedTo.TabIndex = 7;
            this.lblAssignedTo.Text = "Assigned to";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(12, 298);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(54, 18);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Priority";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(147, 171);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(117, 79);
            this.btnStatus.TabIndex = 9;
            this.btnStatus.Text = "Status aanpassen";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnAssignedTo
            // 
            this.btnAssignedTo.Location = new System.Drawing.Point(291, 171);
            this.btnAssignedTo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignedTo.Name = "btnAssignedTo";
            this.btnAssignedTo.Size = new System.Drawing.Size(117, 79);
            this.btnAssignedTo.TabIndex = 10;
            this.btnAssignedTo.Text = "Assigned to aanpassen";
            this.btnAssignedTo.UseVisualStyleBackColor = true;
            this.btnAssignedTo.Click += new System.EventHandler(this.btnAssignedTo_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Location = new System.Drawing.Point(427, 171);
            this.btnPriority.Margin = new System.Windows.Forms.Padding(2);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(112, 79);
            this.btnPriority.TabIndex = 11;
            this.btnPriority.Text = "Priority aanpassen";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // btnRefreshEditTicket
            // 
            this.btnRefreshEditTicket.Location = new System.Drawing.Point(476, 327);
            this.btnRefreshEditTicket.Name = "btnRefreshEditTicket";
            this.btnRefreshEditTicket.Size = new System.Drawing.Size(101, 38);
            this.btnRefreshEditTicket.TabIndex = 12;
            this.btnRefreshEditTicket.Text = "Refresh";
            this.btnRefreshEditTicket.UseVisualStyleBackColor = true;
            this.btnRefreshEditTicket.Click += new System.EventHandler(this.btnRefreshEditTicket_Click);
            // 
            // FormEditTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 369);
            this.Controls.Add(this.btnRefreshEditTicket);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnRefreshEditTicket;
    }
}