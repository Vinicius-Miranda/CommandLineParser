using CommandLine;

namespace Command_Line_Parser;

public abstract class Command
{
    public readonly string VerbName;

    protected Command()
    {
        var verbDescription = GetType()
            .GetCustomAttributes(typeof(VerbAttribute), false)
            .FirstOrDefault() ?? throw new InvalidOperationException(
            $"L'attribut du type '{typeof(VerbAttribute).FullName}' est absent de la commande définie par le type'{GetType().FullName}'.");

        VerbName = ((VerbAttribute)verbDescription).Name;
    }

}