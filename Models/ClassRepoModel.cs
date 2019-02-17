using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HackSU.Models
{
    public class ClassRepoModel
    {
        private static List<ClassesModel> responsecs = new List<ClassesModel>();

        public ClassRepoModel()
        {
            ClassRepoModel.AddResponse(new ClassesModel("Class1"));
            ClassRepoModel.AddResponse(new ClassesModel("Class2"));
            ClassRepoModel.AddResponse(new ClassesModel("Class3"));
            ClassRepoModel.AddResponse(new ClassesModel("Class4"));
            ClassRepoModel.AddResponse(new ClassesModel("Class5"));
        }


        public static IEnumerable<ClassesModel> Responses
        {
            get
            {
                return responsecs;
            }
        }

        public static void AddResponse(ClassesModel response)
        {
            responsecs.Add(response);
        }
    }
}
