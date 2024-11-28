using CommandLine;

namespace Command_Line_Parser;

[Verb("Chien", HelpText = "Affecter les valeurs pour la classe « Chien »")]
public sealed class Chien : Command
{
    [Option('T', "Taille", Required = false, HelpText = "Taille du chien")]
    public int Taille { get; set; }

    [Option('A', "Age", Required = false, HelpText = "Age du chien")]
    public int Age { get; set; }
}