using Microsoft.AspNetCore.Mvc;

namespace SoapDemo.Controllers
{
    [Route("api/soap-demo")]
    [ApiController]
    public class SoapDemoController : ControllerBase
    {
        private readonly SOAPDemoSoap _demoSoap;

        public SoapDemoController(SOAPDemoSoap demoSoap)
        {
            _demoSoap = demoSoap;
        }

        [HttpGet("add-integer")]
        public async Task<IActionResult> AddInteger(int arg1, int arg2)
        {
            try
            {
                return Ok(await _demoSoap.AddIntegerAsync(arg1, arg2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("divide-integer")]
        public async Task<IActionResult> DivideInteger(int dividendo, int divisor)
        {
            try
            {
                return Ok(await _demoSoap.DivideIntegerAsync(dividendo, divisor));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
