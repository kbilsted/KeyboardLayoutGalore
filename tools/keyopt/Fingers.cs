[Flags]
enum Fingers : ushort
{
    LPinky = 1,
    LRing = 2,
    LLong = 4,
    LIndex = 8,
    RPinky = 16,
    RRing = 32,
    RLong = 64,
    RIndex = 128,
    Pinky = LPinky | RPinky,
    Index = LIndex | RIndex,
    Ring = LRing | RRing,
}