using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Planets
    {
        private string name;
        private float mass;
        private int diameter;
        private int density;
        private float gravity;
        private float rotationPeriod;
        private float lengthOfDays;
        private float distanceFromSun;
        private float orbitalPeriod;
        private float orbitalVelocity;
        private int meanTeaperature;
        private byte numbersOfMoons;
        private bool ringSystem;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public float Mass
        {
            get { return this.mass; }
            set { this.mass = value; }
        }
        public int Diameter
        {
            get { return this.diameter; }
            set { this.diameter = value; }
        }
        public int Density
        {
            get { return this.density; }
            set { this.density = value; }
        }
        public float Gravity
        {
            get { return this.gravity; }
            set { this.gravity = value; }
        }
        public float RotationPeriod
        {
            get { return this.rotationPeriod; }
            set { this.rotationPeriod = value; }
        }
        public float LengthOfDays
        {
            get { return this.lengthOfDays; }
            set { this.lengthOfDays = value; }
        }
        public float DistanceFromSun
        {
            get { return this.distanceFromSun; }
            set { this.distanceFromSun = value; }
        }
        public float OrbitalPeriod
        {
            get { return this.orbitalPeriod; }
            set { this.orbitalPeriod = value; }
        }
        public float OrbitalVelocity
        {
            get { return this.orbitalVelocity; }
            set { this.orbitalVelocity = value; }
        }
        public int MeanTeaperature
        {
            get { return this.meanTeaperature; }
            set { this.meanTeaperature = value; }
        }
        public byte NumbersOfMoons
        {
            get { return this.numbersOfMoons; }
            set { this.numbersOfMoons = value; }
        }
        public bool RingSystem
        {
            get { return this.ringSystem; }
            set { this.ringSystem = value; }
        }




        public Planets()
        {

        }


        public Planets ( string name, float mass,
            int diameter, int density, 
            float gravity, float rotationPeriod, 
            float lengthOfDays, float distanceFromSun,
            float orbitalPeriod, float orbitalVelocity, 
            int meanTeaperature, byte numbersOfMoons, 
            bool ringSystem)

        {
            this.name = name;
            this.mass = mass;
            this.diameter = diameter;
            this.density = density;
            this.gravity = gravity;
            this.rotationPeriod = rotationPeriod;
            this.lengthOfDays = lengthOfDays;
            this.distanceFromSun = distanceFromSun;
            this.orbitalPeriod = orbitalPeriod;
            this.orbitalVelocity = orbitalVelocity;
            this.meanTeaperature = meanTeaperature;
            this.numbersOfMoons = numbersOfMoons;
            this.ringSystem = ringSystem;
        }



    }
}
