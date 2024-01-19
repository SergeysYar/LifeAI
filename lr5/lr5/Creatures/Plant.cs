using lr5.Creatures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr5
{
    public class Plant : Creature
    {
        public Plant(int X, int Y, ref RichTextBox textBox) : base(X, Y, ref textBox) { }
        public override Pen GetCreaturePen() => new Pen(Color.Green);
        public override void Move() { }
        public override void Eat(ref List<Creature> creatures) { }
        public override void Act(ref List<Creature> creatures) { }
        public override void Damage(ref List<Creature> creatures) { }

    }
}
