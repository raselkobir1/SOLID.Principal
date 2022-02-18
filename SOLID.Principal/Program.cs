using OpenClosePrincipal;
using SingleResponsibilityPrincipal;
using System;
using System.Collections.Generic;

namespace SOLID.Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------Single Responsibilities principal:--------------------------
            //===================================================================================================
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Es", ProjectName = "Project2", SpentHours = 6 });
            
            //I:\CodeMeze\SOLID.Principal\SOLID.Principal\bin\Debug\net5.0\Reports

            var schedular = new Scheduler();
            schedular.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now", ExecuteOn = Convert.ToDateTime(DateTime.UtcNow.ToShortDateString()) });
            schedular.AddEntry(new ScheduleTask { TaskId = 2, Content = "Don't forget me", ExecuteOn = Convert.ToDateTime(DateTime.UtcNow.ToShortDateString()) });

            Console.WriteLine("\n************************ Single Responsibility Principal *********************************");
            Console.WriteLine(report.ToString());
            Console.WriteLine(schedular.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "Workreport.txt", report);
            saver.SaveToFile(@"Schudulars", "schudule.txt", schedular);

            //----------------------------------Open Close principal---------------------------------------------
            //===================================================================================================
            var devReports = new List<DevelopmentReport>
            {
                new DevelopmentReport{ Id = 1, Name = "Dev1", Level ="Senior Developer", HourlyRate = 30.5, WorkingHours= 160},
                new DevelopmentReport{ Id = 1, Name = "Dev2", Level ="Junior Developer", HourlyRate = 15.5, WorkingHours= 180},
                new DevelopmentReport{ Id = 1, Name = "Dev3", Level ="Intern Developer", HourlyRate = 20.5, WorkingHours= 150},
                new DevelopmentReport{ Id = 1, Name = "Dev4", Level ="Senior Developer", HourlyRate = 30.5, WorkingHours= 160}
            };

            var calculator = new SalaryCalculator(devReports);
            var totalSalaries = calculator.CalculateTotalSalaries();
            Console.WriteLine("\n************************ Open Close principal *********************************");
            Console.WriteLine($"Sum of all the developer salaries is = {totalSalaries} dollers.");


            Console.ReadKey();
        }
    }
}
