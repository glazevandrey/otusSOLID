using otusSOLID.Interfaces;

namespace otusSOLID.Implementations
{
    public class GeneratorSettings : BaseSettings
    { 
        public GeneratorSettings(int attempsCount, int minNumber, int maxNumber) : base(attempsCount, minNumber, maxNumber)
        {
        }

        public override void ChangeSettings(int attempsCount, int minNumber, int maxNumber)
        {
            AttempsCount = attempsCount;
            MinNumber = minNumber;
            MaxNumber = maxNumber;
        }
    }
}