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

namespace Filesystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // System.IO
            //StreamWriter sw = new StreamWriter("demo.txt");
            //sw.Write(textBoxEingabe.Text);
            //sw.Flush();
            //sw.Close();

            //FileStream stream = new FileStream("demo.txt", FileMode.OpenOrCreate);
            //byte[] textData = Encoding.Default.GetBytes(textBoxEingabe.Text);
            //stream.Write(textData, 0, textData.Length);
            //stream.Close();

            SaveFileDialog dlg = new SaveFileDialog();
            // eigenschaften setzen...
            dlg.Title = "Datei speichern";
            dlg.Filter = "Textdatei |*.txt";

            dlg.ShowDialog();


            File.WriteAllText(dlg.FileName, textBoxEingabe.Text);

            // Praktische Features von "File"
            // File.Exists
            // File.AppendText
            File.SetCreationTime("demo.txt", new DateTime(1856, 3, 11, 22, 10, 35));

            // Für Ordner: Directory
            
            // Dialoge:
            // SaveFileDialog, OpenFileDialog
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader("demo.txt");
            //string inhalt = sr.ReadToEnd();
            //sr.Close();
            //MessageBox.Show(inhalt);

            OpenFileDialog dlg = new OpenFileDialog();
            // eigenschaften setzen...
            dlg.Title = "Datei öffnen";
            dlg.Filter = "Textdatei |*.txt";

            dlg.ShowDialog();
            MessageBox.Show(File.ReadAllText(dlg.FileName));
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hier ist deine Hilfe: 🎁");
        }
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // Formular schließen
        }
    }
}
