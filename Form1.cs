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

        List<Person> listOfPersons = new List<Person>()
        { new Person {
            Ime = "Peter",
            Prezime = "Falk",
            Spol = 'M',
            DatumRođenja = new DateTime(16 / 9 / 1927),
            Država = "SAD",
            MjestoRođenja = "New York" },
        new Person {
            Ime = "Antonio",
            Prezime = "Banderas",
            Spol = 'M',
            DatumRođenja = new DateTime(10 / 8 / 1960),
            Država = "Španjolska",
            MjestoRođenja = "Malaga" },
        new Person {
            Ime = "Tomislav",
            Prezime = "Trifunović",
            Spol = 'M',
            DatumRođenja = new DateTime(22 / 2 / 1947),
            Država = "Srbija",
            MjestoRođenja = "Mali Popović" },
        new Person {
            Ime = "Sonja",
            Prezime = "Kovač",
            Spol = 'F',
            DatumRođenja = new DateTime(18 / 6 / 1984),
            Država = "Hrvatska",
            MjestoRođenja = "Bjelovar" }
        };

        public Form1()
        {
            InitializeComponent();

            dataPersonView.DataSource = listOfPersons;

            spolBox.Items.Add('M');
            spolBox.Items.Add('F');
        }

        private void dataPersonView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataPersonView.Sort(dataGridViewColumn.Ime, ListSortDirection.Ascending);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listOfPersons.Add(new Person
            {
                Ime = imeBox.Text,
                Prezime = prezimeBox.Text,
                Spol = (char)spolBox.SelectedItem,
                DatumRođenja = DateTime.Parse(DatumBox.Text),
                Država = drzavaBox.Text,
                MjestoRođenja = mjestoBox.Text
            });

            dataPersonView.DataSource = listOfPersons;
        }
    }
}
