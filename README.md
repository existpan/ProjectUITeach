# ProjectUITeach winform ado.net练习
-- 记录一个2020年10月4日18:49:30遇到的巨坑，花了两个小时才解决
```Csharp
        private static string conStr = ConfigurationManager.ConnectionStrings["connString"].ToString();
        private static string conStr1 = "Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456";
```
数据库连接字符串，使用conStr1连接无数次成功，仔细检查过App.Config中的配置文件，没有命名错误，没有关键词错误
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.1" />
    </startup>
  <connectionStrings>
    <add name="connString" connectionString="Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456"/>
  </connectionStrings>
</configuration>
```
最后将两个conStr一起打印到控制台才发现
conStr中读取出来的是，  
Server=DESKTOP-KV2R00L\\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456  
而constr1中是:  
Server=DESKTOP-KV2R00L\\SQLEXPRESS;DataBase=CourseManageDB;Uid=sa;Pwd=123456  
原因就在于使用App.config进行读取时'\\'不需要被转义，而我复制过去的显然多了一个'\\'
