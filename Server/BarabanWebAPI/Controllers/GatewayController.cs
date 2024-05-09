//using Baraban.Models;
using BarabanWebAPI.Dto;
using BarabanWebAPI.Services;
using Domain.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BarabanWebAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
	[ApiController]
	public class GatewayController : ControllerBase
	{
		private readonly CalcService _calcService;
		private readonly ReportService _reportService;
		public GatewayController(CalcService calcService, ReportService reportService)
		{
			_calcService = calcService;
			_reportService = reportService;
		}

		[HttpGet(nameof(Calc))]
		public async Task<DataOutputDto?> Calc(int inputId)
		{
			var res = await _calcService.Calc(inputId);
			return res;
		}

		[HttpGet(nameof(Report))]
		public async Task<DataOutputModel?> Report(int inputId)
		{
			var res = await _reportService.Report(inputId);
			return res;
		}
	}
}
