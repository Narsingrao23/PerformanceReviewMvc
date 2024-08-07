using Newtonsoft.Json;
using PrservMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static PrservMvc.Models.EmployeeFo;

namespace PrservMvc.Service
{
    public class EmployeeServ : IEmployeeInterface
    {

        Uri baseAddress =new Uri("https://localhost:7054/api");
        private readonly HttpClient _httpClient;

        public EmployeeServ()
        {
                _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }
        public bool CreateEmployee(EmployeeFo employee)
        {
            string data = JsonConvert.SerializeObject(employee);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response = _httpClient.PostAsync(_httpClient.BaseAddress + "/NewEmployee", content).Result;
            
            if (response.IsSuccessStatusCode) { return true; }
              return false;
             
        }

        public bool DeleteEmployee(EmployeeFo employee)
        {
            throw new NotImplementedException();
        }

        public EmployeeFo GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeFo> GetEmployees()
        {
            List<EmployeeFo> list = new List<EmployeeFo>();
            HttpResponseMessage response = _httpClient.GetAsync(_httpClient.BaseAddress + "/AllEmployee").Result;
            if(response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                list = JsonConvert.DeserializeObject<List<EmployeeFo>>(data);
                
            }
            return list;


        }

        public bool IsEmployeeActive(int id)
        {
            throw new NotImplementedException();
        }

        public bool save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(EmployeeFo employee)
        {
            throw new NotImplementedException();
        }
    }
}
