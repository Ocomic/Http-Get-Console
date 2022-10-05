public class Rootobject
{
    public Mail[] mail { get; set; }
        public Attachment[] attachments { get; set; }
    }

    public class Mail
    {
        public string subject { get; set; }
        public string content { get; set; }
        public string contentType { get; set; }
    }

    public class Attachment
    {
        public string fileName { get; set; }
        public string contentType { get; set; }
        public int fileSize { get; set; }
        public string contentPartId { get; set; }
       

    }




