using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esferas.Entidades;

namespace Esferas.WF
{
    public partial class FormularioAE : Form
    {
        public FormularioAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboBox();
        }

        private Esfera esfera;

        private void CargarComboBox()
        {
            ColorComboBox.DataSource = Enum.GetValues(typeof(ColorEsfera));
            ColorComboBox.SelectedItem = 0;
        }

        private void FormularioAE_Load(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        internal Esfera GetEsfera()
        {
            return esfera;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                esfera = new Esfera()
                {
                    Radio = int.Parse(RadioTextBox.Text),
                    Color = (ColorEsfera)ColorComboBox.SelectedItem,
                    Trazo = ContinuoRadioButton.Checked ? Trazo.Continuo : RayadoRadioButton.Checked ? Trazo.Rayado : Trazo.Punteado,

                };

                DialogResult = DialogResult.OK;
            }




        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            formAEerrorProvider.Clear();

            if (string.IsNullOrEmpty(RadioTextBox.Text))
            {
                esValido = false;
                formAEerrorProvider.SetError(RadioTextBox, "Ingresar Radio.");
            }
            else if (!int.TryParse(RadioTextBox.Text, out int radio))
            {
                esValido = false;
                formAEerrorProvider.SetError(RadioTextBox, "Radio no valido.");
            }
            
            

            

            return esValido;
           
        }

        internal void SetEsfera(Esfera esferaEditada)
        {
            esfera = esferaEditada;
        }
    }
}
