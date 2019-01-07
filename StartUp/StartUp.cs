using System;
using StartUp.Core.Engine;
using StartUp.Core.Engine.Contract;

namespace StartUp
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
