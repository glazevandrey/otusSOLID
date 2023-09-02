using otusSOLID.Implementations;

namespace otusSOLID.Interfaces
{
    public abstract class BaseGenerator
    {
        public BaseSettings GeneratorSettings { get; private set; }

        public BaseGenerator(BaseSettings settings)
        {
                GeneratorSettings = settings;
        }

        public abstract int GetRandomNumber();


    }
}