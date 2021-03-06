namespace HeadfulBrowserAudioVideoCapturingService;

public class StartRecordingSettings
{
    public bool Video => true;

    public bool Audio => true;

    public int TimeSliceMs => 1000;

    public string MimeType => $"video/webm;codecs=\"{Constants.VideoEncoder},{Constants.AudioEncoder}\"";

    public VideoConstraints VideoConstraints => new();
}
