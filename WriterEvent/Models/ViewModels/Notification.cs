using WriterEvent.Enums;

namespace WriterEvent.Models.ViewModels
{
    public class Notification
    {
        public string Message { get; set; }

        public NotifType Type { get; set; }
    }
}
