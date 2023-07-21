using AutoMapper;
using HoteisAPI.Data;
using HoteisAPI.Data.Dtos;
using HoteisAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HoteisAPI.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    
    public class SuiteController : ControllerBase
    {
       
            private HospedeContext _context;
            private IMapper _mapper;

            public SuiteController(HospedeContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }


            [HttpPost]
            public IActionResult AddSuite([FromBody] CreateSuiteDto suiteDto)
            {
                Suite suite = _mapper.Map<Suite>(suiteDto);
                _context.Suites.Add(suite);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetSuiteId), new { suite.Id }, suiteDto);
            }

            [HttpGet]
            public IEnumerable<ReadSuiteDto> GetSuites()
            {
                return _mapper.Map<List<ReadSuiteDto>>(_context.Suites.ToList());
            }

            [HttpGet("{id}")]
            public IActionResult GetSuiteId(int id)
            {
                Suite suite = _context.Suites.FirstOrDefault(suite => suite.Id == id);
                if (suite != null)
                {
                    ReadSuiteDto suiteDto = _mapper.Map<ReadSuiteDto>(suite);
                    return Ok(suiteDto);
                }
                return NotFound();
            }

            [HttpPut("{id}")]
            public IActionResult UpdateSuite(int id, [FromBody] UpdateSuiteDto suiteDto)
            {
                Suite suite = _context.Suites.FirstOrDefault(suite => suite.Id == id);
                if (suite == null)
                {
                    return NotFound();
                }
                _mapper.Map(suiteDto, suite);
                _context.SaveChanges();
                return NoContent();
            }


            [HttpDelete("{id}")]
            public IActionResult DeletaSuite(int id)
            {
                Suite suite = _context.Suites.FirstOrDefault(suite => suite.Id == id);
                if (suite == null)
                {
                    return NotFound();
                }
                _context.Remove(suite);
                _context.SaveChanges();
                return NoContent();
            }

        }
    }




