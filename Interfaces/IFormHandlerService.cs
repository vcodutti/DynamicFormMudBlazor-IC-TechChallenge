using DynamicFormMudBlazor.Models;

namespace DynamicFormMudBlazor.Interfaces
{
    public interface IFormHandlerService
    {
        Task<Dictionary<string, object>> HandleFormSubmission(FormConfiguration formConfig);
    }
}
