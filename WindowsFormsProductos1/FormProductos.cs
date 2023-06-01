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
using Entidades;


namespace WindowsFormsProductos1
{
    public partial class FormProductos : Form
    {
        // creacion de listas para celulares

        DataTable dtCelulares = new DataTable() { TableName = "celulares" };

        // Errores

        const string ERROR_CODIGO = "Codigo repetido";
        const string ERROR_CAMPOS = "Llene los campos";
        const string ERROR_COMAS = "Solo una ,(coma) por campo";
        const string ERROR_BORRADO = "Celular no seleccionado";

        // Direccion de archivo xml

        string path = "";

        public FormProductos()
        {
            InitializeComponent();

            dtCelulares.Columns.Add("Codigo");
            dtCelulares.Columns.Add("Alto");
            dtCelulares.Columns.Add("Ancho");
            dtCelulares.Columns.Add("Numero");
            dtCelulares.Columns.Add("Modelo");
            dtCelulares.Columns.Add("Usado");
            dtCelulares.Columns.Add("Recibido");

            // Carga de datos al dgv

            dgvCelulares.DataSource = dtCelulares;

            // Crea archivo XML en carpeta por defecto si es que no existe

            var dir = Path.Combine(Environment
           .GetFolderPath(Environment.SpecialFolder.ApplicationData), "Celulares");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            path = Path.Combine(dir, "Celulares.xml");

            LeerDatos();
        }

        // Carga los datos al grid

        private void cargarBtn_Click(object sender, EventArgs e)
        {
            epvError.Clear();
            if (ValidarComas(this.Controls))
            {
                MessageBox.Show(this, ERROR_COMAS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidarTabla(this.Controls))
            {
                Celular celular = new Celular();


                celular.Codigo = int.Parse(txtCodigo.Text);
                celular.Alto = decimal.Parse(txtAlto.Text);
                celular.Ancho = decimal.Parse(txtAncho.Text);
                celular.Modelo = txtModelo.Text;
                celular.Numero = Convert.ToInt32(txtNumero.Text);
                celular.Usado = rbtUsado.Checked;
                celular.Recibido = dtpRecibido.Value;

                // celular.Recibido = 

                dtCelulares.Rows.Add();
                int i = dtCelulares.Rows.Count - 1;

                dtCelulares.Rows[i]["Codigo"] = celular.Codigo;
                dtCelulares.Rows[i]["Alto"] = celular.Alto;
                dtCelulares.Rows[i]["Ancho"] = celular.Ancho;
                dtCelulares.Rows[i]["Numero"] = celular.Numero;
                dtCelulares.Rows[i]["Modelo"] = celular.Modelo;
                dtCelulares.Rows[i]["usado"] = celular.Usado;
                dtCelulares.Rows[i]["Recibido"] = celular.Recibido;

                GuardarDatos();
                limpiarPantalla();
            }
            
        }

        // Valida que los txt solo admitan numeros, comas y se pueda borrar.

        private void altoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar) && (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
        }

        // Valida que no haya mas de una coma en los txt

        private bool ValidarComas(Control.ControlCollection ctrlCollection)
        {
            char myChar = ',';
            int i = 0;
            bool comas = false;

            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (!comas)
                    {
                        foreach (char c in ctrl.Text)
                        {
                            if (c == myChar)
                            {
                                i++;
                                if (i > 1)
                                {
                                    comas = true;
                                    break;
                                }

                            }
                        }
                        i = 0;

                    }
                }

            }

            return comas;
        }

        // Carga los datos del XML

        private void LeerDatos()
        {
            if (System.IO.File.Exists(path))
            {
                dtCelulares.ReadXml(path);
            }
        }

        // Limpia los datos de los txt
        public void limpiarPantalla()
        {
            txtCodigo.Text = "";
            txtAlto.Text = "";
            txtAncho.Text = "";
            txtModelo.Text = "";
            txtNumero.Text = "";
            dtpRecibido.ResetText();
            rbtUsado.Checked = false;
        }

        //Valida los datos

        private bool ValidarTabla(Control.ControlCollection ctrlCollection)
        {
            bool bandera = false;

            // Validar campos vacios para datagrid

            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (!ctrl.Text.Any())
                    {
                        bandera = true;

                        MessageBox.Show(this, ERROR_CAMPOS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                    };
                }
            }

            // Validar que no se repita el nombre para datagrid

            for (int i = 0; i < dtCelulares.Rows.Count; i++)
            {
                if (dtCelulares.Rows[i]["Codigo"].ToString() == txtCodigo.Text)
                {
                    bandera = true;
                    MessageBox.Show(this, ERROR_CODIGO, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            return bandera;
        }

        // Guarda los datos en el XML
        private void GuardarDatos()
        {
            dtCelulares.WriteXml(path);
        }

        // Borra la fila seleccionada
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (dgvCelulares.CurrentRow == null)
            {
                MessageBox.Show(ERROR_BORRADO);
            }
            else
            {
                int i = dgvCelulares.CurrentRow.Index;

                dtCelulares.Rows.RemoveAt(i);
            }
            GuardarDatos(); 
        }
    }



    
}
