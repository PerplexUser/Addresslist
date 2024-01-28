using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kontakte
{
    public partial class Adressliste : Form
    {
        public Adressliste()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adressliste \nGeschrieben von: Michael Lappenbusch", "Info");

        }

        private void personenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kontakteDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "kontakteDatabaseDataSet.Personen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.personenTableAdapter.Fill(this.kontakteDatabaseDataSet.Personen);

        }
    }
}
