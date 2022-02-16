using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace home.db
{
    [Table("Projectos")]
    public class ProjectModel
    {
        public ProjectModel(string name, string description, string telephoneNumber1, string email, string address)
        {
            Name = name;
            Description = description;
            PhoneNum = telephoneNumber1;
            Email = email;
            Adress = address;
        }

        public ProjectModel()
        {

        }

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
