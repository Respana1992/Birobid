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
                    this.txtObservacion.Text = objempresa.OBSERVACION;
                    this.txtUrl.Text = objempresa.DIRECCIONFTP;
                    this.txtUsuarioFtp.Text = objempresa.USUARIOFTP;
                    this.txtClaveFtp.Text = objempresa.CLAVEFTP;
                    string envioweb = objempresa.ENVIAWEB;
                    if (envioweb.Trim().Equals("S"))
                    {
                        this.chkFTP.Checked = true;
                    }
                    else
                    {
                        this.chkFTP.Checked = false;
                    }
                    this.txtOdbc.Text = objempresa.ODBCE;
                    this.txtUsuarioOdbc.Text = objempresa.USUARIOE;
                    this.txtClaveOdbc.Text = objempresa.CLAVEE;
                    var objcertificado = db.APCERTIFICADO.FirstOrDefault();
                    this.txtRutaArchivo.Text = objcertificado.RUTA;
                    this.txtClaveArchivo.Text = objcertificado.CLAVE;
                    this.dtpFechaEmision.Value = objcertificado.FECHAEMISION;
                    this.dtpFechaCaducidad.Value = objcertificado.FECHACADUCIDAD;
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

        private void btnRutaLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "Formato de archivo (*.png)|*.png";
            OpenFileDialog1.ShowDialog();
            if (OpenFileDialog1.FileName != "")
            {
                this.txtRutaLogo.Text = OpenFileDialog1.FileName;
            }
        }

        private void btnRutaArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "Formato de archivo (*.p12)|*.p12";
            OpenFileDialog1.ShowDialog();
            if (OpenFileDialog1.FileName != "")
            {
                this.txtRutaArchivo.Text = OpenFileDialog1.FileName;
            }
        }
    }
}
