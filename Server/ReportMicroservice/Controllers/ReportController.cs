using Microsoft.AspNetCore.Mvc;
using Domain.Models.DB;
using Domain.Contexts;
using System.Collections.Generic;

namespace ReportMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ReportController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(Report))]
        public IActionResult Report(int id)
        {
            DataInputModel dataInput = _context.DataInputs.Find(id);
            if (dataInput == null)
                return NotFound(); // или другой код статуса в зависимости от вашего случая

            DataOutputModel result = new DataOutputModel(dataInput);

            var responseData = new
            {
                DataInput = dataInput,
                Result = result,
                Diagram = new List<double>
                {
                    result.Q1,
                    result.Q2,
                    result.Q3,
                    result.Q5t,
                    result.Q5top,
                }
            };

            return Ok(responseData);
        }
    }
}


//using Microsoft.AspNetCore.Mvc;
//using Domain.Models.DB;
//using Domain.Contexts;

//namespace ReportMicroservice.Controllers
//{
//	[ApiController]
//	[Route("[controller]")]
//	public class ReportController : ControllerBase
//	{
//		private readonly ApplicationContext _context;

//		public ReportController(ApplicationContext context)
//		{
//			_context = context;
//		}

//        [HttpGet(nameof(Report))]
//        public List<object>? Report(int id)
//        {
//            DataInputModel? dataInput = _context.DataInputs.Find(id);
//            if (dataInput == null) return null;
//            DataOutputModel _rezult = new DataOutputModel(dataInput);

//            List<object> allData = new List<object>
//            {
//                dataInput,
//                _rezult
//            };

//            //var lists = new List<double>()
//            //{
//            //   _rezult.Q1,
//            //   _rezult.Q2,
//            //   _rezult.Q3,
//            //   _rezult.Q5t,
//            //   _rezult.Q5top,
//            //};


//            //return Ok(new
//            //{
//            //    _rezult,
//            //    diagram = lists
//            //});
//            return allData;
//        }

//    }
//}