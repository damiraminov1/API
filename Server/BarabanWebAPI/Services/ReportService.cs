using BarabanWebAPI.Config;
using Domain.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net;

namespace BarabanWebAPI.Services
{
	public class ReportService
	{
		private readonly IOptions<ServicesConfig> _servicesConfig;
		public ReportService(IOptions<ServicesConfig> servicesConfig)
		{
			_servicesConfig = servicesConfig;
		}

		public async Task<DataOutputModel?> Report(int inputId)
		{
			using var httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(1000) };

			try
			{
				var response = await httpClient.GetAsync(_servicesConfig.Value.Report + "Report/Report?id=" + inputId);
				var responseData = await response.Content.ReadAsStringAsync();
				if (response.StatusCode == HttpStatusCode.OK)
				{
					var result = JsonConvert.DeserializeObject<DataOutputModel>(responseData);
					return result;
				}
			}
			catch { }
			return null;
		}
	}
}
