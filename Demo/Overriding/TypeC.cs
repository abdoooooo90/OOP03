using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeC : TypeB
    {
        #region prop
        //public int C { get; set; }
        #endregion

        #region ctor
        //public TypeC(int _A, int _B, int _C) : base(_A, _B)
        //{
        //    C = _C;

        //}
        #endregion

        #region Method
        //public new void MyFun01()
        //{
        //    Console.WriteLine("Iam Dervied [GrandChild]");
        //}
        //public virtual void MyFun02()
        //{
        //    Console.WriteLine($"TypeB : A {A},B:{B},C ={C} ");
        //}
        #endregion
    }
}
