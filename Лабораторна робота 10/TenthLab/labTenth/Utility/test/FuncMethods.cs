using labTenth.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Utility.test
{
    internal class FuncMethods
    {
        private GeometryThings geometryCalc = new GeometryThings();

        public void Execute()
        {
            InformationPrinter.PrintHeader("Func:");

            double triBase = MakeData.GetDoubleNum(1.0, 20.0);
            double triHeight = MakeData.GetDoubleNum(1.0, 20.0);
            double rectA = MakeData.GetDoubleNum(1.0, 20.0);
            double rectB = MakeData.GetDoubleNum(1.0, 20.0);

            double triArea = geometryCalc.TriangleArea(triBase, triHeight);
            double rectArea = geometryCalc.RectangleArea(rectA, rectB);

            InformationPrinter.PrintAreaResult("Triangle", $"base: {triBase}, height: {triHeight}", triArea);
            InformationPrinter.PrintAreaResult("Rectangle", $"sides: {rectA} x {rectB}", rectArea);
            Console.WriteLine();
        }
    }
}
