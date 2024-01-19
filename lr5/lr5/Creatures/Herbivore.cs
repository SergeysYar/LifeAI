using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace lr5
{
    public class Herbivore : Creature
    {
        public Herbivore(int X, int Y, ref RichTextBox textBox):base(X,Y, ref textBox) { }
        public override void Eat(ref List<Creature> creatures)
        {
            if (eatPlantIndex > -1)
            {
                creatures.RemoveAt(eatPlantIndex);
                eatPlantIndex = -1;
                health += 40;
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
                health -= 10;
                Herbivore child = new Herbivore(childX, chlidY, ref outputTextBox);
                for (int i = 0; i < neurons.Count; i++)
                {
                    double[] mutatedWeights = neurons[i].Weights;
                    for (int j = 0; j < mutatedWeights.Length; j++)
                    {
                        mutatedWeights[j] += (rnd.NextDouble() * 2 - 1) / 2.0;
                    }
                    child.neurons[i].Weights = mutatedWeights;
                }
                outputTextBox.Text += $"\n{creatures.IndexOf(this)} Травоядное +1";
                creatures.Add(child);
            }
        }
        public override Pen GetCreaturePen() => new Pen(Color.Blue);
    } 
}
