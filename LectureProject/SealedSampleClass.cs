using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureProject
{
    internal sealed class SealedSampleClass
    {
        int num1;
        int num2;
    }

    //GENERATES ERROR

    //internal class ChildClass: SealedSampleClass
    //{
    //    public int num3;
    //}



}
