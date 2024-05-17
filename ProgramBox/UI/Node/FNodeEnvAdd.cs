using Sunny.UI;
using System;

namespace ProgramBox.UI
{
    public partial class FNodeEnvAdd : UIForm
    {
        NodeEnvData nodeEnvData;

        public FNodeEnvAdd(NodeEnvData nodeEnvData = null)
        {
            InitializeComponent();
            this.nodeEnvData = nodeEnvData;
        }

        private void NodeConfig_Load(object sender, EventArgs e)
        {
            // 
            if (this.nodeEnvData != null)
            {
                Text = "Node SDK修改";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
