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
            
            //I:\CodeMeze\SOLID.Principal\SOLID.Principal\bin\Debug\net5.0\Reports

            var schedular = new Scheduler();
            schedular.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now", ExecuteOn = Convert.ToDateTime(DateTime.UtcNow.ToShortDateString()) });
            schedular.AddEntry(new ScheduleTask { TaskId = 2, Content = "Don't forget me", ExecuteOn = Convert.ToDateTime(DateTime.UtcNow.ToShortDateString()) });


            Console.WriteLine(report.ToString());
            Console.WriteLine(schedular.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "Workreport.txt", report);
            saver.SaveToFile(@"Schudulars", "schudule.txt", schedular);

           
            Console.ReadKey();
        }
    }
}
