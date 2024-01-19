using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr5
{
    public class Predator : Creature
    {
        public Predator(int X, int Y, ref RichTextBox textBox) : base(X, Y, ref textBox) { }
        public override void Eat(ref List<Creature> creatures)
        {
            if (eatHerbIndex > -1)
            {
                creatures.RemoveAt(eatHerbIndex);
                eatHerbIndex = -1;
                health += 80;
                MakeNewCreature(ref creatures);
                return;
            }
            Move();
        }
        protected override void MakeNewCreature(ref List<Creature> creatures)
        {
            Random rnd = new Random();
            int childX = Location.X + rnd.Next(-2, 2);
            int chlidY = Location.Y + rnd.Next(-2, 2);
            if (health >= 20)
            {
                health = -10;
                Predator child = new Predator(childX, chlidY, ref outputTextBox);
                for (int i = 0; i < neurons.Count; i++)
                {
                    double[] mutatedWeights = neurons[i].Weights;
                    for (int j = 0; j < mutatedWeights.Length; j++)
                    {
                        mutatedWeights[j] += (rnd.NextDouble() * 2 - 1) / 2.0;
                    }
                    child.neurons[i].Weights = mutatedWeights;
                }

                outputTextBox.Text += $"\n{creatures.IndexOf(this)} Хищник +1";
                creatures.Add(child);
            }
        }
        public override Pen GetCreaturePen() => new Pen(Color.Red);

    }
}
