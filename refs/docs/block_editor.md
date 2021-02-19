

# 块级文档编辑器

块级文档编辑器（Block based document editor），是一种新型的文本编辑器，每一个内容都是一个独立的文档块，通过不同的文档块之间的组合实现富文本编辑。

## 简介

目前基于块级的文档编辑器多数为JavaScript实现，这类产品主要有：

* Xamarin Workbook
* Google Colab
* 语雀
* Jupyter

本项目的主旨就是实现一个简单的块级编辑器来支撑我们的下游项目。

## 设计思路

我们在构思这个项目的前期，就决定了这个文档编辑器应该支持功能Hook的，之所以选择支持Hook，是因为我们想让用户能够轻松地编写自己的逻辑，使得自定义的文档编辑器能够适应更好的用途。

### 虚拟焦点

传统的桌面应用开发中对于焦点的处理存在这非常多的坑，正式鉴于此我们打算内建一个焦点管理器（[FocusScopeManager](#焦点管理器)）来管理整个文档编辑器的焦点，以便用户能够轻松地拓展编辑器的功能。

### 自定义文本着色

文档编辑器提供了便捷的方法为用户提供自定义文本着色支持。

## 文档编辑流程

块级编辑器在设计的时候提供了比较多能够被Hook功能的地方，如果编辑器还沿用旧的思路编写，那么可以预见的是整个应用的性能和稳定性都是非常糟糕的。为了避免这种情况的发生，我们定义了一个文档编辑流程，用于规范插件行为对文档内容修改行为。

### 输入阶段

文档编辑流程中，输入阶段是最先开始的阶段，这个阶段主要扫描用户的文本输入，过滤文本输入以及重建文档元素。

### 编辑阶段

编辑阶段发生在输入阶段之后，这个阶段主要是处理文档内容的更改与文档结构的更改。

### 测量阶段

### 调整阶段

### 渲染阶段



## 消息



## 焦点

### Coding

```C#
public class MouseDownHandler: EditorHandler<MouseDownEventArgs>
{
    public void OnNext(MouseDownEventArgs e)
    {
        // 获取当前鼠标位置的
        var element = Editor.GetDocumentBlockElementByPoint(e.Point);
        
        //
        Editor.FocusManager.SetFocus(element);
    }
}
```

