using System.Threading.Tasks;
using static BankTransferAPI.Models.Requests;

namespace BankTransferAPI.Repo
{
    public interface IBankTransfer
    {
        Task<GetBvnDetailsRequest> GetBvnDetails(GetBvnDetailsRequest request);
    }
}
