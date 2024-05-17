using SharpConfig;
using Sunny.UI;
using System;

namespace ProgramBox.UI
{
    public partial class FNodeEnv : UIForm
    {
        Configuration cfg;

        public FNodeEnv()
        {
            InitializeComponent();
        }

        private void FNodeEnv_Load(object sender, EventArgs e)
        {
            cfg = Configuration.LoadFromFile(App.ConfigPath);


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new FNodeEnvAdd().ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            new FNodeEnvAdd().ShowDialog();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
