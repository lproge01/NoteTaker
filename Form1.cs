using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        string filePath = "notes.csv"; // Path to store the notes

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            PreviousNotes.DataSource = notes;
            LoadNotesFromFile();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NoteBox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleBox.Text) || string.IsNullOrWhiteSpace(NoteBox.Text))
            {
                MessageBox.Show("Title or Note cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editing)
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Note"] = NoteBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NoteBox.Text);
            }

            SaveNotesToFile();
            TitleBox.Text = "";
            NoteBox.Text = "";
            editing = false;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PreviousNotes.CurrentCell == null || PreviousNotes.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Please select a valid note to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                NoteBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PreviousNotes.CurrentCell == null || PreviousNotes.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Please select a valid note to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                notes.Rows[PreviousNotes.CurrentCell.RowIndex].Delete();
                SaveNotesToFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreviousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    MessageBox.Show("Please select a valid note to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TitleBox.Text = notes.Rows[e.RowIndex].ItemArray[0].ToString();
                NoteBox.Text = notes.Rows[e.RowIndex].ItemArray[1].ToString();
                editing = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveNotesToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (DataRow row in notes.Rows)
                    {
                        sw.WriteLine($"{row["Title"]},{row["Note"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving notes to file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNotesFromFile()
        {
            try
            {
                if (!File.Exists(filePath))
                    return;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            notes.Rows.Add(parts[0], parts[1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading notes from file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

