using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace home.db
{
    [Table("Project")]
    public class ProjectModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    }
}
