using System;
using StartUp.Core.Engine;
using StartUp.Core.Engine.Contract;

namespace VotingLocalMunicipality
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
