using OpenClosePrincipal;
using OpenClosePrincipal.OpenCloseExample2;
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
            var devCalculations = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator(new DeveloperReport{ Id = 1, Name = "Dev1", Level ="Senior Developer", HourlyRate = 30.5, WorkingHours= 160}),
                new SeniorDevSalaryCalculator(new DeveloperReport{ Id = 1, Name = "Dev4", Level ="Senior Developer", HourlyRate = 30.5, WorkingHours= 160}),
                new JuniorDevSalaryCalculator(new DeveloperReport{ Id = 1, Name = "Dev2", Level ="Junior Developer", HourlyRate = 15.5, WorkingHours= 180}),
                new InternDevSalaryCalculator(new DeveloperReport{ Id = 1, Name = "Dev3", Level ="Intern Developer", HourlyRate = 20.5, WorkingHours= 150})
            };

            var calculator = new SalaryCalculator(devCalculations);
            var totalSalaries = calculator.CalculateTotalSalaries();
            Console.WriteLine("\n************************ Open Close principal *********************************");
            Console.WriteLine($"Sum of all the developer salaries is = {totalSalaries} dollers.");
            //----------------------Open Close- 2 -Filtering-------------------------------
            var monitors = new List<ComputerMonitor>
            {
                new ComputerMonitor{ Name = "Samsung S345", Screen= Screen.CurvedScreen, Type = MonitorType.OLED},
                new ComputerMonitor{ Name = "Philips P532", Screen= Screen.WideScreen, Type = MonitorType.LCD},
                new ComputerMonitor{ Name = "LG L888", Screen= Screen.WideScreen, Type = MonitorType.LED},
                new ComputerMonitor{ Name = "Samsung S999", Screen= Screen.CurvedScreen, Type = MonitorType.OLED},
                new ComputerMonitor{ Name = "Dell D254", Screen= Screen.CurvedScreen, Type = MonitorType.LCD},
            };
            var filter = new MonitorFilter();
            var lcdMonitros = filter.FilterByType(monitors, MonitorType.LCD);
            Console.WriteLine("--------------All LCD Monitor-search by type------------");
            foreach (var monitor in lcdMonitros)
            {
                Console.WriteLine($"Name : { monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen }");
            }

            Console.WriteLine("--------------All LED Monitor-Search by screen------------");
            var ledMonitor = filter.FilterByScreen(monitors, Screen.CurvedScreen);
            foreach (var monitor in lcdMonitros)
            {
                Console.WriteLine($"Name : { monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen }");

            }
            Console.ReadKey();
        }
    }
}
