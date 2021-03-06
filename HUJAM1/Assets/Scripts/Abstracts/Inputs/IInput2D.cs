namespace HUJAM1.Abstracts.Inputs
{
    public interface IInput2D
    {
        float HorizontalMove { get; }
        float VerticalMove { get; }
        float MouseAxisX { get; }
        float MouseAxisY { get; }
        bool PressRunButton { get; }
        bool ReleaseRunButton { get; }
        bool InteractButton { get; }
        bool ThrowTube { get; }
    }
}