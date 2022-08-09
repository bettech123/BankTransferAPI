using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankTransferAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NIPFundsTransferController : ControllerBase
    {
        [HttpGet]
        public IActionResult NIPTransfer()
        {
            return Ok();
        }
    }
}
