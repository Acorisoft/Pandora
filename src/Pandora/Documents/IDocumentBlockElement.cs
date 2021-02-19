using Acorisoft.Pandora.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.Pandora.Documents
{
    /// <summary>
    /// <see cref="IDocumentBlockElement"/> 表示一个块状元素。块状元素是块编辑器的基础单位。继承该接口即可实现在块级编辑器中显示。
    /// </summary>
    public interface IDocumentBlockElement
    {
        /// <summary>
        /// 获取应用于当前文本块元素的文本服务。
        /// </summary>
        ICoreTextService TextService { get; }
    }
}
