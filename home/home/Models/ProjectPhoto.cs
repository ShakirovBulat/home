using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace home.Models
{
    [Table("Photo")]
    public class ProjectPhoto
    {
        public ProjectPhoto()
        {
        }

        public ProjectPhoto(string name, string image)
        {
            Name = name;
            Imagepath = image;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Imagepath { get; set; }
    }
}
