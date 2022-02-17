using SingleResponsibilityPrincipal;
using System;

namespace SOLID.Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Es", ProjectName = "Project2", SpentHours = 6 });
            
            Console.WriteLine(report.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "Workreport.txt", report);
            //I:\CodeMeze\SOLID.Principal\SOLID.Principal\bin\Debug\net5.0\Reports
            Console.ReadKey();
        }
    }
}
