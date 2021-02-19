using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.Pandora.Documents
{
    /// <summary>
    /// <see cref="IDocument"/> 接口类型表示一个混合文档.
    /// </summary>
    public interface IDocument : INotifyPropertyChanged, INotifyCollectionChanged, IList<IDocumentBlockElement>
    {
    }
}
