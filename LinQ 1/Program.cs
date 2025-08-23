using System.Xml.Linq;
using static LinQ_1.ListGenerator;
namespace LinQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Implicitly-Type Local Variable [Var- Dynamic ]

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

            #endregion

            #region Anonymous Type

            //Employee E01= new Employee() {Id=1,Name="Ahmed",Salary=12000 } ;
            // var E01 = new { Id = 1, Name = "Ahmed", Salary = 12000.0m };
            // var E02 = new { Id = 2, Name = "Ahmed", Salary = 12000.0m };
            //var E02 = E01 with { Id = 2 }; //New Feature C# 10.0

            //E01.Id=12;//Invalid:Immutable Can't Change Its Value After Creation

            //Console.WriteLine(E01.Name.GetHashCode()); // -1394292997
            //Console.WriteLine(E02.Name.GetHashCode()); //-1394292997     
            //The Same Anonymouse Type As Long As: 1.The Same Property Name [Case Sensitive] 
            //                                     2.The Same Property Order
            //                                     


            //Console.WriteLine(E01);//{ Id = 1, Name = Ahmed, Salary = 12000.0 }
            //Compiler Will Override On ToString
            //Console.WriteLine(E01.GetHashCode);
            //Console.WriteLine(E02.GetHashCode);

            // if(E01.Equals(E02)) //Compiler Will Override on Equales(), GetHashCode()
            //     Console.WriteLine("E01 == E02");
            // else
            //     Console.WriteLine("E01 !=E02");


            #endregion


            #region Extention Method



            #endregion




        }
    }
}
