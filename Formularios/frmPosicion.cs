using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;  // libreria para acceder a SQL
using System.IO;
namespace PARCIALDOS
{
    public partial class frmPosicion : Form
    
    {
        String a;
        String b;
        String c;
        String d;
        public frmPosicion()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            // cambiamos la posicion en la que aparece en pantalla el formulario
            // lo colocara en el centro de la pantalla
        }

        private void frmPosicion_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.Text = " ITLA - Maestro de posicion";
            Estilodgv();

            // buscara la data y llena el datagridview
            LlenarDataGridView();
        }

        // -------------------------------------------------------------
        // eventos de los textbox 
        // -------------------------------------------------------------
        private void txtPosicion_KeyDown(object sender, KeyEventArgs e)
        {
            // pregunto que la tecla presionada es igual la tecla de funciones
            // F4 entonces ejecuta el codigo
            if (e.KeyCode == Keys.F4)
            {
                btnPosicion.PerformClick();  
                // va a ejecutar el contenido del event click del boton btnPosicion
            }
        }

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si la tecla que presionaste es igual al valor de 13 entonces realiza lo siguiente
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtPosicion.Text.Trim() != string.Empty)  // aqui estoy preguntado que si es diferente de vacio
                {
                    if (!(char.IsNumber(e.KeyChar)))  // pregunto que lo digitado es solamente numeros
                    {
                        txtNombrePosicion.Focus();
                    }
                    else    // si lo que digitaste es letra entonces presentara la caja de mensajes
                    {
                        MessageBox.Show("Digite solo numeros", "ITLA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        private void txtPosicion_Leave(object sender, EventArgs e)
        {
            if (txtPosicion.Text.Trim() != string.Empty)  // aqui estoy preguntado que si es diferente de vacio
            {
                Int64 h = Convert.ToInt64(txtPosicion.Text);  // convierto a numeros enteros el valor del textbox 
                txtPosicion.Text = h.ToString("D3");          // Aqui estoy formateando a 3 posiciones los numeros digitados

                // busca en la clase Busco en el metodo Posiciones,
                // se le envia el valor contenido en txtPosicion como parametro al metodo posiciones
                txtNombrePosicion.Text = Busco.Posiciones(Convert.ToString(txtPosicion.Text));


                BuscarDatos();
            }
        }

        private void txtNombrePosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtNombrePosicion.Text.Trim() != string.Empty)  // aqui estoy preguntado que si es diferente de vacio
                {
                    txtDepartamento.Focus();
                }
            }
        }


        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si la tecla que presionaste es igual al valor de 13 entonces realiza lo siguiente
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtDepartamento.Text.Trim() != string.Empty)  // aqui estoy preguntado que si es diferente de vacio
                {
                    if (!(char.IsNumber(e.KeyChar)))  // pregunto que lo digitado es solamente numeros
                    {
                        btnInsertar.Focus();
                    }
                    else    // si lo que digitaste es letra entonces presentara la caja de mensajes
                    {
                        MessageBox.Show("Digite solo numeros", "ITLA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        private void txtDepartamento_Leave(object sender, EventArgs e)
        {
            if (txtDepartamento.Text.Trim() != string.Empty)  // aqui estoy preguntado que si es diferente de vacio
            {
               // if (!(char.IsNumber(e.toString()))  // pregunto que lo digitado es solamente numeros
               // {
                    Int64 h = Convert.ToInt64(txtDepartamento.Text);  // convierto a numeros enteros el valor del textbox 
                    txtDepartamento.Text = h.ToString("D3");          // Aqui estoy formateando a 3 posiciones los numeros digitados

                    // busca en la clase Busco en el metodo Posiciones, se le envia el valor contenido en txtPosicion
                    // como parametro al metodo posiciones
                    lblDepartamento.Text = Busco.Departamento(Convert.ToString(txtDepartamento.Text));
                //}
            }
        }

        private void txtDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            // pregunto que la tecla presionada es igual la tecla de funciones
            // F4 entonces ejecuta el codigo
            if (e.KeyCode == Keys.F4)
            {
                btnDepartamento.PerformClick();  // va a ejecutar el contenido del event click del boton btnPosicion
            }
        }

        // -------------------------------------------------------------
        // eventos de los botones
        // -------------------------------------------------------------
        private void btnPosicion_Click(object sender, EventArgs e)
        {
            frmVENPOS frm = new frmVENPOS();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtPosicion.Text = frm.varf1;
                txtNombrePosicion.Text = frm.varf2;
            }
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            frmVENDEPTO frm = new frmVENDEPTO();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtDepartamento.Text = frm.varf1;
                lblDepartamento.Text = frm.varf2;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();  // cierra el formulario
        }

        // -------------------------------------------------------------
        // metodos
        // -------------------------------------------------------------

        private void GuardarLinea()
        {
            // -------------------------------------------------------------------
            // este metodo es para guardar la data de la tabla
            // -------------------------------------------------------------------
            SqlConnection cnGuardar = new SqlConnection(cnn.db);
            cnGuardar.Open();

            string stQuery = "INSERT INTO POSICIONES (ID_POSICIONES, NOMBREPOSICION, ID_DEPARTAMENTOS) VALUES ( @A0, @A1, @A2);";

            SqlCommand miqueri = new SqlCommand(stQuery, cnGuardar);
            miqueri.Parameters.AddWithValue("@A0", Convert.ToString(txtPosicion.Text));
            miqueri.Parameters.AddWithValue("@A1", Convert.ToString(txtNombrePosicion.Text));
            miqueri.Parameters.AddWithValue("@A2", Convert.ToString(txtDepartamento.Text));

            miqueri.ExecuteNonQuery();
            cnGuardar.Close();
        }

        private void LimpiarFormulario()
        {
            txtPosicion.Clear();
            txtNombrePosicion.Clear();
            txtDepartamento.Clear();
            lblDepartamento.Text = "";
        }

        private void BorrarDatos(string numPos)
        {
            // -------------------------------------------------------------------
            // este metodo es para borrar la data de la tabla
            // -------------------------------------------------------------------
            SqlConnection cndel = new SqlConnection(cnn.db);
            cndel.Open();

            SqlCommand borrar = new SqlCommand("DELETE FROM POSICIONES WHERE ID_POSICIONES = @PV", cndel);
            borrar.Parameters.AddWithValue("@PV", numPos);
            borrar.ExecuteNonQuery();

            cndel.Close();
        }

        private void LlenarDataGridView()
        {
            SqlConnection cnread = new SqlConnection(cnn.db);  // le indica el string conexion
            cnread.Open();  // abre la conexion a la base de datos

            SqlCommand cmd = new SqlCommand("      SELECT T1.ID_POSICIONES, " +
                                            "             T1.NOMBREPOSICION, " +
                                            "             T1.ID_DEPARTAMENTOS, " +
                                            "             T2.NOMBRE_DEPARTAMENTOS " +
                                            "        FROM POSICIONES    T1 " +
                                            "  LEFT  JOIN DEPARTAMENTOS T2 ON T1.ID_DEPARTAMENTOS = T2.ID_DEPARTAMENTOS " +
                                            "    ORDER BY T1.ID_POSICIONES ASC", cnread);
            SqlDataReader records = cmd.ExecuteReader();  // ejecuta el script de la consulta

            //------------------------------------------------
            // COLOCAR AQUI LLENADO DE LA GRILLA
            // -----------------------------------------------

            try
            {
                while (records.Read())
                {  // no es fin de archivo true false
                    dgv.Rows.Add();    // aqui le suma 1 a la fila, es decir x = x + 1 
                    int xRows = dgv.Rows.Count - 1;   // aqui le resto 1 para me indique la fila correcta en donde estoy
                    dgv[0, xRows].Value = Convert.ToString(records["ID_DEPARTAMENTOS"]);     // escribe en la grilla, en la celda 0 y en la fila (x), el contenido del campo IDDEPARTAMENTO     de la tabla DEPARTAMENTO
                    dgv[1, xRows].Value = Convert.ToString(records["NOMBRE_DEPARTAMENTOS"]); // escribe en la grilla, en la celda 1 y en la fila (x), el contenido del campo NOMBREDEPARTAMENTO de la tabla DEPARTAMENTO
                }
            }
            catch
            {
                //
            }

            // -----------------------------------------------

            cmd.Dispose();
            cnread.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                using (TextWriter tw = new StreamWriter(@"C:\\exportar\\parcialptxt"))
                {
                    for (int i = 0; i < dgv.RowCount - 1; i++)
                    {
                        a = dgv.Rows[i].Cells[0].Value.ToString();
                        b = dgv.Rows[i].Cells[1].Value.ToString();
                        c = dgv.Rows[i].Cells[2].Value.ToString();
                        d = dgv.Rows[i].Cells[3].Value.ToString();
                        tw.WriteLine(a + b + c + d);
                    }
                    tw.WriteLine(a + b + c + d);
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // dgv es el nombre del DataGridView

            // -----------------------------------------------
            // Inserta el contenido de los TextBox a la grilla
            // -----------------------------------------------
            dgv.Rows.Add();     // agrega una linea al contador de la grilla
            int xRows = dgv.Rows.Count - 1;  // creo variable tipo entera para obtener por donde va el contador y le resto 1

            dgv[0, xRows].Value = txtPosicion.Text;       // estoy agregando en la columna 0 de la linea xRows el valor del textbox
            dgv[1, xRows].Value = txtNombrePosicion.Text;
            dgv[2, xRows].Value = txtDepartamento.Text;
            dgv[3, xRows].Value = lblDepartamento.Text;

            GuardarLinea(); // Metodo para guardar la data

            txtPosicion.Focus();  // Mueve el cursor hacia este textbox
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                LimpiarFormulario();

                txtPosicion.Text = dgv.CurrentRow.Cells[0].Value.ToString();  // le estoy asignando el valor de la columna y linea que acabas de dar clic
                txtNombrePosicion.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txtDepartamento.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                lblDepartamento.Text = dgv.CurrentRow.Cells[3].Value.ToString();

                // -------------------------------------------------------------------
                // aqui despues de desplegar la data de la linea que le diste clic
                // debo borrarla de la grilla, pero no de la tabla de la base de datos
                // -------------------------------------------------------------------
                int CuantasLineaTiene = Convert.ToInt32(dgv.RowCount);  // obtengo la cantidad de linea que tiene el datagridview

                if (CuantasLineaTiene == 1)  // pregunto si es igual a 1
                {
                    dgv.Rows.RemoveAt(dgv.RowCount - 1); // si es igual a 1 borro con este metodo la unica linea
                }
                else
                {
                    dgv.Rows.Remove(dgv.CurrentRow); // borrado normal de linea del datagridview
                }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.PerformClick();
        }

        private void btnDeleteLinea_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)  // pregunta que si el contador de linea de datagridview es mayor a 0
            {
                int CuantasLineaTiene = Convert.ToInt32(dgv.RowCount);  // obtengo la cantidad de linea que tiene el datagridview

                if (CuantasLineaTiene == 1)  // pregunto si es igual a 1
                {
                    dgv.Rows.RemoveAt(dgv.RowCount - 1); // si es igual a 1 borro con este metodo la unica linea
                }
                else
                {
                    dgv.Rows.Remove(dgv.CurrentRow); // borrado normal de linea del datagridview
                }

                // -----------------------------------------------------------------------
                // las siguientes intrucciones es para borrar esta data de la tabla
                // -----------------------------------------------------------------------
                txtPosicion.Text = dgv.CurrentRow.Cells[0].Value.ToString();  // de la columna 0 y la linea que acaba de dar clic tomo ese valor
                BorrarDatos(Convert.ToString(txtPosicion.Text));              // ejecuta este metodo enviandole el valor contenido en el textbox
               
                LimpiarFormulario();
            }
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            this.dgv.Rows.Clear();  // limpia la grilla
            this.dgv.Refresh();     // vuelve y le coloca su Estilodgv
        }

        private void BuscarDatos()
        {
            SqlConnection cnread = new SqlConnection(cnn.db);
            cnread.Open();

            SqlCommand cmd = new SqlCommand("      SELECT T1.ID_POSICIONES, " +
                                            "             T1.NOMBREPOSICION, " +
                                            "             T1.ID_DEPARTAMENTOS, " +
                                            "             T2.NOMBRE_DEPARTAMENTOS " +
                                            "        FROM POSICIONES    T1 " +
                                            "  LEFT  JOIN DEPARTAMENTOS T2 ON T1.ID_DEPARTAMENTOS = T2.ID_DEPARTAMENTOS " +
                                            "       WHERE T1.ID_POSICIONES = @PV", cnread);

            cmd.Parameters.AddWithValue("@PV", Convert.ToString(txtPosicion.Text));
            SqlDataReader records = cmd.ExecuteReader();

            if (records.Read())
            {
                txtNombrePosicion.Text = Convert.ToString(records["NOMBREPOSICION"]);
                txtDepartamento.Text = Convert.ToString(records["ID_DEPARTAMENTOS"]);
                lblDepartamento.Text = Convert.ToString(records["NOMBRE_DEPARTAMENTOS"]);
            }

            cmd.Dispose();
            cnread.Close();
        }

        private void Estilodgv()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "ID Posicion");
            this.dgv.Columns.Add("Col01", "Nombre de Posicion");
            this.dgv.Columns.Add("Col02", "Id Depto");
            this.dgv.Columns.Add("Col03", "Nombre Depto");


            DataGridViewColumn
            column = dgv.Columns[0]; column.Width = 100;
            column = dgv.Columns[1]; column.Width = 240;
            column = dgv.Columns[2]; column.Width = 100;
            column = dgv.Columns[3]; column.Width = 220;


            this.dgv.BorderStyle = BorderStyle.FixedSingle;
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgv.BackgroundColor = Color.White;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


    }
}
