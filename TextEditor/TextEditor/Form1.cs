using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State.Text = "Opening...";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }

                Saved.Text = "Сохранен";
            }

            State.Text = "Ready";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State.Text = "Saving...";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default))
                {
                    writer.Write(richTextBox1.Text);
                }
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))

                Saved.Text = "Сохранен";
            }

            State.Text = "Ready";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Saved.Text = "Изменен";
        }

        private void abortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
