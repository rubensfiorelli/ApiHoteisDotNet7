using AutoMapper;
using HoteisAPI.Data.Dtos;
using HoteisAPI.Data;
using HoteisAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoteisAPI.Controllers
{


        
    [ApiController]
    [Route("[Controller]")]
    public class HotelController : ControllerBase
    {

        private HospedeContext _context;
        private IMapper _mapper;

        public HotelController(HospedeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AddHotel([FromBody] CreateHotelDto hotelDto)
        {
            Hotel hotel = _mapper.Map<Hotel>(hotelDto);
            _context.Hoteis.Add(hotel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetHotelId), new { hotel.Id }, hotelDto);
        }

        [HttpGet]
        public IEnumerable<ReadHotelDto> GetHotel()
        {
            return _mapper.Map<List<ReadHotelDto>>(_context.Hoteis.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetHotelId(int id)
        {
            Hotel hotel = _context.Hoteis.FirstOrDefault(hotel => hotel.Id == id);
            if (hotel != null)
            {
                ReadHotelDto hotelDto = _mapper.Map<ReadHotelDto>(hotel);
                return Ok(hotelDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHotel(int id, [FromBody] UpdateHotelDto hotelDto)
        {
            Hotel hotel = _context.Hoteis.FirstOrDefault(hotel => hotel.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            _mapper.Map(hotelDto, hotel);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            Hotel hotel = _context.Hoteis.FirstOrDefault(hotel => hotel.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            _context.Remove(hotel);
            _context.SaveChanges();
            return NoContent();
        }



    }




   
}
