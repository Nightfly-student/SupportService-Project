
namespace SupportService
{
    partial class FormAddTicket
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
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbIncidentType = new System.Windows.Forms.ComboBox();
            this.lblIncidentType = new System.Windows.Forms.Label();
            this.dtpDateTimeReported = new System.Windows.Forms.DateTimePicker();
            this.lblReportedBy = new System.Windows.Forms.Label();
            this.tbReportedBy = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.cbDeadline = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(18, 21);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(168, 22);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date/time reported";
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubject.Location = new System.Drawing.Point(190, 55);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(196, 29);
            this.tbSubject.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(18, 58);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(166, 22);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject of incident";
            // 
            // cbIncidentType
            // 
            this.cbIncidentType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncidentType.FormattingEnabled = true;
            this.cbIncidentType.Location = new System.Drawing.Point(190, 96);
            this.cbIncidentType.Name = "cbIncidentType";
            this.cbIncidentType.Size = new System.Drawing.Size(196, 30);
            this.cbIncidentType.TabIndex = 2;
            // 
            // lblIncidentType
            // 
            this.lblIncidentType.AutoSize = true;
            this.lblIncidentType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentType.Location = new System.Drawing.Point(18, 99);
            this.lblIncidentType.Name = "lblIncidentType";
            this.lblIncidentType.Size = new System.Drawing.Size(144, 22);
            this.lblIncidentType.TabIndex = 0;
            this.lblIncidentType.Text = "Type of incident";
            // 
            // dtpDateTimeReported
            // 
            this.dtpDateTimeReported.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTimeReported.Location = new System.Drawing.Point(190, 16);
            this.dtpDateTimeReported.MaxDate = new System.DateTime(2021, 9, 17, 0, 0, 0, 0);
            this.dtpDateTimeReported.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDateTimeReported.Name = "dtpDateTimeReported";
            this.dtpDateTimeReported.Size = new System.Drawing.Size(226, 29);
            this.dtpDateTimeReported.TabIndex = 6;
            this.dtpDateTimeReported.Value = new System.DateTime(2021, 9, 16, 0, 0, 0, 0);
            this.dtpDateTimeReported.ValueChanged += new System.EventHandler(this.dtpDateTimeReported_ValueChanged);
            // 
            // lblReportedBy
            // 
            this.lblReportedBy.AutoSize = true;
            this.lblReportedBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportedBy.Location = new System.Drawing.Point(18, 144);
            this.lblReportedBy.Name = "lblReportedBy";
            this.lblReportedBy.Size = new System.Drawing.Size(157, 22);
            this.lblReportedBy.TabIndex = 0;
            this.lblReportedBy.Text = "Reported by user";
            // 
            // tbReportedBy
            // 
            this.tbReportedBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReportedBy.FormattingEnabled = true;
            this.tbReportedBy.Location = new System.Drawing.Point(190, 141);
            this.tbReportedBy.Name = "tbReportedBy";
            this.tbReportedBy.Size = new System.Drawing.Size(196, 30);
            this.tbReportedBy.TabIndex = 2;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(18, 190);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(68, 22);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Priority";
            // 
            // cbPriority
            // 
            this.cbPriority.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(190, 187);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(196, 30);
            this.cbPriority.TabIndex = 2;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(18, 237);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(165, 22);
            this.lblDeadline.TabIndex = 0;
            this.lblDeadline.Text = "Deadline/follow up";
            // 
            // cbDeadline
            // 
            this.cbDeadline.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.cbDeadline.Location = new System.Drawing.Point(190, 234);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(196, 30);
            this.cbDeadline.TabIndex = 2;
            // 
            // FormAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.dtpDateTimeReported);
            this.Controls.Add(this.cbDeadline);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.tbReportedBy);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.cbIncidentType);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lblReportedBy);
            this.Controls.Add(this.lblIncidentType);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblDateTime);
            this.Name = "FormAddTicket";
            this.Load += new System.EventHandler(this.FormAddTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbIncidentType;
        private System.Windows.Forms.Label lblIncidentType;
        private System.Windows.Forms.DateTimePicker dtpDateTimeReported;
        private System.Windows.Forms.Label lblReportedBy;
        private System.Windows.Forms.ComboBox tbReportedBy;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.ComboBox cbDeadline;
    }
}