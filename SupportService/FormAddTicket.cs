using SupportLogic;
using SupportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SupportDAO;

namespace SupportService
{
    public partial class FormAddTicket : Form
    {
        private Person _loggedInPerson;

        public FormAddTicket(Person person)
        {
            InitializeComponent();
            _loggedInPerson = person;
            if (_loggedInPerson.UserType == UserType.Employee)
            {
                cbAssignedTo.Hide();
                lblAssignedTo.Hide();
            }
        }

        private void FormAddTicket_Load(object sender, EventArgs e)
        {
            FormAddTicket_Shown(sender, e);

            foreach (var value in Enum.GetValues(typeof(TypeOfIncident)))
            {
                cbIncidentType.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
            }
            foreach (var value in Enum.GetValues(typeof(Priority)))
            {
                cbPriority.Items.Add(MongoDatabaseLogic.Instance.GetEnumName(value));
            }

            List<Person> people = MongoDatabaseLogic.Instance.GetUsers();
            foreach (Person item in MongoDatabaseLogic.Instance.GetUsers())
            {
                if (_loggedInPerson.UserType == UserType.Employee && _loggedInPerson.Id != item.Id)
                    continue;
                cbReportedBy.Items.Add(item);
            }

            foreach (Person item in MongoDatabaseLogic.Instance.GetUsers())
            {
                if (_loggedInPerson.UserType == UserType.ServiceDesk && _loggedInPerson.Id != item.Id)
                {
                    cbAssignedTo.Items.Add(item);
                }
            }


            if (cbReportedBy.Items.Count == 1)
                cbReportedBy.SelectedIndex = 0;
        }

        private void FormAddTicket_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                MongoDatabaseLogic.Instance.ConnectToDatabase("NoDesk");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong connecting to the database!\n\n" + exception.Message,
                    "Oops!", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                Close();
            }
        }

        private void btn_AddTicket_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                MessageBox.Show("Please fill in all fields.", "Error!");
                return;
            }
            int days = 0;
            switch (cbDeadline.Text)
            {
                case "7 days":
                    days = 7;
                    break;

                case "14 days":
                    days = 14;
                    break;

                case "28 days":
                    days = 28;
                    break;

                case "6 months":
                    days = 182;
                    break;
            }
            DateTime time = DateTime.Now;

            Person person = (Person) cbReportedBy.SelectedItem;
            Person assignedTo = (Person)cbAssignedTo.SelectedItem;

           
             
            try
            {
                Ticket ticket;
                if (_loggedInPerson.UserType == UserType.ServiceDesk)
                {
                    ticket = new Ticket(time, tbSubject.Text, MongoDatabaseLogic.Instance.GetEnumValue<TypeOfIncident>(cbIncidentType.Text),
                        person.Id, assignedTo.Id, MongoDatabaseLogic.Instance.GetEnumValue<Priority>(cbPriority.Text), time.AddDays(days), tbDescription.Text);

                    
                }
                else 
                {
                    ticket = new Ticket(time, tbSubject.Text, MongoDatabaseLogic.Instance.GetEnumValue<TypeOfIncident>(cbIncidentType.Text),
                       person.Id, MongoDatabaseLogic.Instance.GetEnumValue<Priority>(cbPriority.Text), time.AddDays(days), tbDescription.Text);
                }

                MongoDatabaseLogic.Instance.InsertItem("Tickets", ticket); 
                MessageBox.Show($"Ticket added!");
            }
            catch (Exception exception)
            {
               MessageBox.Show($"Something failed\n{exception.Message}\nTicket was not added");
            }
            
        }

        private bool CheckFields()
        {
            bool allChecked = true;
            foreach (Control ctrl in pnlControls.Controls)
            {
                switch (ctrl)
                {
                    case TextBox textBox:
                        if (!ValidationTextBox(textBox, "Field may not be empty!"))
                            allChecked = false;
                        break;
                    case ComboBox comboBox:
                        if (!ValidationComboBox(comboBox, "Field may not be empty!"))
                            allChecked = false;
                        break;
                }
            }

            return allChecked;
        }

        private bool ValidationTextBox(TextBox textBox, string error)
        {
            // check if textboxes aren't empty
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, error);
                return false;
            }
            errorProvider.SetError(textBox, null);
            return true;
        }

        private bool ValidationComboBox(ComboBox comboBox, string error)
        {
            // check if index is selected
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, error);
                return false;
            }
            errorProvider.SetError(comboBox, null);
            return true;
        }

       
    }
}