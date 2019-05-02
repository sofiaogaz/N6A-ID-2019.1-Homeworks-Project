using System;
using System.Collections.Generic;
using System.Linq;
using Homeworks.Domain;

namespace Homeworks.WebApi.Models
{
    public class StudentModel : UserModel
    {
        public string StudentId { get; set; }
    }
}