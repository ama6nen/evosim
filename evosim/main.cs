using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evosim
{
    public partial class main : Form
    {
        Generation generation = new Generation();
        Graphics graphics;
        public main()
        {
            Random rnd = new Random();
            InitializeComponent();
        }

        /*
         ideas:
         -natural selection
         -you have tangible objectives of getting food
         -speed is important
         -many different species
         -mutations which occur that change parameters
         -the faster you go, the more energy is used up (energy = food, to be simple)
         -you need X energy to survive
         */


        private void main_Load(object sender, EventArgs e)
        {
            graphics = Simulation.CreateGraphics();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GenTimer.Interval = (int)(100.0f * (1.0f / (float)SimSpeed.Value));
            graphics.Clear(Simulation.BackColor);
            generation.SetStartUnits((float)StartUnits.Value);
            generation.SetUnitReward((float)UnitsReward.Value);
            generation.SetIdleUsage((float)IdleUsage.Value);
            generation.SetMoveCost((float)MoveCost.Value);
            generation.SetSatisfaction((int)MaxSatisfaction.Value);
            generation.SetMutationChance((float)MutationChance.Value);
            generation.Initiate(new SizeF(Simulation.Size.Width, Simulation.Size.Height), (int)entities.Value, (int)units.Value);
            GenTimer.Start();        
        }

        private void GenTimer_Tick(object sender, EventArgs e)
        {

            if (generation.Draw(graphics))
            {
                Continue.Visible = true;
                graphics.DrawString("Finished.", this.Font, Brushes.Black, new PointF(10.0f, 10.0f));
                GenTimer.Stop();
            }
            
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Continue.Visible = false;
            if (!generation.Evolve())
                graphics.DrawString("No evolution possible, all units suck!", this.Font, Brushes.Red, new PointF(10.0f, 30.0f));
            else
            {
                graphics.Clear(Simulation.BackColor);
                GenTimer.Start();
            }
               
        }
    }
}
