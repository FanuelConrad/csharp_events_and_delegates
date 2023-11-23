using csharp_events_and_delegates;

public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("MailService: Sending an email..."+e.Video.Title);
        }
    }