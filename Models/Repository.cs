using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackSU.Models
{
    public class Repository
    {
        private static List<GuestResponsecs> responsecs = new List<GuestResponsecs>();

        public static IEnumerable<GuestResponsecs> Responses
        {
            get
            {
                return responsecs;
            }
        }

        public static void AddResponse(GuestResponsecs response)
        {
            responsecs.Add(response);
        }
    }
}
