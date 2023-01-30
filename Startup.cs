using MySqlConnector;

namespace Conection{

public  class MyClass
{
    // public object Configuration { get; private set; }

   static public void  ConfigureServices(IServiceCollection services)
{
    // ...
    services.AddTransient<MySqlConnection>(_ => new MySqlConnection("Server=127.0.0.1;User ID=root@localhost;Database=test"));
}
}
    
}
