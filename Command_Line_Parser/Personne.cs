using CommandLine;

namespace Command_Line_Parser;

[Verb("Humain", HelpText = "Affecter les valeurs pour la classe « Personne »")]
public sealed class Personne : Command
{
    [Option('T', "Taille", Required = false, HelpText = "Taille de la personne")]
    public int Taille { get; set; }

    [Option('A', "Age", Required = false, HelpText = "Age de la personne")]
    public int Age { get; set; }
}