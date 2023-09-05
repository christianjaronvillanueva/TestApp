namespace TestApplication.API.Models
{
    public class DFWGateLoungeFlight
    {
        public string aircraftregnumber { get; set; } = string.Empty;
        public string parentflightid { get; set; } = string.Empty;
        public string remote_airport_sch_dtm { get; set; } = string.Empty;
        public string remote_airport_act_dtm { get; set; } = string.Empty;
        public string airportcode { get; set; } = string.Empty;
        public string eventtime { get; set; } = string.Empty;
        public string airlinecode { get; set; } = string.Empty;
        public string parrentsuffix { get; set; } = string.Empty;
        public string suffix { get; set; } = string.Empty;
        public string viaairportcodes { get; set; } = string.Empty;
        public string sched_time { get; set; } = string.Empty;
        public string arrdep { get; set; } = string.Empty;
        public string bagbelt { get; set; } = string.Empty;
        public string city_name { get; set; } = string.Empty;
        public string flighttype { get; set; } = string.Empty;
        public string remote_airport_est_dtm { get; set; } = string.Empty;
        public string tfevent { get; set; } = string.Empty;
        public string aircrafttype { get; set; } = string.Empty;
        public string tail { get; set; } = string.Empty;
        public int flightnumber { get; set; }
        public int flightid { get; set; }
        public string terminalcode { get; set; } = string.Empty;
        public string airline_name { get; set; } = string.Empty;
        public string actual_time { get; set; } = string.Empty;
        public string flightstatuscode { get; set; } = string.Empty;
        public string parentairlinecode { get; set; } = string.Empty;
        public int parentfltnumber { get; set; }
        public string gatecode { get; set; } = string.Empty;
        public string remarks { get; set; } = string.Empty;
        public string estimated_time { get; set; } = string.Empty;
        public string dep_boardingstart_dtm { get; set; } = string.Empty;
    }
}
