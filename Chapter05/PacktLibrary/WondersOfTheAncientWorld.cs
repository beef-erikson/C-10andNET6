namespace Packt.Shared
{
    // Note we are using System.Flags here so when value is returned, it can
    // automatically match with multiple values as a comma-separated string instead of returning
    // an int.
    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {
        None = 0b_0000_0000, // 0
        GreatPyramidsOfGiza = 0b_0000_0001, // 1
        HangingGardensOfBabylon = 0b_0000_0010, // 2
        StatueOfZeusAtOlympia = 0b_0000_0100, // 4
        TempleOfArtemisAtEphesus = 0b_0000_1000, // 8
        MausoleumAtHalicarnassus = 0b_0001_0000, // 16
        ColossusOfRhodes = 0b_0010_0000, // 32
        LighthouseOfAlexandria = 0b_0010_0000  // 64
    }
}