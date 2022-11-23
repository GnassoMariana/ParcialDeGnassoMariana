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
using Esferas.Datos;

namespace Esferas.WF
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }


        private RepositorioEsferas repositorio;
        private int cantidad;
        private List<Esfera> listaEsferas;



        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioEsferas();
            cantidad = repositorio.GetCantidad();
            MostrarTotal();

            if (cantidad > 0)
            {
                listaEsferas = repositorio.GetLista();
                MostrarLista();
            }
        }


        private void MostrarLista()
        {
            esferasDataGridView.Rows.Clear();
            foreach (var esfera in listaEsferas)
            {
                var row = ConstruirFila();
                SetearFila(row, esfera);
                AgregarFila(row);
            }
        }

        private void MostrarTotal()
        {
            cantidadLabel.Text = cantidad.ToString();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FormularioAE formularioae = new FormularioAE() { Text = "Nueva esfera" };
            DialogResult dr = formularioae.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            Esfera esfera = formularioae.GetEsfera();
            repositorio.AgregarEsfera(esfera);

            DataGridViewRow row = ConstruirFila();
            SetearFila(row, esfera);
            AgregarFila(row);

            MessageBox.Show("Esfera agregada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cantidad = repositorio.GetCantidad();
            MostrarTotal();


        }

        private void AgregarFila(DataGridViewRow row)
        {
            esferasDataGridView.Rows.Add(row);
        }

        private void SetearFila(DataGridViewRow row, Esfera esfera)
        {
            row.Cells[radioColumn.Index].Value = esfera.Radio;
            row.Cells[colorColumn.Index].Value = esfera.Color;
            row.Cells[trazoColumn.Index].Value = esfera.Trazo;
            row.Cells[areaColumn.Index].Value = esfera.GetArea().ToString("N2");
            row.Cells[volumenColumn.Index].Value = esfera.GetVolumen().ToString("N2");

            row.Tag = esfera;

        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(esferasDataGridView);
            return row;
        }

        private void CancelarButtonPrincipal_Click(object sender, EventArgs e)
        {
            ManejadorSecuencial.GuardarEsferasSecuencial(repositorio.GetLista());
            Application.Exit();
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (esferasDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = esferasDataGridView.SelectedRows[0];
            Esfera esfera = row.Tag as Esfera;
            listaEsferas = repositorio.GetLista();

            DialogResult dr = MessageBox.Show("Desea borrar la esfera seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }

            if (repositorio.BorrarEsfera(esfera))
            {
                listaEsferas.Remove(esfera);
                esferasDataGridView.Rows.Remove(row);

                MessageBox.Show("Esfera borrada", "", MessageBoxButtons.OK);

                cantidad = repositorio.GetCantidad();
                MostrarLista();
            }
            else
            {
                MessageBox.Show("No se pudo borrar", "", MessageBoxButtons.OK);
            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (esferasDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = esferasDataGridView.SelectedRows[0];
            Esfera esfera = row.Tag as Esfera;

            FormularioAE formularioAE = new FormularioAE() { Text = "Editar esfera" };
            formularioAE.SetEsfera(esfera);

            DialogResult dr = formularioAE.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            esfera = formularioAE.GetEsfera();
            SetearFila(row, esfera);

            MessageBox.Show("Esfera modificada", "", MessageBoxButtons.OK);



        }

        private void SalirToolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult dr = ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            ManejadorSecuencial.GuardarEsferasSecuencial(repositorio.GetLista());
            Application.Exit();
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            ManejadorSecuencial.GuardarEsferasSecuencial(repositorio.GetLista());
            MessageBox.Show("Registros guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FiltrarToolStripButton_Click(object sender, EventArgs e)
        {
            var esferaString = Microsoft.VisualBasic.Interaction.InputBox("Ingresar el radio a filtrar", "", "0", 300, 300);
            if (!int.TryParse(esferaString, out int radioFiltro))
            {
                return;
            }
            else if (radioFiltro<=0)
            {
                return;
            }

            listaEsferas = repositorio.FiltrarEsfera(radioFiltro);
            MostrarLista();

            cantidad = repositorio.GetCantidadFiltrada(radioFiltro);
            MostrarTotal();
            

            
        }

        private void RestaurarToolStripButton_Click(object sender, EventArgs e)
        {
            listaEsferas = repositorio.GetLista();
            MostrarLista();
            cantidad = repositorio.GetCantidad();
            MostrarTotal();
        }

        
    }
            

}
