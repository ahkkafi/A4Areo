# A4Areo
###Create a Database Named AgentDb

 ``Conn String = @"Data Source=.\SQLEXPRESS;Initial Catalog=AgentDb;Integrated Security=True";``
 
 ### put connection string on Repository.cs
 ```  public Repository()
        {
            ConnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=AgentDb;Integrated Security=True";
        }
 ```
