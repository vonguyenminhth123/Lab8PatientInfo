using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8PatientInfo
{
    [Table("Hike")]
    public class Hike
    {
        [PrimaryKey, AutoIncrement]
        public int HikeId { get; set; }
        public string HikeName { get; set; }
        public string HikeLocation { get; set; }
        public DateTime HikeDate { get; set; }
        public bool HikeAvailability { get; set; }
        public string HikeLength { get; set; }
        public string HikeLevel { get; set; }
        public string HikeDescription { get; set; }
        public Hike() { }
        public Hike (int hikeId, string hikeName, string hikeLocation, DateTime hikeDate, bool hiikeAvailability, 
            string hikeLength, string hikeLevel, string hikeDescription)
        {
            HikeId = hikeId;
            HikeName = hikeName;
            HikeLocation = hikeLocation;
            HikeDate = hikeDate;
            HikeAvailability = hiikeAvailability;
            HikeLength = hikeLength;
            HikeLevel = hikeLevel;
            HikeDescription = hikeDescription;
        }
    }
}
