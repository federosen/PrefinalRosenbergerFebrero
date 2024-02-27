using CuadrilaterosPOO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadrilaterosPOO.Windows
{
    public partial class frmCuadrilaterosEdit : Form
    {
        private Cuadrilateros cuadrilateros;
        public frmCuadrilaterosEdit()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (cuadrilateros != null)
            {
                LadoAtextBox.Text = cuadrilateros.ladoA.ToString();
                LadoBtextBox.Text = cuadrilateros.ladoB.ToString();
            }
        }

        internal Cuadrilateros GetCuadrilateros()
        {
            double ladoA = Convert.ToDouble(LadoAtextBox.Text);
            double ladoB = Convert.ToDouble(LadoBtextBox.Text);

            return cuadrilateros;
        }


        private void OKbutton_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                cuadrilateros = new Cuadrilateros();
                cuadrilateros.ladoA = int.Parse(LadoAtextBox.Text);
                cuadrilateros.ladoB = int.Parse(LadoBtextBox.Text);

                if (cuadrilateros.Validar())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("lados mal ingresados", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        internal void SetCuadrilateros(Cuadrilateros copiaCuadrilateros)
        {
            this.cuadrilateros = copiaCuadrilateros;
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!int.TryParse(LadoAtextBox.Text, out int ladoMayor))
            {
                esValido = false;
                errorProvider1.SetError(LadoAtextBox, "Lado mal ingresado");
            }

            if (!int.TryParse(LadoBtextBox.Text, out int ladoMenor))
            {
                esValido = false;
                errorProvider1.SetError(LadoBtextBox, "Lado mal ingresado");
            }

            return esValido;
        }
    }
}
