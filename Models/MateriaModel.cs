using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.Models
{
    public class MateriaModel
    {
        [PrimaryKey, AutoIncrement]
        public int MateriaID { get; set; }
        [MaxLength(50), Unique]
        public string NomMateria { get; set; }
      
    }
}

