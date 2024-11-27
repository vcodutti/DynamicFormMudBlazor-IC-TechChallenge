using DynamicFormMudBlazor.Interfaces;
using DynamicFormMudBlazor.Models;

namespace DynamicFormMudBlazor.Services
{
    public class FormHandlerService : IFormHandlerService
    {
        public async Task<Dictionary<string, object>> HandleFormSubmission(FormConfiguration formConfig)
        {
            var outputDict = formConfig.Fields.ToDictionary(
                f => f.Label,
                f => f.Type switch
                {
                    "number" when int.TryParse(f.Value, out var num) => (object)num,
                    "checkbox" => f.IsChecked,
                    _ => f.Value
                }
            );

            await Task.Delay(100);

            return outputDict;
        }
    }
}
