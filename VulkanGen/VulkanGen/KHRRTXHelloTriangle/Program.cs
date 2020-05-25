using System;
using System.Diagnostics;

namespace KHRRTXHelloTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloTriangle app = new HelloTriangle();

            try
            {
                app.Run();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
    }
}
