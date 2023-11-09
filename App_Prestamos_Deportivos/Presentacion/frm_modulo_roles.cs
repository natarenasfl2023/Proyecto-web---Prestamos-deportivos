using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_modulo_roles : Form
    {
        public frm_modulo_roles()
        {
            InitializeComponent();
        }

        private void frm_modulo_roles_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_id.Focus();
            txt_id.Clear();
            txt_nomenclatura.Clear();
            txt_descripcion.Clear();
        }
    }
}
