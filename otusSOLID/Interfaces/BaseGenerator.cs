using otusSOLID.Implementations;

namespace otusSOLID.Interfaces
{
    public abstract class BaseGenerator
    {
        public BaseSettings GeneratorSettings { get; private set; }
        public abstract int GetRandomNumber();

        public BaseGenerator(BaseSettings settings)
        {
                GeneratorSettings = settings;
        }

    }
}