using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace evosim
{
    public class Generation
    {

        private Random random = new Random();
        private List<Entity> Entities = new List<Entity>();
        private List<Vector2> Units = new List<Vector2>();
        private SizeF Size = new SizeF();

        private float StartUnits = 0.0f;
        public void SetStartUnits(float units) => StartUnits = units;

        private float UnitReward = 0.0f;
        public void SetUnitReward(float units) => UnitReward = units;

        private float IdleUsage = 0.0f;
        public void SetIdleUsage(float units) => IdleUsage = units;

        private int UseUnits = 0;
        private int UseEntities = 0;

        private float MoveCostCoeff = 1.0f;
        public void SetMoveCost(float coeff) => MoveCostCoeff = coeff;

        private int MaxSatisfaction = 4;
        public void SetSatisfaction(int sat) => MaxSatisfaction = sat;

        private float MutationChance = 1.0f;
        public void SetMutationChance(float chance) => MutationChance = chance;

        public void Initiate(SizeF plane, int entities, int units)
        {
            UseUnits = units;
            UseEntities = entities;

            Entities.Clear();
            Units.Clear();
            Size = plane;
            for (int i = 0; i < UseEntities; i++)
            {
                var X = random.NextFloat(0.0f, Size.Width);
                var Y = random.NextFloat(0.0f, Size.Height);

                Vector2 pos = new Vector2(X, Y);

                switch (random.Next(0, 3))
                {
                    case 0: //left border
                        pos.X = 0.0f;
                        break;

                    case 1: //right border
                        pos.X = plane.Width - 5.0f; // 1 pixel
                        break;

                    case 2: //upper bound
                        pos.Y = 0.0f;
                        break;

                    case 4: //lower bound
                        pos.Y = plane.Height - 5.0f;
                        break;
                }
                Entity ent = new Entity(random.NextFloat(0.3f, 5.0f), pos, StartUnits);
                ent.SetSatisfaction(random.Next(1, MaxSatisfaction));
                Entities.Add(ent);
            }

            for (int i = 0; i < UseUnits; i++)
            { //dont allow units to be too close to entity spawns by scaling by 10%
                var X = random.NextFloat(Size.Width * 0.1f, Size.Width - Size.Width * 0.1f);
                var Y = random.NextFloat(Size.Height * 0.1f, Size.Height - Size.Height * 0.1f);
                Units.Add(new Vector2(X, Y));
            }
        }

        public bool Draw(Graphics g)
        {
            foreach (var ent in Entities)
            {
                if (ent.GetUnits() < 0)
                    g.FillRectangle(Brushes.Black, ent.position.X, ent.position.Y, 5, 5);
                else if (ent.Satisfied())
                    g.FillRectangle(Brushes.Yellow, ent.position.X, ent.position.Y, 5, 5);
                else
                    g.FillRectangle(Brushes.Green, ent.position.X, ent.position.Y, 5, 5);
            }


            foreach (var unit in Units)
                g.FillRectangle(Brushes.Red, unit.X, unit.Y, 5, 5);

            bool AllDone = true;
            foreach (var ent in Entities)
            {
                if (!ent.Satisfied() && ent.GetUnits() > 0)
                {
                    AllDone = false;
                    break;
                }
            }
            if (AllDone)
                return true;
            foreach (var ent in Entities)
            {
                if (ent.Satisfied())
                {
                    ent.SubtractUnits(IdleUsage);
                    continue;
                }
                if (Units.Count < 1)
                    return true;

                var closest = ent.ClosestPoint(Units);
                var moved = ent.MoveTowards(closest, MoveCostCoeff);
                if (closest == moved)
                {
                    Units.Remove(moved);
                    ent.AddUnits(UnitReward);
                    ent.position = moved;
                    ent.Received();
                    if (ent.Satisfied())
                        g.FillRectangle(Brushes.Yellow, ent.position.X, ent.position.Y, 5, 5);
                    else
                        g.FillRectangle(Brushes.Green, ent.position.X, ent.position.Y, 5, 5);
                }
            }
            return false;
        }

        public bool Evolve()
        {
            float MeanUnits = 0.0f;
            foreach (var entity in Entities)
                MeanUnits += entity.GetUnits();

            if (Entities.Count == 0) //division by zero
                return false;
            MeanUnits /= Entities.Count;

            Entities.Sort((e1, e2) => e2.CalculateFitness(MeanUnits).CompareTo(e1.CalculateFitness(MeanUnits)));
            Entities.RemoveRange(Entities.Count / 2, Entities.Count / 2); //just remove the worst ones lol
            Entities.RemoveAll((e) => e.GetFitness() <= 0.1f); //too low fitness

            if (Entities.Count <= 2) //not enough candidates
                return false;

            Units.Clear();

            var CopyEntities = Entities.ToList(); //ah linq
            Entities.Clear(); //clear our new entities to-use

            float calc = (float)CopyEntities.Count / (float)UseEntities; //Possibly save overheat

            for (int i = 0; i < UseEntities; i++)
            {
                var X = random.NextFloat(0.0f, Size.Width);
                var Y = random.NextFloat(0.0f, Size.Height);

                Vector2 pos = new Vector2(X, Y);

                switch (random.Next(0, 3))
                {
                    case 0: //left border
                        pos.X = 0.0f;
                        break;

                    case 1: //right border
                        pos.X = Size.Width - 5.0f; // 1 pixel
                        break;

                    case 2: //upper bound
                        pos.Y = 0.0f;
                        break;

                    case 4: //lower bound
                        pos.Y = Size.Height - 5.0f;
                        break;
                }
                Entity ent = new Entity(random.NextFloat(0.3f, 5.0f), pos, StartUnits);
                ent.MimicProperties(CopyEntities[(int)Math.Floor(i * calc)]);
                if (random.NextFloat(0.0f, 1.0f) <= MutationChance)
                    ent.Mutate();
                Entities.Add(ent);
            }

            for (int i = 0; i < UseUnits; i++) //dont allow units to be too close to entity spawns by scaling by 10%
            {
                var X = random.NextFloat(Size.Width * 0.1f, Size.Width - Size.Width * 0.1f);
                var Y = random.NextFloat(Size.Height * 0.1f, Size.Height - Size.Height * 0.1f);
                Units.Add(new Vector2(X, Y));
            }

            return true;
        }
    }
}
