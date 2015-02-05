using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class RolDAL
    {
        public List<Rol> Listar() 
        {
            var roles = new List<Rol>();

            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Colegio"].ToString())) 
                {
                    con.Open();

                    var query = new SqlCommand("SELECT * FROM rol", con);
                    using (var dr = query.ExecuteReader()) 
                    {
                        while (dr.Read()) 
                        {
                            roles.Add(
                                new Rol { 
                                    id = Convert.ToInt32(dr["id"]),
                                    Nombre = dr["Nombre"].ToString()
                                }
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return roles;
        }
    }
}
