namespace APBD_Cw1_s28135.Models;

public class Laptop(int id, string name, string processor, int ramSize) : Equipment(id, name)
{
    public string Processor { get; } = processor;
    public int RamSize { get; } = ramSize;

    public override string ToString() => $"Laptop: {base.ToString()}, RAM: {RamSize}GB, CPU: {Processor}";
}