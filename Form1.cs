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

        public Form1()
        {
            InitializeComponent();

            dataPersonView.DataSource = listOfPersons;

            spolBox.Items.Add('M');
            spolBox.Items.Add('F');
            spolBox.SelectedIndex = 0;
        }

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

        private void imeBox_Validated(object sender, EventArgs e)
        {
            if (imeBox.Text.Length > 0)
            {
                progressBar.Value += 17;
            }
            else if (imeBox.Text == "" && progressBar.Value != 0) { progressBar.Value -= 17; }
        }
    }
}
