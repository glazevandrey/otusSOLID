namespace otusSOLID.Interfaces
{
    public abstract class BaseSettings
    {
        public int AttempsCount { get; protected set; }
        public int MinNumber { get; protected set; }
        public int MaxNumber { get; protected set; }

        public BaseSettings(int attempsCount, int minNumber, int maxNumber)
        {
            AttempsCount = attempsCount;
            MinNumber = minNumber;
            MaxNumber = maxNumber;
        }

        public abstract void ChangeSettings(int attempsCount, int minNumber, int maxNumber);
    }
}