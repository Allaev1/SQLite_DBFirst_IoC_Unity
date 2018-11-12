# SQLite_DataBaseFirst_Sample
This project can be useful for you if you are watching for allowance of how generate
models of SQLite database. 

## Tools and libraries used in this sample:
#### Tools:
- [SQL Server Compact & SQLite Toolbox](https://github.com/ErikEJ/SqlCeToolbox)
#### Libraries:
- [SQLite-net](https://github.com/praeclarum/sqlite-net)


## Prepare environment 
You can get Toolbox from ![](https://github.com/Allaev1/SQLite_DataBaseFirst_Sample/blob/master/SQLite_DataBaseFirst_Sample/Assets/extAndupd.png)
by entering SQLite Toolbox and get this

![](https://github.com/Allaev1/SQLite_DataBaseFirst_Sample/blob/master/SQLite_DataBaseFirst_Sample/Assets/ExtensionAndTools.PNG)

SQLite-net you can download from Manager of NuGet packages by entering
`sqlite-net` in the search you must to download this one

![](https://github.com/Allaev1/SQLite_DataBaseFirst_Sample/blob/master/SQLite_DataBaseFirst_Sample/Assets/NuGetScreen.PNG)
>NOTE: In the [Toolbox`s samples](https://github.com/ErikEJ/SqlCeToolbox/wiki#how-do-i-use-the-sql-server-compact--sqlite-toolbox) will be used previous version SQLite-net library 

## Let`s generate 
Look into your Tools onto Menu row and click on `SQLite/SQL Server Compact Toolbox`
![](https://github.com/Allaev1/SQLite_DataBaseFirst_Sample/blob/master/SQLite_DataBaseFirst_Sample/Assets/GifShowToolbox.gif)

You will have class named DataAccess (as I think it`s best name cause this class even do not implement DbContext class
and generally being only as holder of models. But it is only my opinion it is why I put in brackets and you can name this class as you want ;) )

And in this part SQLte-net library provides us Attributes to make ORM model
```csharp
    public partial class Region
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }

        [MaxLength(8000)]
        public String RegionDescription { get; set; }

    }

    public partial class Shipper
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }

        [MaxLength(8000)]
        public String CompanyName { get; set; }

        [MaxLength(8000)]
        public String Phone { get; set; }

    }

```
>NOTE: SQLite-net do not full blown ORM. For instance, it do not allow 
forgein key and multiple key but this issue debating [here](https://github.com/praeclarum/sqlite-net/issues/280)









