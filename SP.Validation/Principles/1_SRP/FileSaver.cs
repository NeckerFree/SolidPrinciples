using SP.Validation.Principles.SRP.Interface;

namespace SP.Validation.Principles.SRP
{
    public class FileSaver
    {
        public void SaveToFile<T>(string directoryPath, string filename, IEntryManager<T> wordReport)
        {
            File.WriteAllText(Path.Combine(directoryPath, filename),wordReport.ToString());
        }

    }
}
