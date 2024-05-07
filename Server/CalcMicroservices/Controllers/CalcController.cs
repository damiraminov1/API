using Microsoft.AspNetCore.Mvc;
using Domain.Models.DB;
using Domain.Contexts;

namespace CalcMicroservice.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CalcController : ControllerBase
	{
		private readonly ApplicationContext _context;

		public CalcController(ApplicationContext context)
		{
			_context = context;
		}

		[HttpGet(nameof(Calc))]
		public DataOutputModel? Calc(int id)
		{
            DataInputModel? dataInput = _context.DataInputs.Find(id);
            if (dataInput == null) return null;
			DataOutputModel _rezult = new DataOutputModel(dataInput);

			//var lists = new List<double>()
			//{
			//   _rezult.Q1,
			//   _rezult.Q2,
			//   _rezult.Q3,
			//   _rezult.Q5t,
			//   _rezult.Q5top,
			//};

			//return Ok(new
			//{
			//	_rezult,
			//	diagram = lists,
			//	inputId = dataInput.Id
			//});
			return _rezult;
		}
	}
}