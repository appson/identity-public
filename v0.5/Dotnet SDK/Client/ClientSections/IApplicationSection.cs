using System.Threading.Tasks;
using Appson.Identity.Client.Model.Application.Key;

namespace Appson.Identity.Client.ClientSections
{
    public interface IApplicationSection
    {
        Task<ApplicationKeyResponse> GetPublicKeyAsync(string applicationId);
    }
}