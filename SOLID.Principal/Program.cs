﻿using DependencyInversionPrinciple;
using LiskovSubstitutionPrincipal;
using OpenClosePrincipal;
using OpenClosePrincipal.Example3;
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
            //I:\CodeMeze\SOLID.Principal\SOLID.Principal\bin\Debug\net5.0\Reports
            //--------------------------------------Single Responsibilities principal:--------------------------
            //===================================================================================================
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Es", ProjectName = "Project2", SpentHours = 6 });
            
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
            var lcdMonitros = filter.Filter(monitors, new MonitorTypeSpecification(MonitorType.LCD));
            Console.WriteLine("\n--------------All LCD Monitor-search by type------------");
            foreach (var monitor in lcdMonitros)
            {
                Console.WriteLine($"Name : { monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen }");
            }
            Console.WriteLine("\n-------------- All Wide screen Monitor-search by screen---------");
            var wideScreenMonitors = filter.Filter(monitors, new ScreenSpecification(Screen.WideScreen));
            foreach (var monitor in wideScreenMonitors)
            {
                Console.WriteLine($"Name : { monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen }");
            }


            //----------------------Example 3------------------------------
            InvoiceForCancel cancel = new InvoiceForCancel(100);
            var cancelInvoiceAmount = cancel.CalculateInvoiceAmount();

            InvoiceForReissue reissue = new InvoiceForReissue(100);
            var reIssueInvoiceAmount = reissue.CalculateInvoiceAmount();

            InvoiceForRefund refund = new InvoiceForRefund(300);
            var invoiceAmountForRefund = refund.CalculateInvoiceAmount();

            Console.WriteLine("===================================================================");
            Console.WriteLine($"------------> cancelInvoiceAmount :{cancelInvoiceAmount} \n------------> reIssueInvoiceAmount: {reIssueInvoiceAmount}  \n------------> refundInvoiceAmount: {invoiceAmountForRefund}");
            //----------------------------------Liskov Substitution principal---------------------------------------------
            //============================================================================================================

            var numbers = new int[] { 5, 7,4, 9, 6, 5, 4, 7 };
            Calculator sum = new SumCalculator(numbers);
            var totalSum = sum.Calculate();
            Console.WriteLine($"The sum of all the numbers: {totalSum}");

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            var evenTotalSum = evenSum.Calculate();
            Console.WriteLine($"The sum of even numbers: {evenTotalSum}");

            //----------------------------------Dipendency Inversion of Control principal---------------------------------------------
            //===================================================================================================

            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Rasel", Gender = Gender.Male, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });

            var stats = new EmployeeStatistics(empManager);
            var count = stats.CountFemaleManager();
            Console.WriteLine($"\nNumber of female managers in our company is: {count}");
            
            Console.ReadKey();
        }
    }
}
