using Domain.Contexts;
using Domain.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace BarabanWebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet(nameof(DataInputAdd))]
        public IActionResult DataInputAdd()
        {
            DataInputModel _m = DataInputModel.GetDefaultModel();
            return Ok(_m);
        }

        [HttpPost(nameof(DataInputAdd))]
        public IActionResult DataInputAdd(DataInputModel DataInput)
        {
            if (DataInput == null) return BadRequest();
            UserModel? user = _context.Users.FirstOrDefault(x => x.Login == User.Identity.Name);
            if (user == null) return BadRequest();
            DataInput.UserId = user.Id;

            _context.DataInputs.Add(DataInput);
            _context.SaveChanges();
            return Ok();
        }


        [HttpGet(nameof(Raschet))]
        public IActionResult Raschet()
        {
            UserModel? user = _context.Users.FirstOrDefault(x => x.Login == User.Identity.Name);
            return Ok(_context.DataInputs.Where(x => x.UserId == user.Id || x.UserId == 0).ToList());
        }

        [HttpDelete(nameof(Remove))]
        public IActionResult Remove(int id)
        {
            DataInputModel? dataInput = _context.DataInputs.FirstOrDefault(x => x.Id == id);
            if (dataInput == null) return NotFound();
            _context.DataInputs.Remove(dataInput);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet(nameof(DataInputEdit))]
        public IActionResult DataInputEdit(int id)
        {
            DataInputModel? dataInput = _context.DataInputs.Find(id);
            if (dataInput == null) return NotFound();
            return Ok(dataInput);
        }

        [HttpPost(nameof(DataInputEdit))]
        public IActionResult DataInputEdit(DataInputModel DataInput)
        {
            if (DataInput == null) return BadRequest();

            var existData = _context.DataInputs.AsNoTracking().FirstOrDefault(x => x.Id == DataInput.Id);

            if (existData == null) return BadRequest();

            if (existData.Name != DataInput.Name)
            {
                DataInput.Id = 0;
                _context.DataInputs.Add(DataInput);
            }
            else
            {
                _context.DataInputs.Update(DataInput);
            }
            _context.SaveChanges();

            return Ok();
        }

        //[HttpGet(nameof(Calc))]
        //public IActionResult Calc(int id)
        //{
        //    DataInputModel? dataInput = _context.DataInputs.FirstOrDefault(x => x.Id == id);
        //    if (dataInput == null) return NotFound();
        //    DataOutputModel _rezult = new DataOutputModel(dataInput);

        //    var lists = new List<double>()
        //    {
        //       _rezult.Q1,
        //       _rezult.Q2,
        //       _rezult.Q3,
        //       _rezult.Q5t,
        //       _rezult.Q5top,
        //    };

        //    return Ok(new
        //    {
        //        _rezult,
        //        diagram = lists,
        //        inputId = dataInput.Id
        //    });
        //}

        //[HttpGet(nameof(Report))]
        //public IActionResult Report(int id)
        //{
        //    DataInputModel? dataInput = _context.DataInputs.Find(id);
        //    if (dataInput == null) return NotFound();
        //    DataOutputModel _rezult = new DataOutputModel(dataInput);

        //    var lists = new List<double>()
        //    {
        //       _rezult.Q1,
        //       _rezult.Q2,
        //       _rezult.Q3,
        //       _rezult.Q5t,
        //       _rezult.Q5top,
        //    };


        //    return Ok(new
        //    {
        //        _rezult,
        //        diagram = lists
        //    });
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //[HttpGet(nameof(Error))]
        //public IActionResult Error()
        //{
        //    return BadRequest(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

    }
}