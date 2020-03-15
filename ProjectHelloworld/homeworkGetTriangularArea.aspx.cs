using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ycy
{
    public partial class homeworkGetTriangularArea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double a, b, c;
            string x,y;
            a=10;
            b=1;
                c=8;
            ;
            if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b && b == c)
                 x="等边";
                else if (a == b || b == c || a == c)
               x="等腰";
                else
                x="一般";
                if (a * a + b * b < c * c || a * a > b * b + c * c || b * b >a * a + c * c)
                    y="钝角";
                else if (a * a + b * b == c * c || a * a == b * b + c * c ||  b * b== a * a + c * c)
                    y="直角";
                else
                    y="锐角";
                double p = (a + b + c)/2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Response.Write("你输入的三条边组成了一个"+x+y+"三角形，它的面积是" + s);
            }
            else
                Response.Write("你输入的三条边不能构成一个三角形");
        }
    }
}