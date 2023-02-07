namespace SP.Validation.Principles.SRP.Interface
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);
        void RemoveEntryAt(int index);
    }
}
