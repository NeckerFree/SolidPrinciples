using SP.Validation.Models;
using SP.Validation.Principles.SRP.Interface;

namespace SP.Validation.Principles.SRP.Implementation
{
    public class WorkReport_SRP : IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry>? _entries;
        public WorkReport_SRP()
        {
            _entries = new List<WorkReportEntry>();
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
            string project = string.Empty;
            if (_entries != null)
            {
                project = string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));
            }
            return project;
        }
    }
}
