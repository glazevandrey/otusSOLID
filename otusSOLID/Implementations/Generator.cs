using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otusSOLID.Interfaces;

namespace otusSOLID.Implementations
{
    public class Generator : BaseGenerator
    {
        public Generator(BaseSettings settings) :base(settings)
        {
        }

        public override int GetRandomNumber()
        {
            Random r = new Random();

            return r.Next(GeneratorSettings.MinNumber, GeneratorSettings.MaxNumber);
        }
    }
}
