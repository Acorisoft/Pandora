using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.Pandora.Rendering
{
    /// <summary>
    /// <see cref="IDocumentRenderLayer"/> 表示一个文档渲染层。文档渲染层用于为编辑器提供渲染支持。
    /// </summary>
    public interface IDocumentRenderLayer
    {
        object CoreTextService { get; }
    }
}
