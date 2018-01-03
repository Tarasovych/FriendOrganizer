using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private IFriendDataService _dataService;

        public FriendDetailViewModel(IFriendDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task LoadAsync(int friendId)
        {
            Friend = await _dataService.GetByIdAsync(friendId);
        }

        private Friend _friend;

        public Friend Friend
        {
            get { return _friend; }
            private set
            {
                _friend = value;
                OnPropertyChanged();
            }
        }
    }
}
