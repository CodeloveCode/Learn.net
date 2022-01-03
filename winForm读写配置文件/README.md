
c# 的winform 程序, 读写自带配置文件.

c# 的winForm项目运行后,在bin/Debug目录(实际运行目录)下,会有一个 [项目名].exe.config文件,这个文件中有当前项目的配置.如:数据库连接
C# 提供了对这个文件的快捷读写支持. 因此一般用它来保存winForm App的一些配置.

# 步骤
1. 在"引用"上右键选择"添加引用">>程序集>>选择并添加System.Configuration.
2. 使用System.Configuration下的API,准备好read,write的工具类.
3. 使用.
