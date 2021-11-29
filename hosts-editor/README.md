2015年在 铁心桥银杏山庄 自学.net (c#)的老代码.
这个解决方案里的代码是与winform相关的.
2021.11.24
1.简单复习下winForm
2.将.net框架升级到6.0

相关的在线文档:
+ 使用 MSTest 和 .NET 进行 C# 单元测试
https://docs.microsoft.com/zh-cn/dotnet/core/testing/unit-testing-with-mstest
+ visual studio入门
https://visualstudio.microsoft.com/zh-hans/thank-you-downloading-visual-studio/?sku=Community&rel=17
在 Visual Studio 中使用 C# 创建 Windows 窗体应用
https://docs.microsoft.com/zh-cn/visualstudio/ide/create-csharp-winform-visual-studio?toc=%2Fvisualstudio%2Fget-started%2Fcsharp%2Ftoc.json&bc=%2Fvisualstudio%2Fget-started%2Fcsharp%2Fbreadcrumb%2Ftoc.json&view=vs-2022

+ visual studio c#
https://docs.microsoft.com/zh-cn/visualstudio/get-started/csharp/?view=vs-2022
+ visual studio
https://docs.microsoft.com/zh-cn/visualstudio/?view=vs-2022

适用于 UWP 应用的 Win32 和 COM API
https://docs.microsoft.com/zh-cn/uwp/win32-and-com/win32-and-com-for-uwp-apps
.net MAUI 桌面端开发技术
https://docs.microsoft.com/zh-cn/dotnet/maui/
流行的桌面端库
devexpress
https://www.devexpress.com/
另外三种桌面端开发技术
winform
WPF
UWP

https://docs.microsoft.com/zh-cn/dotnet/desktop/winforms/input-keyboard/events?view=netdesktop-6.0
visual studio中Windows 窗体控件的设计器使用.
https://docs.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/?view=netframeworkdesktop-4.8

应用权限提升解决方案:
.NET中提升UAC权限的方法总结
https://www.cnblogs.com/mayswind/p/3355649.html
c# 如何获取系统管理员权限（UAC） 及判断当前是否是管理员权限
https://www.cnblogs.com/fj99/p/4239690.html
C# Winform程序请求管理员权限.这个不好用,程序都退出了.
https://www.cnblogs.com/halfmanhuang/p/3987523.html

简单的方案:
程序运行前提升权限.很多软件都用这个办法.
需要设置manifest文件,.选择项目>>添加项>>选择应用程序清单文件.
也可以
项目属性>>安全>>启用ClickOnce安全设置,会在properties下生成app.manifest

https://docs.microsoft.com/zh-cn/visualstudio/deployment/code-access-security-for-clickonce-applications?f1url=%3FappId%3DDev16IDEF1%26l%3DZH-CN%26k%3Dk(vb.ProjectPropertiesSecurity.HowTo);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv4.8)%26rd%3Dtrue&view=vs-2022
报错:
ClickOnce不支持请求执行级别＂requireAdministrator＂
解决的方法很简单，就是在【安全性】选项卡中，把【启用ClickOnce安全设置】的勾去掉就可以了。
所以还是建议使用添加项的方式创建manifest
演练：创建未绑定的 Windows 窗体 DataGridView 控件
https://docs.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/walkthrough-creating-an-unbound-windows-forms-datagridview-control?view=netframeworkdesktop-4.8
C# DataGridView绑定List对象时，利用BindingList来实现增删查改
https://www.cnblogs.com/vveiliang/p/8522001.html

C#中Datatable和List互相转换
https://www.cnblogs.com/peng0731/p/7358351.html

DataTable to List
he following does it in a single line:

dataTable.Rows.OfType<DataRow>()
    .Select(dr => dr.Field<MyType>(columnName)).ToList();
[Edit: Add a reference to System.Data.DataSetExtensions to your project if this does not compile]

What is the columnName value here ? – 
user123456
 Jul 18 '13 at 6:10

@CodeMan03 The value of columnName is the name of whatever column has his MyType. If on the other hand each row has multiple columns with each representing a property of MyType then Richard's answer is right. – 
Yuriy Faktorovich
 Feb 12 '20 at 21:11

 https://stackoverflow.com/questions/1228539/how-to-bind-list-to-datagridview

 Bind List of Class objects as Datasource to DataGridView
 https://stackoverflow.com/questions/14393990/how-to-bind-list-to-datagridview-c-sharp
 Data binding only work with Set/Get Properties, not public field.

Try to change your FileDetail like this :

public class FileDetail
{
    public  string filename { get; set; }
    public int openConnectionCount { get; set; }
    public int closeConnectionCount { get; set; }
}
 我使用dataGridView时踩的坑.使用BindingList将List绑定到dataGridView时,完全没效果.
 最终原因是数据绑定只支持Set/Get的属性,而不是公共字段.把LineInfo中的公共字段去掉,换成属性就好.

 c#建议只有私有或者protected的变量使用字段,对外公开的数据应使用属性,方法和索引器.
 https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/fields
 创建属性时,如果使用自动属性,则编译器自动生成支持该属性的字段。相当于Java中只要写get,set,不用写成员变量.当然也可以显式指定属性对应的字段.
 https://docs.microsoft.com/zh-cn/dotnet/csharp/properties

 // 自动绑定?
 public class FileDetail
{
    [DisplayName("File Name")]    
    public  string filename { get; set; }
    [DisplayName("Open Connection")]    
    public int openConnectionCount { get; set; }
    [DisplayName("close Connection")]    
    public int closeConnectionCount { get; set; }
}

如何验证一个系统文件的编码,使用记事本打开,另存,下面会显示保存的编码,这个与文件编码是一致的.

C# DataGridView添加新行的2个方法.(如果其DataSource绑定了数据源,则这两种办法都无用)
手动添加的方式,目前只适用于所有Rows都是手动添加进去的,才行.
https://www.cnblogs.com/allan5204/p/4113080.html
```c#
// 利用dataGridView1.Rows.Add()事件为DataGridView控件增加新的行，该函数返回添加新行的索引号，即新行的行号，然后可以通过该索引号操作该行的各个单元格
int index=this.dataGridView1.Rows.Add();
this.dataGridView1.Rows[index].Cells[0].Value = "1"; 
this.dataGridView1.Rows[index].Cells[1].Value = "2"; 
this.dataGridView1.Rows[index].Cells[2].Value = "监听";
```

```c#
// 要在新行中的某些单元格添加下拉框、按钮之类的控件时，该方法很有帮助
DataGridViewRow row = new DataGridViewRow();
DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
textboxcell.Value = "aaa";
row.Cells.Add(textboxcell);
DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
row.Cells.Add(comboxcell);
dataGridView1.Rows.Add(row);
```

根据功能列出的 Windows 窗体控件
https://docs.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/windows-forms-controls-by-function?view=netframeworkdesktop-4.8

 如果希望使用DataGridView的自动创建新行功能(数据列表最后一行默认是一个空的新行),
            则必须设置它和其数据源都允许添加.
            this.dataGridView.AllowUserToAddRows = true;bindingList.AllowNew = true;