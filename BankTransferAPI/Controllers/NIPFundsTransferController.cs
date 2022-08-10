using BankTransferAPI.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static BankTransferAPI.Models.Requests;

namespace BankTransferAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NIPFundsTransferController : ControllerBase
    {
        private readonly IBankTransfer _bankTransfer;
        public NIPFundsTransferController(IBankTransfer bankTransfer)
        {
            _bankTransfer = bankTransfer;
        }

        [HttpGet]
        public async Task<ActionResult> GetBvnDetails(GetBvnDetailsRequest request)
        {
            var result = await _bankTransfer.GetBvnDetails(request);
            return Ok(result);
            
        }
    }
}
