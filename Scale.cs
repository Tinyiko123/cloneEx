using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Scale
    {
        double quantScale;
        public gsass gs = new gsass();

        public double QuantScale
        {
            get { return quantScale; }
            set { quantScale = value; }
        }

        public double byH()
        {
            int amt = gs.Quant;
            quantScale = amt * 0.5;
            return quantScale;
        }

        public int byTwo()
        {
            int amt2 = gs.Quant;
            quantScale =amt2 * 2;
            return (int)quantScale;

        }

        public int byThree()
        {
            int amt = gs.Quant;
            quantScale =amt * 3;
            return (int)quantScale;
        }


    }
}
