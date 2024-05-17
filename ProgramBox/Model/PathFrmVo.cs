using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBox.UI
{
    public enum SelectPathType
    {
        Dir,
        File,
    }

    public class PathFrmVo
    {
        public string Name { get; set; }
        public SelectPathType PathType { get; set; }
        public string SelectPath { get; set; }
    }
}
