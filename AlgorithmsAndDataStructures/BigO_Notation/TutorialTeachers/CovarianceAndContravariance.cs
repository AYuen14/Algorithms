using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    internal class CovarianceAndContravariance
    {
        Small smlcls1 = new Small();
        Small smlcls2 = new Big();
        Small smlcls3 = new Bigger();
        Big bigcls = new Bigger();
        //Big bigcls2 = new Small();

        public delegate Small covarianceDelegate(Big mc);

        public CovarianceAndContravariance()
        {
            covarianceDelegate del = Method1;
            del += Method2;
            del += Method3;
            del += Method4;

            Small sm = del(new Big());
        }

        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");

            return new Big();
        }

        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }

        static Small Method3(Small sml)
        {
            Console.WriteLine("Method3");

            return new Small();
        }

        static Big Method4(Small sml)
        {
            Console.WriteLine("Method4");

            return new Big();
        }
    }

    internal class Small
    {

    }

    internal class Big: Small
    {

    }

    internal class Bigger: Big
    {

    }

}
