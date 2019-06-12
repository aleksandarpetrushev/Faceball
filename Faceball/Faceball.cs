using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faceball
{
    public partial class Faceball : Form
    {
        Panel activePanel;

        public Faceball()
        {
            InitializeComponent();
            activePanel = panelMainMenu;
            activePanel.Visible = true;
        }
    }
}
