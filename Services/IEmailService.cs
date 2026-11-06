using System.Threading.Tasks;
using Custom3DPrints.Models;

namespace Custom3DPrints.Services
{
    public interface IEmailService
    {
        Task SendQuoteEmailAsync(PrintRequest request, PrintQuote quote, string stripeCheckoutUrl);
    }
}