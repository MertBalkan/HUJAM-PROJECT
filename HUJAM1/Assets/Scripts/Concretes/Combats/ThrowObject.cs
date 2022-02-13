namespace HUJAM1.Concretes.Combats
{
    /// <summary>
    /// Throw class will be only avaible for monkey character
    /// </summary>
    public class ThrowObject
    {
        private bool _canTubeThrowable;

        public bool CanTubeThrowable { get => _canTubeThrowable; set => _canTubeThrowable = value; }
    }
}