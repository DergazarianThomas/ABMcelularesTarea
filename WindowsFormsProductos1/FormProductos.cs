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
using CapaNegocios;


namespace WindowsFormsProductos1
{
    public partial class FormProductos : Form
    {
        #region codigo antiguo
        //// creacion de listas para celulares

        //DataTable dtCelulares = new DataTable() { TableName = "celulares" };

        //// Errores

        const string ERROR_CODIGO = "Codigo repetido";
        const string ERROR_CAMPOS = "Llene los campos";
        const string ERROR_COMAS = "Solo una ,(coma) por campo";
        const string ERROR_BORRADO = "Celular no seleccionado";

        //// Direccion de archivo xml

        //string path = "";
        #endregion

        Celular NuevoCel;
        Celular CelExistente;
        NegCelulares ObjNegCelular = new NegCelulares();
        bool nuevo = true;
        int fila;

        public FormProductos()
        {
            InitializeComponent();
            CrearDGV();
            LlenarDGV();

            #region codigo antiguo
           // InitializeComponent();

           // dtCelulares.Columns.Add("Codigo");
           // dtCelulares.Columns.Add("Alto");
           // dtCelulares.Columns.Add("Ancho");
           // dtCelulares.Columns.Add("Numero");
           // dtCelulares.Columns.Add("Modelo");
           // dtCelulares.Columns.Add("Usado");
           // dtCelulares.Columns.Add("Recibido");
            
           // // Carga de datos al dgv

           // dgvCelulares.DataSource = dtCelulares;

           // // Crea archivo XML en carpeta por defecto si es que no existe

           // var dir = Path.Combine(Environment
           //.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Celulares");
           // if (!Directory.Exists(dir))
           //     Directory.CreateDirectory(dir);
           // path = Path.Combine(dir, "Celulares.xml");

           // LeerDatos();
            #endregion
        }

        private void LlenarDGV()
        {
            dgvCelulares.Rows.Clear();
            DataSet ds = new DataSet();
            ds = ObjNegCelular.listadoCelulares("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCelulares.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4], dr[5].ToString(), dr[6].ToString());
                }
            }
            else
                MessageBox.Show("No hay celulares cargados en el sistema");
        }

        private void CrearDGV()
        {
            dgvCelulares.Columns.Add("0", "Codigo");
            dgvCelulares.Columns.Add("1", "Alto");
            dgvCelulares.Columns.Add("2", "Ancho");
            dgvCelulares.Columns.Add("3", "Numero");
            dgvCelulares.Columns.Add("4", "Modelo");
            dgvCelulares.Columns.Add("5", "Usado");
            dgvCelulares.Columns.Add("6", "Recibido");

            dgvCelulares.Columns[0].Width = 100;
            dgvCelulares.Columns[1].Width = 60;
            dgvCelulares.Columns[2].Width = 60;
            dgvCelulares.Columns[3].Width = 100;
            dgvCelulares.Columns[4].Width = 100;
            dgvCelulares.Columns[5].Width = 50;
            dgvCelulares.Columns[6].Width = 100;
        }
        // Carga los datos al grid
        private void cargarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarComas(this.Controls))
            {
                MessageBox.Show(this, ERROR_COMAS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidarTabla(this.Controls))
            {
                #region antiguo codigo
                //Celular celular = new Celular();


                //celular.Codigo = int.Parse(txtCodigo.Text);
                //celular.Alto = decimal.Parse(txtAlto.Text);
                //celular.Ancho = decimal.Parse(txtAncho.Text);
                //celular.Modelo = txtModelo.Text;
                //celular.Numero = Convert.ToInt32(txtNumero.Text);
                //celular.Usado = rbtUsado.Checked;
                //celular.Recibido = dtpRecibido.Value;


                //// celular.recibido = 

                //dtcelulares.rows.add();
                //int i = dtcelulares.rows.count - 1;

                //dtcelulares.rows[i]["codigo"] = celular.codigo;
                //dtcelulares.rows[i]["alto"] = celular.alto;
                //dtcelulares.rows[i]["ancho"] = celular.ancho;
                //dtcelulares.rows[i]["numero"] = celular.numero;
                //dtcelulares.rows[i]["modelo"] = celular.modelo;
                //dtcelulares.rows[i]["usado"] = celular.usado;
                //dtcelulares.rows[i]["recibido"] = celular.recibido;

                //guardardatos();
                #endregion
                int nGrabados = -1;

                NuevoCel = new Celular(int.Parse(txtCodigo.Text), decimal.Parse(txtAlto.Text), decimal.Parse(txtAncho.Text), int.Parse(txtNumero.Text), txtModelo.Text, rbtUsado.Checked, dtpRecibido.Value);

                nGrabados = ObjNegCelular.abmCelulares("Alta", NuevoCel);

                if (nGrabados == -1)
                {
                    MessageBox.Show( "No se pudo Cargar Celular en el sistema");
                }
                else
                {
                    MessageBox.Show( "Se grabó con éxito el Celular.");
                    LlenarDGV();
                    limpiarPantalla();
                }
            }

        }
        // Valida que los txt solo admitan numeros, comas y se pueda borrar.
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            #region antiguo borrar
            //if (dgvCelulares.CurrentRow == null)
            //{
            //    MessageBox.Show(ERROR_BORRADO);
            //}
            //else
            //{
            //    int i = dgvCelulares.CurrentRow.Index;

            //    dtCelulares.Rows.RemoveAt(i);
            //}
            //GuardarDatos();
            #endregion
        }

        private void atributosTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar) && (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
        }
        // Valida el txt de codigo por separado para que no admita comas
        private void codTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
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
        //// Carga los datos del XML
        //private void LeerDatos()
        //{
        //    if (System.IO.File.Exists(path))
        //    {
        //        dtCelulares.ReadXml(path);
        //    }
        //}
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
            char myChar = ',';

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
            #region antiguo codigo
            //// Validar que no se repita el nombre para datagrid

            //for (int i = 0; i < dtCelulares.Rows.Count; i++)
            //{
            //    if (dtCelulares.Rows[i]["Codigo"].ToString() == txtCodigo.Text)
            //    {
            //        bandera = true;
            //        MessageBox.Show(this, ERROR_CODIGO, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //    }
            //}
            #endregion
            return bandera;
        }
        // Guarda los datos en el XML
        //private void GuardarDatos()
        //{
        //    dtCelulares.WriteXml(path);
        //}
        // Borra la fila seleccionada




    }



}

