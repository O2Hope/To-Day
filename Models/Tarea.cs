using System;
using SQLite;

namespace Today.Models
{
    public class Tarea
    {
        [PrimaryKey, AutoIncrement]
        public object Id
        {
            get;
            set;
        }

        [MaxLength(150)]
        public string Nombre
        {
            get;
            set;
        }

        public DateTime fInicial
        {
            get;
            set;
        }

        public bool Status
        {
            get;
            set;
        }

    }
}
