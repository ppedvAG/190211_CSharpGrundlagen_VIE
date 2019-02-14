using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatenUndEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dasDing.Aufgabe50Prozent += AufgabenLogger;
            dasDing.Aufgabe80Prozent += AufgabenLogger2;
            dasDing.Aufgabe100Prozent += AufgabenLogger3;
        }

        private void AufgabenLogger3(object sender, EventArgs e)
        {
            MessageBox.Show("100%");
        }

        private void AufgabenLogger2(object sender, EventArgs e)
        {
            MessageBox.Show("80%");
        }

        private void AufgabenLogger(object sender, EventArgs e)
        {
            MessageBox.Show("50%");
        }

        private Maschine dasDing = new Maschine();

        public delegate void MeinDelegat(); // Signatur: void .. ()
        public delegate void MeinDelegatMitInt(int zahl1); // Signatur: void .. ()

        private void buttonKlickMich_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hallo Welt");
            #region delegate

            //MeinDelegat del = new MeinDelegat(A);
            //del += B; // Zusätzlich auch noch B ausführen

            //MeinDelegatMitInt meinC = new MeinDelegatMitInt(C);
            //meinC(12);

            //del(); 
            #endregion

            #region Delegaten-Typen
            //// void -> keine Rückgabe
            //Action meineAction = new Action(A);
            //Action<int> meinC = new Action<int>(C);

            //// func<out> -> alles mit Rückgabe
            //Func<int, int, int> rechner = new Func<int, int, int>(Add);

            //// Für UI
            //EventHandler meinHandler = new EventHandler(MeineMethode); 
            #endregion

            #region Event
            //SpezialButton b = new SpezialButton();
            //b.ButtonClickEvent += SpezialButtonClick;
            //b.ButtonClickEvent += Logger;

            //b.Klick();

            //b.ButtonClickEvent = null; // verboten

            //b.Klick();
            //b.ButtonClickEvent -= Logger;

            //b.Klick();
            //b.Klick();
            //b.Klick(); 
            #endregion

            dasDing.SuperlangeAufgabe();
        }

        private void Logger(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToLongTimeString());
        }

        private void SpezialButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Der Spezialbutton wird geklickt");
        }

        private void MeineMethode(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void A()
        {
            MessageBox.Show("A");
        }
        public void B()
        {
            MessageBox.Show("B");
        }
        public void C(int zahl)
        {
            MessageBox.Show("C" + zahl);
        }
        public int Add(int z1, int z2)
        {
            return z1 + z2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
