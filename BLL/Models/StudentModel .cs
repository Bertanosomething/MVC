using BLL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Entity { get; set; }
        public int Id => Entity.Id;
        public string Name => Entity.Name;
        public string Surname => Entity.Surname;
        public DateTime? Birthdate => Entity.BirthDate;
        public decimal? Gpa => Entity.Gpa;

    }
}
