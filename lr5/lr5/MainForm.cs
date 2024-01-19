using lr5.Creatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr5
{
    public partial class MainForm : Form
    {
        Graphics g;
        List<Creature> creatures;

        public MainForm()
        {
            InitializeComponent();
            g = worldPictureBox.CreateGraphics();
            //int Plant =Convert.ToInt32(textBoxPlant.Text);
            //int HB = Convert.ToInt32(textBoxHB.Text);
            //int PD = Convert.ToInt32(textBoxPD.Text);
            //creatures = WorldInitialiser(Plant, HB, PD);
        }

        private void DrawWorld()
        {
            g.Clear(Color.Black);
            foreach (Creature creature in creatures)
            {
                Point creaturePoint = creature.Location;
                g.DrawEllipse(creature.GetCreaturePen(), creaturePoint.X, creaturePoint.Y, 3, 3);
            }
        }
        private void AddPlants(List<Creature> creatures, int numberPlants)
        {
            Random rnd = new Random();
            for (int i = 0; i < numberPlants; i++)
            {
                int x = rnd.Next(1, Utilities.WorldSizeX);
                int y = rnd.Next(1, Utilities.WorldSizeY);
                creatures.Add(new Plant(x, y, ref outRichTextBox));
            }
        }
        private List<Creature> WorldInitialiser(int plants, int herbivores, int predators)
        {
            Random rnd = new Random();
            List<Creature> creatureList = new List<Creature>();
            for (int i = 0; i < plants; i++)
            {
                int x = rnd.Next(1, Utilities.WorldSizeX);
                int y = rnd.Next(1, Utilities.WorldSizeY);
                creatureList.Add(new Plant(x,y, ref outRichTextBox));
            }
            for (int i = 0; i < herbivores; i++)
            {
                int x = rnd.Next(1, Utilities.WorldSizeX);
                int y = rnd.Next(1, Utilities.WorldSizeY);
                creatureList.Add(new Herbivore(x,y, ref outRichTextBox));
            }
            for (int i = 0; i < predators; i++)
            {
                int x = rnd.Next(1, Utilities.WorldSizeX);
                int y = rnd.Next(1, Utilities.WorldSizeY);
                creatureList.Add(new Predator(x,y, ref outRichTextBox));
            }
            return creatureList;
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            int Plant = Convert.ToInt32(textBoxPlant.Text);
            int HB = Convert.ToInt32(textBoxHB.Text);
            int PD = Convert.ToInt32(textBoxPD.Text);
            creatures = WorldInitialiser(Plant, HB, PD);
            g.Clear(Color.Black);
            DrawWorld();
            startButton.Enabled = false;
        }

        private void iterateOnceButton_Click(object sender, EventArgs e)
        {
            OneIteration();
        }

        private void OneIteration()
        {
            foreach (Creature creature in creatures)
            {
                creature.ScanNearbyWorld(ref creatures);
            }
            for (int i = creatures.Count - 1; i >= 0; i--)
            {
                creatures[i].Act(ref creatures);
                creatures[i].Damage(ref creatures);
            }
            DrawWorld();
            AddPlants(creatures, 2);
        }

        private void IterationFive_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBox1.Text);
            for(int i = 0; i < r; i++) OneIteration();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
