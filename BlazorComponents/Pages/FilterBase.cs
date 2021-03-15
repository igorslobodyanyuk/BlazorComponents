using System;
using Microsoft.AspNetCore.Components;

namespace BlazorComponents.Pages
{
    public abstract class FilterBase : ComponentBase
    {
        [CascadingParameter]
        public FilterList ParentComponent { get; set; }

        public abstract void Clear();
        public abstract void Submit();

        protected override void OnInitialized()
        {
            if (ParentComponent == null)
                throw new Exception($"Must be used within {nameof(FilterList)}");

            ParentComponent.AddChild(this);
        }
    }

    public class FilterBase<TField> : FilterBase
    {
        private TField field;

        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public TField Field
        {
            get;
            set;
        }

        [Parameter]
        public EventCallback<TField> FieldChanged { get; set; }

        public override void Clear()
        {
            Field = default;
            FieldChanged.InvokeAsync(Field);
        }

        public override void Submit()
        {
            FieldChanged.InvokeAsync(Field);
        }
    }
}
