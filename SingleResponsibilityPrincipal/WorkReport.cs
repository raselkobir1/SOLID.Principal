using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipal
{
    public class WorkReport : IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> _entrys;
        public WorkReport()
        {
            _entrys = new List<WorkReportEntry>();
        }
        public void AddEntry(WorkReportEntry workReport)
        {
            _entrys.Add(workReport);
        }
        public void RemoveEntryAt(int index)
        {
            _entrys.RemoveAt(index);
        }

        public override string ToString()
        {
            var x = base.ToString();
            return string.Join(Environment.NewLine,_entrys.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
            
        }
    }
}





//-----------Before SRP--single responsibility principal-----------------------
/*
 *  public class WorkReport
    {
        private readonly List<WorkReportEntry> _entrys;
        public WorkReport()
        {
            _entrys = new List<WorkReportEntry>();
        }
        public void AddEntry(WorkReportEntry workReport)
        {
            _entrys.Add(workReport);
        }
        public void RemoveEntryAt(int index)
        {
            _entrys.RemoveAt(index);
        }
        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }
        public override string ToString()
        {
            var x = base.ToString();
            return string.Join(Environment.NewLine,_entrys.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
            
        }
    }
 */