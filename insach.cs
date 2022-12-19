using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class insach : Form
    {
        SqlConnection conn;
        public insach()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=THINKPADE14/MSSQLSERVER01;Initial Catalog=QLThuVien_BTL_NET1;Integrated Security=True;User Id=sa;Password=1");
        }

        private void insach_Load(object sender, EventArgs e)
        {

        }
    }
}
