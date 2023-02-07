using SP.Validation.Models;
using SP.Validation.Principles.SRP.Interface;

namespace SP.Validation.Principles.SRP.Implementation
{
    internal class Scheduler_SRP : IEntryManager<ScheduleTask>
    {
        private readonly    List<ScheduleTask> _tasks;
        public Scheduler_SRP()
        {
            _tasks= new List<ScheduleTask>();
        }
        public void AddEntry(ScheduleTask entry)
        {
            if(_tasks!=null)
            {
                _tasks.Add(entry);
           }
        }

        public void RemoveEntryAt(int index)
        {
            if (_tasks != null)
            {
                _tasks.RemoveAt(index);
            }
        }
        public override string ToString()
        {
            string schedule=string.Empty;
            if(_tasks!=null)
            {
              schedule=  string.Join(Environment.NewLine, _tasks.Select(t => $"Task with id: {t.TaskId}, with content: {t.Content}, is going to be executed on :{t.ExecutedOn}"));
            }
            return schedule;
        }
    }
}
