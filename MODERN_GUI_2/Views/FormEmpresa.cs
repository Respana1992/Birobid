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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            BindEmpresa();
        }

        private void BindEmpresa()
        {
            using (BDAPOLOFEEntities db = new BDAPOLOFEEntities())
            {
                try
                {
                    var objempresa = db.APEMPRESA.FirstOrDefault();
                    this.txtEmpresa.Text = objempresa.NOMBRE;
                    this.txtDireccion.Text = objempresa.DIRECCION;
                    this.txtRuc.Text = objempresa.RUC;
                    this.txtTelefonos.Text = objempresa.TELEFONO;
                    this.txtCorreo.Text = objempresa.CORREOEMP;
                    this.txtResolucion.Text = objempresa.CODIGOCONTRIBUYENTE;
                    this.chkContribuyente.Checked = Convert.ToBoolean(objempresa.ESPECIAL);
                    this.txtRutaLogo.Text = objempresa.LOGOEMPRESA;
                    this.txtGerente.Text = objempresa.GERENTE;
                    this.txtTelefono.Text = objempresa.TELEFONOG;
                    this.txtCedula.Text = objempresa.RUCG;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema Apolo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
