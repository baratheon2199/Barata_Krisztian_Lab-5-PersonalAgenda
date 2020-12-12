using System;
using SQLite;
using SQLitePCL;
using System.Collections.Generic;
using System.Text;
using PersonalAgenda;
namespace PersonalAgenda.Models
{
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
