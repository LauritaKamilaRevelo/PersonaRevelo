using PersonaRevelo.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaRevelo
{
    public class KRPersonRepository
    {
        string _dbPath;
        private SQLiteConnection conn;
        public string StatusMessage { get; set; }
        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<KRPerson>();
        }
        public KRPersonRepository(string dbPath)
        {
            _dbPath = dbPath;
        }
        public void AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                // TODO: Call Init()

                // basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                // TODO: Insert the new person into the database
                result = 0;

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }
        public List<KRPerson> GetAllPeople()
        {
            try
            {
                Init();
                return conn.Table<KRPerson>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<KRPerson>();
        }

    }
}
