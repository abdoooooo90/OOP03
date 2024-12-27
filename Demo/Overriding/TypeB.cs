using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeB : TypeA
    {
        #region prop
        //public int B { get; set; }
        #endregion

        #region ctor
        //public TypeB(int _A, int _B) : base(_A)
        //{
        //    B = _B;
        //}
        #endregion

        #region Method
        //public new void MyFun01() 
        //{
        //    Console.WriteLine("Iam Drevied [chiled] ");
        //}

        //public virtual void MyFun02()
        //{
        //    Console.WriteLine($"TypeB : A {A}\n B:{B}");
        //}
        #endregion
    }
}
