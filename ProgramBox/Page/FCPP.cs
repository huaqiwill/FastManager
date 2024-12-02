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

/**
C++环境管理工具

2024.5.12 添加功能 C语言环境管理、C++环境管理、CMake环境管理、MingW配置，MSBulid管理
2024.5.17 修改功能
**/

namespace ProgramBox.UI
{
    public partial class FCPP : UIForm
    {
        FMain mainFrm;
        public FCPP()
        {
            InitializeComponent();
        }

        private void CppEnvFrm_Load(object sender, EventArgs e)
        {
            mainFrm = (FMain)Application.OpenForms[0];
            Location = mainFrm.Location;
            Size = mainFrm.Size;
        }
    }
}
