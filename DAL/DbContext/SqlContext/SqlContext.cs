using Microsoft.Extensions.Configuration;

namespace DAL.DbContext.SqlContext
{
    public class SqlContext : IDbContext
    {
        public string ConnectionString => new ConfigurationBuilder().
                AddJsonFile("DbConfig.json").Build().
                GetConnectionString("SqlConnection");
    }
}
