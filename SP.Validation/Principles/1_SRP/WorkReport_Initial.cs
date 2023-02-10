using SP.Validation.Models;

namespace SP.Validation.Principles.SRP
{
    /// <summary>
    /// More than one responsibility
    /// </summary>
    public class WorkReport_Initial
    {
        private readonly List<WorkReportEntry>? _entries;
        public WorkReport_Initial()
        {
            _entries= new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry)
        {
            if (_entries != null)
            {
                _entries.Add(entry);
            }
        }
        public void RemoveEntryAt(int index)
        {
            if (_entries != null)
            {
                _entries.RemoveAt(index);
            }
        }
        public override string ToString()
        {
            string project=string.Empty;
            if (_entries != null)
            {
              project=  string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
            }
            return project;
        }

        public void SaveToFile( string directoryPath, string filename)
        {
            File.WriteAllText(Path.Combine(directoryPath, filename), ToString());
        }
    }
}
