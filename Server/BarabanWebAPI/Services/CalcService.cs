using BarabanWebAPI.Config;
using BarabanWebAPI.Dto;
using Domain.Contexts;
using Domain.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net;

namespace BarabanWebAPI.Services
{
	public class CalcService
	{
		private readonly IOptions<ServicesConfig> _servicesConfig;
        private readonly ApplicationContext _context;
		public CalcService(IOptions<ServicesConfig> servicesConfig, ApplicationContext context)
		{

			_servicesConfig = servicesConfig;
			_context = context;
		}

		public async Task<DataOutputDto?> Calc(int inputId)
		{
            DataInputModel? dataInput = _context.DataInputs.FirstOrDefault(x => x.Id == inputId);
            using var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(1000) };

			try
			{
				var response = await httpClient.PostAsJsonAsync(_servicesConfig.Value.Calc + "Calc/Calc", dataInput);
				var responseData = await response.Content.ReadAsStringAsync();
				if (response.StatusCode == HttpStatusCode.OK)
				{
					var result = JsonConvert.DeserializeObject<DataOutputDto>(responseData);
					return result;
				}
			}
			catch { }
			return null;
		}
	}
}
