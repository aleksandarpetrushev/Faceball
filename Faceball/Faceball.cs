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
        Panel activePanel;      //ActivePanel promenliva koja ke ja sodrzi momentalnata scena, na pocetok main menu
		Scene scene;
        public Faceball()
        {
            InitializeComponent();
            DoubleBuffered = true;
            activePanel = panelMainMenu;        
            activePanel.Visible = true;
			//Treba panel za vnesuvanje na WinScore
			//scene = new Scene();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = gamePanel;            //Se menja scenata na igra, ama ima nekoj problem i ne se menja panelot, 
            activePanel.Visible = true;         //prviot go snemuva, a toj sto treba da dojde - gamePanel go nema
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
			//Da se stavi slikata za pozadina
			//this.BackgroundImage = Properties.Resources.FootbalField;
        }

        
    }
}
