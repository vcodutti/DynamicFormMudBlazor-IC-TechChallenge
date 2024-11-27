namespace DynamicFormMudBlazor.Models;

public class FormField
{
    public string Type { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public bool Required { get; set; } = false;
    public string? Value { get; set; }
    public List<string>? Values { get; set; }
    public int? Min { get; set; }
    public int? Max { get; set; }
    public bool IsChecked { get; set; }
}
