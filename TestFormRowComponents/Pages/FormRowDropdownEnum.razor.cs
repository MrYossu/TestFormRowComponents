using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace TestFormRowComponents.Pages {
  public partial class FormRowDropdownEnum<T> where T : Enum, IConvertible {
    [Parameter]
    public int Value { get; set; }

    [Parameter]
    public EventCallback<int> ValueChanged { get; set; }

    [Parameter]
    public string PropertyName { get; set; }

    [Parameter]
    public string Caption { get; set; }

    [Parameter]
    public string Icon { get; set; }

    private async Task OnValueChanged(ChangeEventArgs cea) {
      int val = (int)Enum.Parse(typeof(T), cea.Value?.ToString() ?? "0");
      Value = val;
      await ValueChanged.InvokeAsync(val);
    }
  }
}