namespace HUJAM1.Abstracts.Animations
{
    public interface IAnimation
    {
        void WalkAnimation(float horDirection, float verDirection);
        void IsRunning(bool run);
    }
}