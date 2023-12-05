using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        ObservableCollection<Person> ListOfPersons = new ObservableCollection<Person>()
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

            dataPersonView.DataSource = ListOfPersons;

            spolBox.Items.Add('M');
            spolBox.Items.Add('F');
            spolBox.SelectedIndex = 0;
            progressBar.Value = 34;

        }
        //DID_IT - 02 Finaly get to the POINT and try list sorting.
        //DID_IT - 02.1 Sort works!! Now how to make individual column to sort by it self?
        //TODO - 02.2 Maybe some other sort of check, like a switch.
        bool IsColumnSorted = false;
        private void dataPersonView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!IsColumnSorted)
            {
                if (e.ColumnIndex == 0)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.Ime).ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = true;
                }
                else if (e.ColumnIndex == 1)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.Prezime).ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = true;
                }
                else if (e.ColumnIndex == 2)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.Spol).ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = true;
                }
                else if (e.ColumnIndex == 3)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.DatumRođenja).ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = true;
                }
                else if (e.ColumnIndex == 4)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.Država).ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = true;
                }
                else if (e.ColumnIndex == 5)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.MjestoRođenja).ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = true;
                }
            }
            else if (IsColumnSorted)
            {
                if (e.ColumnIndex == 0)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.Ime).Reverse().ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = false;
                }
                else if (e.ColumnIndex == 1)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.Prezime).Reverse().ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = false;
                }
                else if (e.ColumnIndex == 2)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.Spol).Reverse().ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = false;
                }
                else if (e.ColumnIndex == 3)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.DatumRođenja).Reverse().ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = false;
                }
                else if (e.ColumnIndex == 4)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.Država).Reverse().ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = false;
                }
                else if (e.ColumnIndex == 5)
                {
                    List<Person> temp = ListOfPersons.ToList();
                    temp = temp.OrderBy(x => x.MjestoRođenja).Reverse().ToList();
                    ListOfPersons = new ObservableCollection<Person>() { };
                    foreach (Person person in temp)
                    {
                        ListOfPersons.Add(person);
                    }
                    IsColumnSorted = false;
                }
            }
            //ListOfPersons = (BindingList<Person>)ListOfPersons.OrderBy(x => x.Ime);
            dataPersonView.DataSource = null;
            dataPersonView.DataSource = ListOfPersons;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (progressBar.Value >= 100)
            {
                //Za ObservableCollection mora biti postavljen DataSource = null, pa ponovno DataSource = listOf... 
                ListOfPersons.Add(new Person 
                {
                    Ime = imeBox.Text,
                    Prezime = prezimeBox.Text,
                    Spol = (char)spolBox.SelectedItem,
                    DatumRođenja = datumBox.Value,
                    Država = drzavaBox.Text,
                    MjestoRođenja = mjestoBox.Text,
                });

                progressBar.Value = 34;
                imeBox.Text = string.Empty;
                prezimeBox.Text = string.Empty;
                drzavaBox.Text = string.Empty;
                mjestoBox.Text = string.Empty;
                IsImeEmpty = true;
                IsPrezimeEmpty = true;
                IsDrzavaEmpty = true;
                IsMjestoEmpty = true;

            }else
            {
                MessageBox.Show("Fill all data boxes.", "Fill error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataPersonView.DataSource = null;
            dataPersonView.DataSource = ListOfPersons;
        }

        bool IsImeEmpty = true;
        //DID_IT - 01 Make a bool for {value != ""} to fix a repeted progress bar fill.
        //DID_IT - 01.1 Some bug with bar emptying when a field is empty and field is changed.
        //TODO - 01.2 Another bug after adding value. Can't add another and 
        private void imeBox_Validated(object sender, EventArgs e)
        {
            if (imeBox.Text.Length > 0 && IsImeEmpty)
            {
                progressBar.Value += 17;
                IsImeEmpty = false;
            }
            else if (imeBox.Text == "" && progressBar.Value != 0 && !IsImeEmpty) { 
                progressBar.Value -= 17;
                IsImeEmpty = true;
            }
        }
        bool IsPrezimeEmpty = true;
        private void prezimeBox_Validated(object sender, EventArgs e)
        {
            if (prezimeBox.Text.Length > 0 && IsPrezimeEmpty)
            {
                progressBar.Value += 17;
                IsPrezimeEmpty = false;
            }
            else if (prezimeBox.Text == "" && progressBar.Value != 0 && !IsPrezimeEmpty)
            {
                progressBar.Value -= 17;
                IsPrezimeEmpty = true;
            }
        }
        bool IsDrzavaEmpty = true;
        private void drzavaBox_Validated(object sender, EventArgs e)
        {
            if (drzavaBox.Text.Length > 0 && IsDrzavaEmpty)
            {
                progressBar.Value += 17;
                IsDrzavaEmpty = false;
            }
            else if (drzavaBox.Text == "" && progressBar.Value != 0 && !IsDrzavaEmpty)
            {
                progressBar.Value -= 17;
                IsDrzavaEmpty = true;
            }
        }
        bool IsMjestoEmpty = true;
        private void mjestoBox_Validated(object sender, EventArgs e)
        {
            if (mjestoBox.Text.Length > 0 && IsMjestoEmpty)
            {
                progressBar.Value += 17;
                IsMjestoEmpty = false;
            }
            else if (mjestoBox.Text == "" && progressBar.Value != 0 && !IsMjestoEmpty)
            {
                progressBar.Value -= 17;
                IsMjestoEmpty = true;
            }
        }
    }
}
