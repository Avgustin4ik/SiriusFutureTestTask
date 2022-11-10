using System;
using Entitas;
namespace Game
{
    [Game]
    public sealed class QuizRulesComponent : IComponent
    {
        
    }

    [Game]
    public sealed class RiddleWordComponent : IComponent
    {
        public string value;
    }

    [Game]
    public sealed class RiddleWordsDatabaseComponent : IComponent
    {
        public String[] value;
    }    
}