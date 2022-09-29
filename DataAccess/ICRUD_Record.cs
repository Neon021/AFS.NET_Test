using AFS.NET_Test.Models;

namespace AFS.NET_Test.DataAccess
{
    public interface ICRUD_Record
    {
        Task CreateRecord(Record record);
        Task DeleteRecord(int id);
        Task<IEnumerable<Record>> GetAllRecords();
        Task<Record> GetRecord(int id);
    }
}