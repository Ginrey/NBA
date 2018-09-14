using System.Linq;
using NBAManagement.Data;
using NBAManagement.Data.SQL;
using NBAManagement.Model;

namespace NBAManagement
{
    public class Session
    {
        public DataBaseContext Db { get; set; }
        public ConfigurationBuilder ConfigurationBuilder { get; set; }
        public UserCredentialsModel CurrentUser { get; set; }

        public Session()
        {
            Db = new DataBaseContext();
            var d = Db.Admin.ToArray();
            ConfigurationBuilder = new ConfigurationBuilder();
        }
    }
}
