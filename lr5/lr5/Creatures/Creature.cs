using lr5.Creatures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lr5
{
    public class Creature
    {
        protected List<Neuron> neurons = new List<Neuron>();
        protected Perception perception;
        public int health { get; protected set; }
        protected int eatHerbIndex;
        protected int eatPlantIndex;
        protected Direction direction;
        public Point Location { get; set; }
        protected RichTextBox outputTextBox;
        public Creature(int X, int Y, ref RichTextBox textBox) 
        {
            perception = new Perception();
            outputTextBox = textBox;
            direction = Direction.North;
            Location = new Point(X, Y);
            for (int i = 0; i < 4; i++)
            {
                neurons.Add(new Neuron());
            }
            health = 50;
            perception.UpdatePerceptionFacingNorth(Location);
        }
        public virtual void Damage(ref List<Creature> creatures)
        {
            if (--health <= 0) creatures.Remove(this);
        }
        public virtual Pen GetCreaturePen() => new Pen(Color.White);
        private bool[] GetNeuronOutput()
        {
            bool[] output = new bool[4];

            double[] potencials = neurons.Select(x => x.CalculatePotential()).ToArray();
            output[Array.LastIndexOf(potencials, potencials.Max())] = true;

            return output;
        }
        public void ScanNearbyWorld(ref List<Creature> creatures)
        {
            int[] neuronInputArray = new int[12];
            eatHerbIndex = -1;
            eatPlantIndex = -1;
            for (int i = 0; i < creatures.Count; i++)
            {
                var creature = creatures[i];
                foreach (Point frontPoint in perception.frontPerception)
                {
                    if (creature.Location == frontPoint)
                    {
                        if (creature.GetType() == typeof(Herbivore))
                        {
                            neuronInputArray[0] = 1;
                        }
                        else if (creature.GetType() == typeof(Predator))
                        {
                            neuronInputArray[1] = 1;
                        }
                        else
                        {
                            neuronInputArray[2] = 1;
                        }
                    }
                }
                foreach (Point leftPoint in perception.leftPerception)
                {
                    if (creature.Location == leftPoint)
                    {
                        if (creature.GetType() == typeof(Herbivore))
                        {
                            neuronInputArray[3] = 1;
                        }
                        else if (creature.GetType() == typeof(Predator))
                        {
                            neuronInputArray[4] = 1;
                        }
                        else
                        {
                            neuronInputArray[5] = 1;
                        }
                    }
                }
                foreach (Point rightPoint in perception.rightPerception)
                {
                    if (creature.Location == rightPoint)
                    {
                        if (creature.GetType() == typeof(Herbivore))
                        {
                            neuronInputArray[6] = 1;
                        }
                        else if (creature.GetType() == typeof(Predator))
                        {
                            neuronInputArray[7] = 1;
                        }
                        else
                        {
                            neuronInputArray[8] = 1;
                        }
                    }
                }
                foreach (Point nearPoint in perception.nearPerception)
                {
                    if (creature.Location == nearPoint)
                    {
                        if (creature.GetType() == typeof(Herbivore))
                        {
                            neuronInputArray[9] = 1;
                            eatHerbIndex = i;
                        }
                        else if (creature.GetType() == typeof(Predator))
                        {
                            neuronInputArray[10] = 1;
                        }
                        else
                        {
                            neuronInputArray[11] = 1;
                            eatPlantIndex = i;
                        }
                    }
                }
            }
            foreach(Neuron n in neurons)
            {
                n.Input = neuronInputArray;
            }
        }
        public virtual void Act(ref List<Creature> creatures)
        {
            bool[] neuronOutput = GetNeuronOutput();
            for (int i = 0; i < neuronOutput.Length; i++)
            {
                if (neuronOutput[i])
                {
                    switch (i)
                    {
                        case 0: TurnLeft(); return;
                        case 1: TurnRight(); return;
                        case 2: Move(); return;
                        case 3: Eat(ref creatures); return;
                    }
                }
            }
            Move();
        }
        public void TurnLeft()
        {
            switch (direction)
            {
                case Direction.North:
                    direction = Direction.West;
                    perception.UpdatePerceptionFacingWest(Location);
                    break;
                case Direction.West:
                    direction = Direction.South;
                    perception.UpdatePerceptionFacingSouth(Location);
                    break;
                case Direction.South:
                    direction = Direction.East;
                    perception.UpdatePerceptionFacingEast(Location);
                    break;
                case Direction.East:
                    direction = Direction.North;
                    perception.UpdatePerceptionFacingNorth(Location);
                    break;
            }
        }
        public void TurnRight()
        {
            switch (direction)
            {
                case Direction.North:
                    direction = Direction.East;
                    perception.UpdatePerceptionFacingEast(Location);
                    break;
                case Direction.West:
                    direction = Direction.North;
                    perception.UpdatePerceptionFacingNorth(Location);
                    break;
                case Direction.South:
                    direction = Direction.West;
                    perception.UpdatePerceptionFacingWest(Location);
                    break;
                case Direction.East:
                    direction = Direction.South;
                    perception.UpdatePerceptionFacingSouth(Location);
                    break;
            }
        }
        public virtual void Move()
        {
            switch (direction)
            { 
                case Direction.North:
                    int newCoordYNorth = Location.Y + 1;
                    if (newCoordYNorth > Utilities.WorldSizeY)
                        Location = new Point(Location.X, 0);
                    else Location = new Point(Location.X, newCoordYNorth);
                    perception.UpdatePerceptionFacingNorth(Location);
                    break;
                case Direction.West:
                    int newCoordXWest = Location.X - 1;
                    if (newCoordXWest < 0)
                        Location = new Point(Utilities.WorldSizeX, Location.Y);
                    else Location = new Point(newCoordXWest, Location.Y);
                    perception.UpdatePerceptionFacingWest(Location);
                    break;
                case Direction.South:
                    int newCoordYSouth = Location.Y - 1;
                    if (newCoordYSouth < 0)
                        Location = new Point(Location.X, Utilities.WorldSizeY);
                    else Location = new Point(Location.X, newCoordYSouth);
                    perception.UpdatePerceptionFacingSouth(Location);
                    break;
                case Direction.East:
                    int newCoordXEast = Location.X + 1;
                    if (newCoordXEast > Utilities.WorldSizeX)
                        Location = new Point(0, Location.Y);
                    else Location = new Point(newCoordXEast, Location.Y);
                    perception.UpdatePerceptionFacingEast(Location);
                    break;
            }
        }
        public virtual void Eat(ref List<Creature> creatures) { }
        protected virtual void MakeNewCreature(ref List<Creature> creatures) { }
    }
}
