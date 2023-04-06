using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4._2_Cs
{
    internal class Computadora : Electronico
    {
        private string os;
        private string processor;

        public string Os
        {
            get { return os; }
            set { os = value; }
        }

        public string Processor
        {
            get { return processor; }
            set { processor = value; }
        }

        public Computadora()
        {
            os = "";
            processor = "";
        }

        public Computadora(double Price, string Brand, string Model, string Os, string Processor)
        : base(Price, Brand, Model)
        {
            this.Processor = Processor;
            this.Os = Os;
        }
    }
}
