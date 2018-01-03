using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    interface IFriendDetailViewModel
    {
        Task LoadAsync(int friendId);
    }
}