using Bogus;
using Odx.Demo.MultipleEvents.Common.Model;

namespace Odx.Demo.MultipleEvents.App
{
    internal static class RandomContactGenerator
    {
        internal static Contact Get()
        {
            var person = new Person();

            return new Contact
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                odx_nextcontactdate = GetRandomDate()
            };
        }
        private static DateTime GetRandomDate()
        {
            Random rand = new Random();
            DateTime baseDate = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - baseDate).Days;
            return baseDate.AddDays(rand.Next(range));
        }
    }
}
