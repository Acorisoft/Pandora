using Acorisoft.Pandora.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acorisoft.Pandora.Editor
{
    /// <summary>
    /// <see cref="IEditorProperties"/> 表示一个编辑器属性接口。
    /// </summary>
    public interface IEditorProperties
    {
        /// <summary>
        /// 获取一个 <see cref="IMessageBus"/> 接口实例。
        /// </summary>
        /// <remarks>
        /// <para><see cref="IMessageBus"/> 消息队列接口实例用于为编辑器提供一个可订阅的消息队列。</para>
        /// <para>Pandora是一个支持开发者Hook它运行过程的编辑器。实现Hook的要点就是实现消息全局化。小到鼠标点击事件，大到文档变更，所有的操作都会出现在消息队列中。</para>
        /// </remarks>
        IMessageBus MessageBus { get; } 

        /// <summary>
        /// 获取一个 <see cref="ICoreTextService"/> 接口实例。
        /// </summary>
        /// <remarks>
        /// <para><see cref="ICoreTextService"/> 核心文本服务接口用于为编辑器提供托管的文本存储服务。</para>
        /// <para><see cref="ICoreTextService"/> 核心文本服务接口提供了托管的文本存储支持，使得文本块中不需要复制文本内容。在文档接口发生变化的时候也能够很快的应用修改。</para>
        /// </remarks>
        ICoreTextService TextService { get; }

        /// <summary>
        /// 获取一个 <see cref="ISelectionManager"/> 接口实例。
        /// </summary>
        /// <remarks>
        /// <para><see cref="ISelectionManager"/> 表示一个选择管理器</para>
        /// <para><see cref="ISelectionManager"/> 选择管理器用于托管当前编辑器的选择功能。</para>
        /// </remarks>
        ISelectionManager Selection { get; }

        /// <summary>
        /// 获取一个 <see cref="ICaretManager"/> 接口实例。
        /// </summary>
        /// <remarks>
        /// <para><see cref="ICaretManager"/> 表示一个光标管理器</para>
        /// <para><see cref="ICaretManager"/> 选择管理器用于托管当前编辑器的光标功能。</para>
        /// </remarks>
        ICaretManager Caret { get; }
    }
}
