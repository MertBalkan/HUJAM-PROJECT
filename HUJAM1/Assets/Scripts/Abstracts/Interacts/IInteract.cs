namespace HUJAM1.Abstracts.Interacts
{
    public interface IInteract
    {
        bool CanInteract { get; }
        void InteractWithObject();
    }
}