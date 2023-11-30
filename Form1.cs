using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSH_project2
{
    public partial class Form1 : Form
    {

        class Person
        {
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public char Spol { get; set; }
            public DateTime DatumRođenja { get; set; }
            public string Država { get; set; }
            public string MjestoRođenja { get; set; }

        }

        BindingList<Person> listOfPersons = new BindingList<Person> ()
        { new Person {
            Ime = "Peter",
            Prezime = "Falk",
            Spol = 'M',
            DatumRođenja = new DateTime(1927, 9, 16),
            Država = "SAD",
            MjestoRođenja = "New York" },
        new Person {
            Ime = "Antonio",
            Prezime = "Banderas",
            Spol = 'M',
            DatumRođenja = new DateTime(1960, 8, 10),
            Država = "Španjolska",
            MjestoRođenja = "Malaga" },
        new Person {
            Ime = "Tomislav",
            Prezime = "Trifunović",
            Spol = 'M',
            DatumRođenja = new DateTime(1947, 2, 22),
            Država = "Srbija",
            MjestoRođenja = "Mali Popović" },
        new Person {
            Ime = "Sonja",
            Prezime = "Kovač",
            Spol = 'F',
            DatumRođenja = new DateTime(1984, 6, 18),
            Država = "Hrvatska",
            MjestoRođenja = "Bjelovar" }
        };

        //TODO - 03 Try adding tabs for possible other projects.
        public Form1()
        {
            InitializeComponent();

            dataPersonView.DataSource = listOfPersons;

            spolBox.Items.Add('M');
            spolBox.Items.Add('F');
            spolBox.SelectedIndex = 0;
            progressBar.Value = 34;

        }
        //TODO - 02 Finaly get to the POINT and try list sorting.
        private void dataPersonView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //listOfPersons = (BindingList<Person>)listOfPersons.OrderBy(x => x.Ime);
            dataPersonView.DataSource = listOfPersons;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (progressBar.Value >= 100)
            {

                listOfPersons.Add(new Person
                {
                    Ime = imeBox.Text,
                    Prezime = prezimeBox.Text,
                    Spol = (char)spolBox.SelectedItem,
                    DatumRođenja = datumBox.Value,
                    Država = drzavaBox.Text,
                    MjestoRođenja = mjestoBox.Text
                });

                progressBar.Value = 0;
            }else
            {
                MessageBox.Show("Fill all data boxes.", "Fill error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dataPersonView.DataSource = null;
            dataPersonView.DataSource = listOfPersons;
        }

        bool imeIsEmpty = true;
        //DID_IT - 01 Make a bool for {value != ""} to fix a repeted progress bar fill.
        //DID_IT - 01.1 Some bug with bar emptying when a field is empty and field is changed.
        private void imeBox_Validated(object sender, EventArgs e)
        {
            if (imeBox.Text.Length > 0 && imeIsEmpty)
            {
                progressBar.Value += 17;
                imeIsEmpty = false;
            }
            else if (imeBox.Text == "" && progressBar.Value != 0 && !imeIsEmpty) { 
                progressBar.Value -= 17;
                imeIsEmpty = true;
            }
        }
        bool prezimeIsEmpty = true;
        private void prezimeBox_Validated(object sender, EventArgs e)
        {
            if (prezimeBox.Text.Length > 0 && prezimeIsEmpty)
            {
                progressBar.Value += 17;
                prezimeIsEmpty = false;
            }
            else if (prezimeBox.Text == "" && progressBar.Value != 0 && !prezimeIsEmpty)
            {
                progressBar.Value -= 17;
                prezimeIsEmpty = true;
            }
        }
        bool drzavaIsEmpty = true;
        private void drzavaBox_Validated(object sender, EventArgs e)
        {
            if (drzavaBox.Text.Length > 0 && drzavaIsEmpty)
            {
                progressBar.Value += 17;
                drzavaIsEmpty = false;
            }
            else if (drzavaBox.Text == "" && progressBar.Value != 0 && !drzavaIsEmpty)
            {
                progressBar.Value -= 17;
                drzavaIsEmpty = true;
            }
        }
        bool mjestoIsEmpty = true;
        private void mjestoBox_Validated(object sender, EventArgs e)
        {
            if (mjestoBox.Text.Length > 0 && mjestoIsEmpty)
            {
                progressBar.Value += 17;
                mjestoIsEmpty = false;
            }
            else if (mjestoBox.Text == "" && progressBar.Value != 0 && !mjestoIsEmpty)
            {
                progressBar.Value -= 17;
                mjestoIsEmpty = true;
            }
        }
    }
}
