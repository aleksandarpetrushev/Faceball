using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faceball
{
    public partial class Faceball : Form
    {
        Panel activePanel;      //ActivePanel promenliva koja ke ja sodrzi momentalnata scena, na pocetok main menu
		Scene scene;
        string FileName;
		public Game Game;
        public Faceball()
        {
            InitializeComponent();
            DoubleBuffered = true;
            activePanel = panelMainMenu;        
            activePanel.Visible = true;
            //Treba panel za vnesuvanje na WinScore
            //scene = new Scene();
            FileName = null;
			
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
      //Se menja scenata na igra, ama ima nekoj problem i ne se menja panelot, 
            activePanel.Visible = true;         //prviot go snemuva, a toj sto treba da dojde - gamePanel go nema
            this.BackgroundImage = Properties.Resources.gameBg;
			
			this.Close();
			Game = new Game();
			Game.Show();
		}

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
			//Da se stavi slikata za pozadina
			//this.BackgroundImage = Properties.Resources.FootbalField;
        }

        //nemozam da otvoram designer view

        //timer za UpdateScene();

        //KeyDown event za mrdanje na playerot

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Faceball document (*.fcb)|*.fcb";
                saveFileDialog.Title = "Save Faceball file";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, scene);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Faceball document (*.fcb)|*.fcb";
            openFileDialog.Title = "Open Faceball file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        scene = (Scene)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            openFile();
        }
    }
}
