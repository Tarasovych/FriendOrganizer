using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: db
            yield return new Friend { FirstName = "name1", LastName = "last1" };
            yield return new Friend { FirstName = "name2", LastName = "last2" };
            yield return new Friend { FirstName = "name3", LastName = "last3" };
            yield return new Friend { FirstName = "name4", LastName = "last4" };
            yield return new Friend { FirstName = "name5", LastName = "last5" };
        }
    }
}
