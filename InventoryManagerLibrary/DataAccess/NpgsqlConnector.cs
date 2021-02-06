using Dapper;
using InventoryManagerLibrary.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary.DataAccess
{
    public class NpgsqlConnector : IDataConnection
    {
        private const string db = "Inventory";

        // TODO - Make the CreateCase method actually grab from the database.
        /// <summary>
        /// Creates a case in the database.
        /// </summary>
        /// <param name="caseItem">The case information.</param>
        /// <returns>The case information, including the unique identifier.</returns>
        public CaseModel CreateCase(CaseModel caseItem)
        {
            using (var connection = new NpgsqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Open();
                var p = new DynamicParameters();
                p.Add("@CaseName", caseItem.CaseName);
                p.Add("@CaseStartDate", caseItem.StartDate);
                p.Add("@CaseEndDate", caseItem.EndDate);
                p.Add("@CaseStartTime", caseItem.StartTime);
                p.Add("@CaseType", caseItem.CaseType.Id);
                connection.Execute("INSERT INTO public.case (case_name, start_date, end_date, start_time, case_type_id) VALUES (@CaseName, @CaseStartDate, @CaseEndDate, @CaseStartTime, @CaseType);", p);
                var value = connection.Query("SELECT case_name FROM public.case;");
                Console.WriteLine(value.First());
                return caseItem;
            }
        }

        public List<CaseTypeModel> GetCaseType_All()
        {
            List<CaseTypeModel> output;

            using (var connection = new NpgsqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Open();
                output = connection.Query<CaseTypeModel>("SELECT * FROM public.case_type").ToList();
            }

            return output;
        }
    }
}
