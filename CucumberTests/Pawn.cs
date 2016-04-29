using System;

namespace CucumberTests
{
    public class Pawn
    {
        private string color;
        private bool isCapd = false;

        public Pawn(string color)
        {
            this.color = color;
        }

        internal bool isCaptured()
        {
            return isCapd;
        }

        internal void capture()
        {
            isCapd = true;
        }
    }
}