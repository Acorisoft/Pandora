using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acorisoft.Pandora.Editor
{
    public interface IEditor : IEditorProperties, IAttachXamlEditorProperties, IEditorXamlControlProperties
    {
        void SaveAsync(Stream stream);
        void SaveAsync(string fileName);
        void LoadAsync(Stream stream);
        void LoadAsync(string fileName);
    }
}
