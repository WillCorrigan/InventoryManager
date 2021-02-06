using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary.Models
{
    public class CaseModel
    {
        /// <summary>
        /// Unique Identifier for case.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get Case Name
        /// </summary>
        public string CaseName { get; set; }

        /// <summary>
        /// Starting date of case.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End date of case.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Case start time.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Type of case (EPE/Realtime etc).
        /// </summary>
        public CaseTypeModel CaseType { get; set; }

        /// <summary>
        /// Case status (To be prepared/in progress/completed/cleared/cancelled)
        /// </summary>
        public CaseStatusModel CaseStatus { get; set; }

        /// <summary>
        /// Amount of faults that stopped proceedings.
        /// </summary>
        public int RedFaults { get; set; }

        /// <summary>
        /// Amount of faults that caused problems for clients.
        /// </summary>
        public int AmberFaults { get; set; }

        /// <summary>
        /// Amount of problems that occurred but didn't cause too many problems.
        /// </summary>
        public int GreenFaults { get; set; }

        /// <summary>
        /// The equipment used on the case. List of equipment.
        /// </summary>
        public List<EquipmentModel> EquipmentUsed { get; set; }

        /// <summary>
        /// Who the case was set up by. Can be a list of people.
        /// </summary>
        public List<PersonModel> CaseSetupBy { get; set; }

        /// <summary>
        /// Who the case was cleared out by. Can be a list of people.
        /// </summary>
        public List<PersonModel> CaseClearedBy { get; set; }

        /// <summary>
        /// The date and time someone arrived to set up a case.
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// The date and time someone arrived to clear out the case.
        /// </summary>
        public DateTime ClearedTime { get; set; }

        /// <summary>
        /// The location of a case.
        /// </summary>
        public LocationModel CaseLocation { get; set; }

        public CaseModel()
        {

        }

        public CaseModel(string caseName, string startDate, string endDate, string startTime, CaseTypeModel caseTypeObject)
        {
            CaseName = caseName;

            DateTime startDateValue = new DateTime(1900, 1, 1);
            DateTime.TryParse(startDate, out startDateValue);
            StartDate = startDateValue;

            DateTime endDateValue = new DateTime(1900, 1, 1);
            DateTime.TryParse(endDate, out endDateValue);
            EndDate = endDateValue;

            DateTime startTimevalue = DateTime.Parse("9:00 AM");
            DateTime.TryParse(startTime, out startTimevalue);
            StartTime = startTimevalue;

            // TODO - add location id model
            // TODO - add case status model
            // TODO - add case type model

            Console.WriteLine(caseTypeObject.Id);
            CaseTypeModel caseTypeValue = new CaseTypeModel(caseTypeObject.Id, caseTypeObject.Type);
            CaseType = caseTypeValue;
        }
    }
}
