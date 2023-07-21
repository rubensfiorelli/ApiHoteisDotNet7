using AutoMapper;
using HoteisAPI.Data;
using HoteisAPI.Data.Dtos;
using HoteisAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoteisAPI.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class HospedeController : ControllerBase
    {
        private HospedeContext _context;
        private IMapper _mapper;


        public HospedeController(IMapper mapper, HospedeContext context)
        {
            _mapper = mapper;
            _context = context;

        }


        [HttpPost]
        public CreatedAtActionResult AddHospede([FromBody] CreateHospdeDto hospedeDto)
        {
            Hospede hospede = _mapper.Map<Hospede>(hospedeDto);
            _context.Hospedes.Add(hospede);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetHospedeId), new { id = hospede.id }, hospede);

        }

        [HttpGet]
        public IEnumerable<ReadHospedeDto> GetHospedes([FromQuery] int take = 50)
        {

            return _mapper.Map<List<ReadHospedeDto>>(_context.Hospedes.Take(take));
        }

        [HttpGet("{id}")]
        public IActionResult GetHospedeId(int id)
        {
            var hospede = _context.Hospedes.FirstOrDefault(hospede => hospede.id == id);
            if (hospede == null) return NotFound();
            var hospedeDto = _mapper.Map<ReadHospedeDto>(hospede);
            return Ok(hospedeDto);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateHospede(int id, [FromBody] UpdateHospedeDto hospedeDto)
        {

            var hospede = _context.Hospedes.FirstOrDefault(hospede => hospede.id == id);
            if (hospede == null) return NotFound();
            _mapper.Map(hospedeDto, hospede);
            _context.SaveChanges();
            return NoContent();


        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHospede(int id)
        {
            var hospede = _context.Hospedes.FirstOrDefault(hospede => hospede.id == id);
            if (hospede == null) return NotFound();
            _context.Remove(hospede);
            _context.SaveChanges();
            return NoContent();

        }




    }
}
