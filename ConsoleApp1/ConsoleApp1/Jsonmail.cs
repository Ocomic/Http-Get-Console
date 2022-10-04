
public class Rootobject
{
    public string subject { get; set; }
    public string content { get; set; }
    public string contentType { get; set; }
    public Attachment[] attachments { get; set; }
}

public class Attachment
{
    public string fileName { get; set; }
    public string contentType { get; set; }
    public int fileSize { get; set; }
    public string contentPartId { get; set; }
}
