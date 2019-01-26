using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Mapa
    {
        private Vector firstDot;
        private Vector secondDot;
        private Vector thirdDot;
        private BuildingObject[] objects;

        public Vector FirstDot
        {
            get
            {
                return firstDot;
            }
            set
            {
                firstDot = value;
            }
        }
        public Vector SecondDot
        {
            get
            {
                return secondDot;
            }
            set
            {
                secondDot = value;
            }
        }
        public Vector ThirdDot
        {
            get
            {
                return thirdDot;
            }
            set
            {
                thirdDot = value;
            }
        }

        public BuildingObject[] Objects
        {
            get
            {
                return objects;
            }
            set
            {
                objects = value;
            }
        }

        public void placeObject()
        {

        }
    }
}
