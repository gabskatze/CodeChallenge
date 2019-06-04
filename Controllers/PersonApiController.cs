using CodeChallenge.Helpers;
using CodeChallenge.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CodeChallenge.Controllers
{
    public class PersonApiController : ApiController
    {
        //GET api/PersonApi
        public IEnumerable<Person> Get(string sort = null, string lastname = null)
        {
            var myList = PersonHelper.GetPeople();

            if(lastname != null)
            {
                myList = myList.Where(x => x.Lastname == lastname).OrderBy(x => x.Name).ToList();
            }

            if (sort == "ascending")
            {
                myList = myList.OrderBy(x => x.Lastname).ToList();
            }else if(sort == "descending")
            {
                myList = myList.OrderByDescending(x => x.Lastname).ToList();
            }
            return myList;
        }
    }
}