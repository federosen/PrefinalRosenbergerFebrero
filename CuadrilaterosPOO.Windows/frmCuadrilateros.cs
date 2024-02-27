using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuadrilaterosPOO.Entidades;
using CuadrilaterosPOO.Datos;

namespace CuadrilaterosPOO.Windows
{
    public partial class frmCuadrilateros : Form
    {
        public frmCuadrilateros()
        {
            InitializeComponent();
        }
        private List<Cuadrilateros> lista;
        private Repositorio repositorio;
        private int CantidadDeRegistros;


        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView1.Rows.Clear();
            foreach (var cuadrilateros in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetFila(r, cuadrilateros);
                AgregarFila(r);
            }
        }

        //Agrega fila
        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView1.Rows.Add(r);
        }

        //Construye fila
        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView1);
            return r;
        }

        //Muestra de datos
        private void SetFila(DataGridViewRow r, Cuadrilateros cuadrilateros)
        {
            r.Cells[ColumnaLadoA.Index].Value = cuadrilateros.ladoA;
            r.Cells[ColumnaLadoB.Index].Value = cuadrilateros.ladoB;
            r.Cells[ColumnaArea.Index].Value = cuadrilateros.GetArea();
            r.Cells[ColumnaPerimetro.Index].Value = cuadrilateros.GetPerimetro();

            r.Tag = cuadrilateros;
        }

        //Metodo para agregar datos
        private void NuevotoolStripButton1_Click(object sender, EventArgs e)
        {
            frmCuadrilaterosEdit frm = new frmCuadrilaterosEdit() { Text = "Agregar Cuadrilatero" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Cuadrilateros cuadrilateros = frm.GetCuadrilateros();
            if (repositorio.Existe(cuadrilateros))
            {
                MessageBox.Show("Cuadrilatero repetido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            repositorio.Agregar(cuadrilateros);
            var r = ConstruirFila();
            SetFila(r, cuadrilateros);
            AgregarFila(r);
            MessageBox.Show("Cuadrilateros agregado correctamente", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView1.SelectedRows[0];
                Cuadrilateros cuadrilateros = (Cuadrilateros)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea borrar el regisrto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    repositorio.Borrar(cuadrilateros);
                    DatosDataGridView1.Rows.Remove(r);
                    MessageBox.Show("Registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ActualizarCantidadDeRegistros(repositorio.GetCantidad(predicado));
                }
            }
        }

        private void EditartoolStripButton2_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView1.SelectedRows[0];
            Cuadrilateros CuadrilaterosSeleccionado = (Cuadrilateros)r.Tag;
            Cuadrilateros copiaCuadrilateros = (Cuadrilateros)CuadrilaterosSeleccionado.Clone();
            frmCuadrilaterosEdit frm = new frmCuadrilaterosEdit();
            frm.SetCuadrilateros(copiaCuadrilateros);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            copiaCuadrilateros = frm.GetCuadrilateros();
            if (repositorio.Existe(copiaCuadrilateros))
            {
                MessageBox.Show("Cuadrilatero existente!!!");
                return;

            }
            else
            {
                repositorio.Editar(CuadrilaterosSeleccionado, copiaCuadrilateros);
                SetFila(r, copiaCuadrilateros);
                MessageBox.Show("Registro agregado");
            }


        }

        private void SalirtoolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCuadrilateros_Load_1(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
            CantidadDeRegistros = repositorio.GetCantidad();
            if (CantidadDeRegistros > 0)
            {
                lista = repositorio.GetList();
                MostrarDatosEnGrilla();
                //ActualizarCantidadDeRegistros(CantidadDeRegistros);
            }
        }
    }
}
