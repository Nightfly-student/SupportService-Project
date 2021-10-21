
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
            this.components = new System.ComponentModel.Container();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbIncidentType = new System.Windows.Forms.ComboBox();
            this.lblIncidentType = new System.Windows.Forms.Label();
            this.lblReportedBy = new System.Windows.Forms.Label();
            this.cbReportedBy = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.cbDeadline = new System.Windows.Forms.ComboBox();
            this.btn_AddTicket = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cbAssignedTo = new System.Windows.Forms.ComboBox();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubject.Location = new System.Drawing.Point(6, 10);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSubject.MaxLength = 25;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(388, 29);
            this.tbSubject.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(36, 108);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(166, 22);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject of incident";
            // 
            // cbIncidentType
            // 
            this.cbIncidentType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncidentType.FormattingEnabled = true;
            this.cbIncidentType.Location = new System.Drawing.Point(6, 75);
            this.cbIncidentType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbIncidentType.Name = "cbIncidentType";
            this.cbIncidentType.Size = new System.Drawing.Size(388, 30);
            this.cbIncidentType.TabIndex = 2;
            // 
            // lblIncidentType
            // 
            this.lblIncidentType.AutoSize = true;
            this.lblIncidentType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentType.Location = new System.Drawing.Point(36, 173);
            this.lblIncidentType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIncidentType.Name = "lblIncidentType";
            this.lblIncidentType.Size = new System.Drawing.Size(144, 22);
            this.lblIncidentType.TabIndex = 0;
            this.lblIncidentType.Text = "Type of incident";
            // 
            // lblReportedBy
            // 
            this.lblReportedBy.AutoSize = true;
            this.lblReportedBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportedBy.Location = new System.Drawing.Point(36, 242);
            this.lblReportedBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReportedBy.Name = "lblReportedBy";
            this.lblReportedBy.Size = new System.Drawing.Size(157, 22);
            this.lblReportedBy.TabIndex = 0;
            this.lblReportedBy.Text = "Reported by user";
            // 
            // cbReportedBy
            // 
            this.cbReportedBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReportedBy.FormattingEnabled = true;
            this.cbReportedBy.Location = new System.Drawing.Point(6, 144);
            this.cbReportedBy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbReportedBy.Name = "cbReportedBy";
            this.cbReportedBy.Size = new System.Drawing.Size(388, 30);
            this.cbReportedBy.TabIndex = 3;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(36, 388);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(68, 22);
            this.lblPriority.TabIndex = 0;
            this.lblPriority.Text = "Priority";
            // 
            // cbPriority
            // 
            this.cbPriority.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(6, 290);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(388, 30);
            this.cbPriority.TabIndex = 5;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(36, 462);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.cbDeadline.Location = new System.Drawing.Point(6, 363);
            this.cbDeadline.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(388, 30);
            this.cbDeadline.TabIndex = 6;
            // 
            // btn_AddTicket
            // 
            this.btn_AddTicket.Location = new System.Drawing.Point(44, 871);
            this.btn_AddTicket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_AddTicket.Name = "btn_AddTicket";
            this.btn_AddTicket.Size = new System.Drawing.Size(232, 150);
            this.btn_AddTicket.TabIndex = 8;
            this.btn_AddTicket.Text = "Add Ticket";
            this.btn_AddTicket.UseVisualStyleBackColor = true;
            this.btn_AddTicket.Click += new System.EventHandler(this.btn_AddTicket_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(36, 535);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 22);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(6, 437);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbDescription.MaxLength = 1000;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(774, 292);
            this.tbDescription.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.tbSubject);
            this.pnlControls.Controls.Add(this.cbIncidentType);
            this.pnlControls.Controls.Add(this.tbDescription);
            this.pnlControls.Controls.Add(this.cbReportedBy);
            this.pnlControls.Controls.Add(this.cbPriority);
            this.pnlControls.Controls.Add(this.cbDeadline);
            this.pnlControls.Location = new System.Drawing.Point(406, 92);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(844, 748);
            this.pnlControls.TabIndex = 11;
            // 
            // cbAssignedTo
            // 
            this.cbAssignedTo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssignedTo.FormattingEnabled = true;
            this.cbAssignedTo.Location = new System.Drawing.Point(412, 308);
            this.cbAssignedTo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbAssignedTo.Name = "cbAssignedTo";
            this.cbAssignedTo.Size = new System.Drawing.Size(388, 30);
            this.cbAssignedTo.TabIndex = 4;
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedTo.Location = new System.Drawing.Point(36, 313);
            this.lblAssignedTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(111, 22);
            this.lblAssignedTo.TabIndex = 12;
            this.lblAssignedTo.Text = "Assigned to";
            // 
            // FormAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 1029);
            this.Controls.Add(this.cbAssignedTo);
            this.Controls.Add(this.lblAssignedTo);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btn_AddTicket);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblReportedBy);
            this.Controls.Add(this.lblIncidentType);
            this.Controls.Add(this.lblSubject);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormAddTicket";
            this.Load += new System.EventHandler(this.FormAddTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbIncidentType;
        private System.Windows.Forms.Label lblIncidentType;
        private System.Windows.Forms.Label lblReportedBy;
        private System.Windows.Forms.ComboBox cbReportedBy;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.ComboBox cbDeadline;
        private System.Windows.Forms.Button btn_AddTicket;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.ComboBox cbAssignedTo;
    }
}