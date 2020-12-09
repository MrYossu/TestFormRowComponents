using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace TestFormRowComponents.Pages {
  public partial class FormRowDropdownEnum<T> where T : Enum, IConvertible {
    private T _value;

    protected override void OnParametersSet() =>
      _value = Value;

    [Parameter]
    public T Value { get; set; }

    [Parameter]
    public EventCallback<T> ValueChanged { get; set; }

    [Parameter]
    public string PropertyName { get; set; }

    [Parameter]
    public string Caption { get; set; }

    [Parameter]
    public string Icon { get; set; }

    private async Task OnChanged(ChangeEventArgs cea) {
      int val = (int)Enum.Parse(typeof(T), cea.Value?.ToString() ?? "0");
      _value = (T)(object)val;
      await ValueChanged.InvokeAsync(_value);
    }
  }
}