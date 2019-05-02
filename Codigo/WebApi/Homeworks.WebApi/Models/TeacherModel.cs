using System;
using System.Collections.Generic;
using System.Linq;
using Homeworks.Domain;

namespace Homeworks.WebApi.Models
{
    public class TeacherModel : UserModel
    {
        public string Course { get; set; }

        public string TeacherId { get; set; }
    }
}