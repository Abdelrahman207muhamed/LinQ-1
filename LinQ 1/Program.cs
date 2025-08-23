using static LinQ_1.ListGenerator;
namespace LinQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicitly-Type Local Variable [Var- Dynamic ]

            #region Var
            // Var 

           // var Dat01 = "Ahmed";

            //Compiler Can Detect The DataType Of The Local Variable Based On Initial Value ,At Compination Time 
            //Must BE Initialized
            //Can't Initialized The Local Variable With Null
            //Can't Change DataType Of The Local After Initialization
            //Can;t Use Var as Parameter Or Return Type
            //Data01 = 12;//InValid 
            #endregion

            #region Dynamic
            //Dynamic: Like Var in JS

           // dynamic Data02 = null;
           // Console.WriteLine(Data02.GetType().Name);//Exception [Runtime Binder  Exception ]

            //CLR Detect The DataType Of The Local Variable Based On Last Value, At Runtime
            //Don'tNeed To Be Initialized
            //Can Initialize The Local Variable With Null
            //Can Change DataType Of The Local Variable After Initialization
            //Can Use The Dynamic KeyWord AS Parameter OR Return Type
            //Be carefull When Use Dynamic 
            //Like var in JS Or Objecet in C#


            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4f;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4m;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name);

            #endregion









        }
    }
}
