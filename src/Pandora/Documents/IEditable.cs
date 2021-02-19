using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.Pandora.Documents
{
    public interface IEditable
    {
        /// <summary>
        /// 指示当前可编辑对象现在可以开始更新。
        /// </summary>
        /// <remarks>
        /// <para> 我们规定，实现了 <see cref="IDocument"/> 类型接口的对象必须实现 <see cref="IEditable"/> 类型接口。</para>
        /// </remarks>
        void BeginUpdate();
        void EndUpdate();
    }
}
