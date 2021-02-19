using Acorisoft.Pandora.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.Pandora.Editor
{
    public interface IEditorXamlControlProperties
    {
        IDocument Document { get; }
        IXamlScrollViewer ScrollViewer { get; }
        IXamlItemsControl ItemsControl { get; }
    }
}
