using System;

namespace Core.DeveloperConsole.Scripts.Common
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class ConsoleCommandAttribute : Attribute
    {

        public readonly string name, description;
        public readonly bool PrefixOnly;

        public ConsoleCommandAttribute(string name, string description, bool prefixOnly = false)
        {
            this.name = name;
            this.description = description;
            this.PrefixOnly = prefixOnly;
        }

        public ConsoleCommandAttribute(string name, bool prefixOnly = false)
        {
            this.name = name;
            this.description = "no description";
            this.PrefixOnly = prefixOnly;
        }
    }


    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ConsoleParseAttribute : Attribute
    {
    }
}


