using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Debugging
    {


        public Debugging()
        {
            var friends = new List<string> { "Frank", "Mike", "Munir", "Christian", "Deon", "Christine", "Christopher" };
            var partyFriends = GetPartyFriends(friends, 4);

            foreach(var name in partyFriends)
            {
                Console.WriteLine(name);
            }
        }

        private List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while(partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                if(list.Count>0)
                {
                    list.Remove(currentFriend);
                }
                
            }

            return partyFriends;
        }

        public string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }

    }
}
