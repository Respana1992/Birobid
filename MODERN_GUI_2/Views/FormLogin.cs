using MODERN_GUI_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            using (BDAPOLOFEEntities db = new BDAPOLOFEEntities())
            {
                try
                {
                    this.cmb_empresa.DataSource = db.APEMPRESA.ToList();
                    this.cmb_empresa.ValueMember = "EMPRESA";
                    this.cmb_empresa.DisplayMember = "NOMBRE";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema Apolo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVENTAS_Click(object sender, EventArgs e)
        {
            using (BDAPOLOFEEntities db = new BDAPOLOFEEntities())
            {
                try
                {
                    string username = this.txtusuer.Text.Trim();
                    string password = this.txtclave.Text.Trim();
                    int empresa =Convert.ToInt32(this.cmb_empresa.SelectedValue);

                    var validacion = (from c in db.APOPERADOR
                                      where (c.CODIGO == username && c.CLAVE == password && c.EMPRESA == empresa)
                                      select c);

                    int resultado = validacion.Count();

                    if (resultado == 1)
                    {
                        FormMenu f = new FormMenu();
                        f.WindowState = FormWindowState.Maximized;
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos", "Sistema Apolo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema Apolo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
