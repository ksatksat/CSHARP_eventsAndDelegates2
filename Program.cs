using System;
using static System.Console;
delegate string DoAction(string action);
class Program{
    static string Attack(string attackType){
        return $"I am attacking with {attackType}";
    }
    static string Defend(string defenceType){
        return $"I am defending with {defenceType}";
    }
    static void Main(string[] args){
        DoAction action = Attack;
        WriteLine(action("shooting"));
        action = Defend;
        WriteLine(action("building walls"));
        action = working => { return $"I am working by doing {working}"; };
        WriteLine(action("farming"));
    }
}