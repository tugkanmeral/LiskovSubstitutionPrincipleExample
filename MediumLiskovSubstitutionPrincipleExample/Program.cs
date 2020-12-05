using CorrectApproach;
using System;
using System.Collections.Generic;
using WrongApproach;

namespace MediumLiskovSubstitutionPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WrongApproachRunner.Run();
            CorrectApproachRunner.Run();
        }
    }
}
