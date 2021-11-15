using ReactWebsite.Services.Domain;

namespace ReactWebsite.Services.Contracts
{
    public interface IInvoiceService
    {
        Invoice GetInvoiceWithDetails(string code);
    }
}