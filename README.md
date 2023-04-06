# ASP.NET Core MVC實作員工管理系統的新增、刪除、修改和讀取
在上完ASP.NET Core MVC的CRUD單元後，於是自己實作並修改老師的作業，將其修改成SQL Server連線版本，因實務上都是採用SQL Server做連線，而資料的存取是使用Entity Framework Core。

### 專案前置作業
- 安裝以下套件:MicroSoft.EntityFrameworkCore.SqlServer、MicroSoft.EntityFrameworkCore.Tools
- 在wwwroot加入Bootstrap、Jquery、Jquery-Validate、Jquery-Validation-unobtrusive

### 動作說明
* 讀取:將員工資料抓取出來，呈現在頁面上。
* 新增:新增員工資料。(新增成功，會跳出新增成功的提示訊息)
* 修改:修改員工資料。(修改成功，會跳出修改成功的提示訊息)
* 刪除:刪除員工資料。(在刪除前，會先跳出提示訊息確認是否要刪除，按下是，刪除資料後，會跳出刪除資料成功的訊息)


