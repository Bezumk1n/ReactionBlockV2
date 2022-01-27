using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ReactionBlockV2.Models
{
    public class NotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
