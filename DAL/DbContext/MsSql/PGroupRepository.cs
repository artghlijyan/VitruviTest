using Dal.Models;
using DAL.DbContext.SqlContext;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dal.DbContext.MsSql
{
    public class PGroupRepository : IRepository<ProviderGroup>
    {
        private SqlContext _sqlContext;

        public PGroupRepository()
        {
            _sqlContext = new SqlContext();
        }

        public ProviderGroup GetProviderGroups()
        {
            string procName = "sp_GetProviderGroups";

            var pGroup = new ProviderGroup();
            pGroup.Groups = new List<Group>();
            pGroup.Providers = new List<Provider>();
            pGroup.ProviderTypes = new List<ProviderType>();

            using (SqlConnection connection = new SqlConnection(_sqlContext.ConnectionString))
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
                            var providerType = new ProviderType();

                            group.Name = (string)reader["GroupName"];
                            provider.Name = (string)reader["ProviderName"];
                            providerType.Name = (string)reader["TypeName"];

                            pGroup.Groups.Add(group);
                            pGroup.Providers.Add(provider);
                            pGroup.ProviderTypes.Add(providerType);
                        }
                    }
                }
            }

            return pGroup;
        }
    }
}
