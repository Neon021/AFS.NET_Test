using AFS.NET_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS.NET_Test.DataAccess
{
    public class CRUD_Record : ICRUD_Record
    {
        private SqlDataAccess _access;

        public CRUD_Record(SqlDataAccess access)
        {
            _access = access;
        }

        public Task CreateRecord(Record record) => _access.SaveData(
            storedProcedures: "dbo.spRecord_Create",
            new { record.Input, record.Output, record.Date });

        public Task DeleteRecord(int id) => _access.SaveData(
            storedProcedures: "dbo.spRecord_Delete",
            new { id = id });

        public Task<IEnumerable<Record>> GetAllRecords() => _access.LoadData<Record, dynamic>(
            storedProcedures: "dbo.spRecord_GetAll",
            new { });

        public async Task<Record> GetRecord(int id)
        {
            var result = await _access.LoadData<Record, dynamic>(storedProcedures: "dbo.spRecord_Get", new { id = id });
            return result.FirstOrDefault();
        }
    }
}
