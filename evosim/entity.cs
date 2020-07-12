using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace evosim
{
    public static class Extensions
    {
        private static Random random = new Random();
        public static float Distance(this Vector2 a, Vector2 b)
        {
            double x = Math.Pow(a.X - b.X, 2);
            double y = Math.Pow(a.Y - b.Y, 2);
            return Convert.ToSingle(Math.Sqrt(x + y));
        }

        //.NextDouble is not truly uniform, but do we really care that much? no
        public static float NextFloat(this Random random, float min, float max)
        => (float)random.NextDouble() * (max - min) + min;

    }

    public class Entity
    {

        public Entity(float Speed, Vector2 pos, float start_units)
        {
            speed = Speed;
            position = pos;
            received = 0;
            satisfaction = random.Next(1, 4);
            units = start_units;
        }
        private static Random random = new Random();

        private float fitness = 0.0f; //from 0 to 1

        public Vector2 position = new Vector2(0.0f, 0.0f);

        private float speed = 0.0f; //from 0.1 to 5

        private float units = 0.0f; //generic units that can be likened to things such as food or energy that are necessary to survive (parameters defined in simulation)

        private int received = 0;
        private int satisfaction = 0;

        public void SetSatisfaction(int sat) => satisfaction = sat;

        public float GetFitness() => fitness;
        public float GetSpeed() => speed;
        public float GetUnits() => units;
        public void AddUnits(float un) => units += un;
        public void SubtractUnits(float un) => units -= un;

        public void Received() => received++;
        public bool Satisfied() => received >= satisfaction;

        public bool CanTravelThatFar(Vector2 dest) => position.Distance(dest) < (units * speed);
        public Vector2 ClosestPoint(List<Vector2> units)
        {
            float closest = 999.0f;
            int index = 0;
            for (int i = 0; i < units.Count; i++)
            {
                var distance = position.Distance(units[i]);
                if (distance < closest)
                {
                    closest = distance;
                    index = i;
                }
            }
            return units[index];
        }
        public Vector2 MoveTowards(Vector2 destination, float moveCost) //assumes the fact that you have enough units to move is checked.
        {
            if (units < 0)
                return position;

            var dist = position.Distance(destination);
            if (dist < speed) //we are practically there already
                return destination;
            bool negX = destination.X < position.X;
            bool negY = destination.Y < position.Y;

            //basically so we dont add our speed unfairly when moving in both XY but instead by weight.
            float weightX = Convert.ToSingle(Math.Abs(position.X - destination.X) / dist);
            float weightY = Convert.ToSingle(Math.Abs(position.Y - destination.Y) / dist);

            position.X += negX ? (-speed * weightX) : (+speed * weightX);
            position.Y += negY ? (-speed * weightY) : (+speed * weightY);

            units -= random.NextFloat(0.1f, Math.Max(0.11f, speed)) * moveCost; 

            if (position.Distance(destination) < speed) //just snap us there
                position = destination;
            return position;

        }



        //WARNING: I have no clue what im doing
        public float CalculateFitness(float unitMean)
        {
            fitness = 1.0f - 0.5f * (units / unitMean); //my own made up random fitness function for this
            return fitness;
        }

        //WARNING: I have no clue what im doing
        public void Mutate()
        {
            speed += random.NextFloat(-1.0f, 1.0f);
            if (speed < 0.01f)
                speed = 0.01f;
            else if (speed > 100.0f) //let mutation actually go really fast or slow so we can adapt to p much anything
                speed = 15.0f;
        }

        public void MimicProperties(Entity other)
        {
            satisfaction = other.satisfaction;
            if (random.Next(0, 3) == 0) //25% chance we increase or decrease satisfaction by 1
            {
                satisfaction += random.Next(-1, 1);
                if (satisfaction < 1)
                    satisfaction = 1;
            }

            speed = other.speed;
        }
    }
}
