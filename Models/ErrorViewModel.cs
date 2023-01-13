namespace WebPrueba.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    public int Todo { get; set; }
    public int MyProperty { get; set; }
    public int Dotko { get; set; }
}
