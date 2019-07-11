using MODERN_GUI_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2.Views
{
    public partial class FormEmpresa : Form
    {
        private int _codeEmpresa;
        private string ConexionExterna;

        public FormEmpresa(int code)
        {
            InitializeComponent();
            _codeEmpresa = code;
            ConexionExterna = "";
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
                    var objempresa = db.APEMPRESA.Where(x => x.EMPRESA == _codeEmpresa).FirstOrDefault();
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
                    this.chkClaveRegistrada.Checked = Convert.ToBoolean(objempresa.CLAVEREGISTRADA);
                    this.chkEditarScript.Checked = Convert.ToBoolean(objempresa.EDITASCRIP);
                    this.chkFactura.Checked = Convert.ToBoolean(objempresa.FACTURA);
                    this.chkNcr.Checked = Convert.ToBoolean(objempresa.NCR);
                    this.chkNdb.Checked = Convert.ToBoolean(objempresa.NDB);
                    this.chkGuia.Checked = Convert.ToBoolean(objempresa.GUIA);
                    this.chkRetencion.Checked = Convert.ToBoolean(objempresa.RETENCION);

                    var objcertificado = db.APCERTIFICADO.FirstOrDefault();
                    this.txtRutaArchivo.Text = objcertificado.RUTA;
                    this.txtClaveArchivo.Text = objcertificado.CLAVE;
                    this.dtpFechaEmision.Value = objcertificado.FECHAEMISION;
                    this.dtpFechaCaducidad.Value = objcertificado.FECHACADUCIDAD;
                    this.rbtArchivo.Checked = true;
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

        private void SaveEmpresa()
        {
            using (BDAPOLOFEEntities db = new BDAPOLOFEEntities())
            {
                using (DbContextTransaction trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        APEMPRESA model = db.APEMPRESA.Where(x => x.EMPRESA == _codeEmpresa).FirstOrDefault();
                        model.NOMBRE = this.txtEmpresa.Text.Trim();
                        model.DIRECCION = this.txtDireccion.Text.Trim();
                        model.RUC = this.txtRuc.Text.Trim();
                        model.TELEFONO = this.txtTelefonos.Text.Trim();
                        model.CORREOEMP = this.txtCorreo.Text.Trim();
                        model.CODIGOCONTRIBUYENTE = this.txtResolucion.Text.Trim();
                        model.ESPECIAL = this.chkContribuyente.Checked;
                        model.LOGOEMPRESA = this.txtRutaLogo.Text.Trim();
                        model.GERENTE = this.txtGerente.Text.Trim();
                        model.TELEFONOG = this.txtTelefono.Text.Trim();
                        model.RUCG = this.txtCedula.Text.Trim();
                        model.OBSERVACION = this.txtObservacion.Text;
                        model.DIRECCIONFTP = this.txtUrl.Text.Trim();
                        model.USUARIOFTP = this.txtUsuarioFtp.Text.Trim();
                        model.CLAVEFTP = this.txtClaveFtp.Text.Trim();
                        if (this.chkFTP.Checked)
                        {
                            model.ENVIAWEB = "S";
                        }
                        else
                        {
                            model.ENVIAWEB = "N";
                        }
                        model.CLAVEREGISTRADA = this.chkClaveRegistrada.Checked;
                        model.EDITASCRIP = this.chkEditarScript.Checked;
                        model.USUARIOE = this.txtUsuarioOdbc.Text.Trim();
                        model.CLAVEE = this.txtClaveOdbc.Text.Trim();
                        model.ODBCE = this.txtOdbc.Text.Trim();

                        APCERTIFICADO certificado = db.APCERTIFICADO.Where(x => x.EMPRESA == _codeEmpresa).FirstOrDefault();
                        certificado.RUTA = this.txtRutaArchivo.Text;
                        certificado.CLAVE = this.txtClaveArchivo.Text.Trim();
                        certificado.FECHAEMISION = this.dtpFechaEmision.Value;
                        certificado.FECHACADUCIDAD = this.dtpFechaCaducidad.Value;

                        db.APCERTIFICADO.Attach(certificado);
                        db.Entry(certificado).State = EntityState.Modified;

                        db.APEMPRESA.Attach(model);
                        db.Entry(model).State = EntityState.Modified;
                        db.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show(ex.Message, "Sistema Apolo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEmpresa();
        }

        private void TestConexion()
        {
            string ruta = Path.Combine(Application.StartupPath, "\\ARCHIVO.txt");
            StreamReader sr = File.OpenText(ruta);
            while (sr.Peek() != -1)
            {
                string server = sr.ReadLine();
                string user = sr.ReadLine();
                string password = sr.ReadLine();
                
                if (server == this.txtOdbc.Text.Trim() && user == this.txtUsuarioOdbc.Text.Trim() && password == this.txtClaveOdbc.Text.Trim())
                {
                    ConexionExterna = sr.ReadLine();
                    MessageBox.Show("Conexion establecida con exito", "Sistema Apolo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestConexion();
        }
    }
}
