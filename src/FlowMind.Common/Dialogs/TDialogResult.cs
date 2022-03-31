
using Prism.Services.Dialogs;

namespace FlowMind.Common.Dialogs
{
    public class TDialogResult<T> : DialogResult
    {
        public TDialogResult(ButtonResult result) : base(result)
        {

        }

        public T Data { get; set; }
    }
}
