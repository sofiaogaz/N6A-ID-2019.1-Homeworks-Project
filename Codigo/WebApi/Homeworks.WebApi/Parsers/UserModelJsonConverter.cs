using System;
using Homeworks.WebApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Homeworks.WebApi.Parsers
{
    public class UserModelJsonConverter : JsonCreationConverter<UserModel>
    {
        protected override UserModel Create(Type objectType, JObject jObject)
        {
            if (jObject == null) 
            {
                throw new ArgumentNullException("jObject");
            }
            if (jObject["StudentId"] != null)
            {
                return new StudentModel();
            }
            if (jObject["TeacherId"] != null)
            {
                return new TeacherModel();
            }
            return new UserModel();
        }
    }
}