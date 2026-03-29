namespace APBD_Cw1_s28135.Models;

public class Projector(int id, string name, string resolution) : Equipment(id, name)
{
    public string Resolution { get; } = resolution;

    public override string ToString() => $"Projektor: {base.ToString()}, Rozdzielczość: {Resolution}";
}