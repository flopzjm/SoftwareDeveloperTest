using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using SoftwareDeveloper.Entities;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace SoftwarePresentation.DataAccess
{
    public class EmployeeDAO
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://dummy.restapiexample.com/api/v1";


        public EmployeeDAO()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);
        }


        public string GetEmployeesRest()
        {
            string respuesta = default(string);
            // Crea el cliente RestSharp
            var client = new RestClient(BaseUrl);

            // Crea una solicitud GET para la ruta "employees"
            var request = new RestRequest("employees", Method.Get);

            // Realiza la solicitud y obtiene la respuesta
            RestResponse response = client.Execute(request);

            // Verifica si la solicitud fue exitosa
            if (response.IsSuccessful)
            {

                respuesta = response.Content;

               
            }
            else
            {
                // Maneja el error
                Console.WriteLine($"Error en la solicitud: {response.StatusCode}");
            }
            return respuesta;
        }

        public string GetEmployeeRest(int employeeId)
        {
            string respuesta = default(string);
            // Crea el cliente RestSharp
            var client = new RestClient(BaseUrl);

            // Crea una solicitud GET para la ruta "employees"
            var request = new RestRequest($"employee/{employeeId}", Method.Get);


            // Realiza la solicitud y obtiene la respuesta
            RestResponse response = client.Execute(request);

            // Verifica si la solicitud fue exitosa
            if (response.IsSuccessful)
            {

                respuesta = response.Content;
            }
            else
            {
                // Maneja el error
                Console.WriteLine($"Error en la solicitud: {response.StatusCode}");
            }
            return respuesta;
        }
    }
}
