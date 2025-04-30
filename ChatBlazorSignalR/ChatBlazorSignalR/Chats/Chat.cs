namespace ChatBlazorSignalR.Chats
{
    public class Chat
    {
        public string User { get; set; }
        public string Message { get; set; }
        public bool IsMe { get; set; } = false;

        public string Direction => IsMe ? "right" : "left";
        public DateTime Time { get; set; } = DateTime.Now;

    }
}
