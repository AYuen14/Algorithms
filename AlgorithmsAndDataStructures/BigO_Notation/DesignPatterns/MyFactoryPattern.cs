using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.DesignPatterns
{
    internal interface IBusinessFactory
    {
        void GetRandomNumber();
    }

    internal class FirstConcreteClass : IBusinessFactory
    {
        public FirstConcreteClass()
        {

        }

        public void GetRandomNumber()
        {
        }
    }

    internal class SecondConcreteClass : IBusinessFactory
    {
        public SecondConcreteClass()
        {

        }

        public void GetRandomNumber()
        {
        }
    }
    internal static class MyFactoryPattern
    {
        public static IBusinessFactory Create()
        {
            bool isFirst = true;

            if(isFirst)
            {
                return new FirstConcreteClass();
            }
            else
            {
                return new SecondConcreteClass();
            }
            
        }
    }
}
