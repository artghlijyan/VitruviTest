using Dal.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dal.DbContext.MsSql
{
    public class SqlContext : IDbContext
    {
        private string ConnectionString { get; }

        public SqlContext()
        {
            ConnectionString = new ConfigurationBuilder().
                AddJsonFile("DbConfig.json").Build().
                GetConnectionString("SqlConnection");
        }


        public ProviderGroup GetProviderGroups()
        {
            string procName = "sp_GetProviderGroups";

            var pGroup = new ProviderGroup();
            pGroup.groupNames = new List<Group>();
            pGroup.providerNames = new List<Provider>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand cmd = new SqlCommand(procName, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var group = new Group();
                            var provider = new Provider();

                            group.Name = (string)reader["GroupName"];
                            provider.Name = (string)reader["ProviderName"];

                            pGroup.groupNames.Add(group);
                            pGroup.providerNames.Add(provider);
                        }
                    }
                }
            }

            return pGroup;
        }
    }
}
