using FastStart;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramBox.UI
{
    public partial class FNginx : UIForm
    {
        FMain mainFrm;
        public FNginx()
        {
            InitializeComponent();
        }

        private void NginxEnvFrm_Load(object sender, EventArgs e)
        {
            mainFrm = (FMain)Application.OpenForms[0];
            Location = mainFrm.Location;
            Size = mainFrm.Size;
        }
    }
}
