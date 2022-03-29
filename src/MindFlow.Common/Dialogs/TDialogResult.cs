
using Prism.Services.Dialogs;

namespace MindFlow.Common.Dialogs
{
    public class TDialogResult<T> : DialogResult
    {
        public TDialogResult(ButtonResult result) : base(result)
        {

        }

        public T Data { get; set; }
    }
}
