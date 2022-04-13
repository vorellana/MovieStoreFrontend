using Microsoft.AspNetCore.Mvc;
using MovieStoreFrontend.DTO;
using MovieStoreFrontend.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreFrontend.Services
{
    public class MoviesService
    {

        //public async Task<ActionResult<IEnumerable<Movie>>> GetMoviesByCustomers(string? diskStatus, string? docType)

        //    HttpClient Http = new HttpClient();
        //    string Url = "/api/Movies/byCustomers";
        //    Response<List<MoviesByCustomerDTO>> oResponse = new Response<List<MoviesByCustomerDTO>>();
        //    oResponse = await Http.GetFromJsonAsync<Response<List<MoviesByCustomerDTO>>>(Url);

        //}

        public async Task<Response<List<MoviesByCustomerDTO>>> GetMoviesByCustomers(string? diskStatus, string? docType)
        {
            Response<List<MoviesByCustomerDTO>> oResponse = new Response<List<MoviesByCustomerDTO>>();
            try
            {
                // oResponse.Data = await movieService.GetListOfMoviesByCustomer(diskStatus, docType);
                var url = "https://localhost:7095/api/Movies/byCustomers";
                // var url = "/api/Movies/byCustomers";

                var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode) {
                    // oResponse = await response.Content.ReadAsStringAsync();
                    oResponse = JsonConvert.DeserializeObject<Response<List<MoviesByCustomerDTO>>>(await response.Content.ReadAsStringAsync());
                }

            }
            catch (Exception ex)
            {
                oResponse.Success = false;
                oResponse.Message = ex.Message;
            }
            return oResponse;
        }


    }
}
