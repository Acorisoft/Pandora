using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.Pandora.Documents
{
    public class MarkdownDocument : ObservableCollection<IDocumentBlockElement>, IDocument,IEditable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentLocker"></param>
        public MarkdownDocument(object documentLocker)
        {
            //
            // 文档只有在输入阶段的处理时才允许
        }

        public void BeginUpdate()
        {
            throw new NotImplementedException();
        }

        public void EndUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
