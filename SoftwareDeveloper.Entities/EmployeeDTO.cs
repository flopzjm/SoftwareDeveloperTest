using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SoftwareDeveloper.Entities
{


    public class EmployeeDTO
    {
        //[JsonProperty("status")]
        public string Status { get; set; }

        //[JsonProperty("data")]
        public List<Datum> Data { get; set; }

        //[JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Datum
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("employee_name")]
        public string EmployeeName { get; set; }

        [JsonProperty("employee_salary")]
        public long EmployeeSalary { get; set; }

        [JsonProperty("employee_age")]
        public long EmployeeAge { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }
        [JsonProperty("employee_anual_salary")]
        public long EmployeeAnualSalary { get; set; }
    }


}
