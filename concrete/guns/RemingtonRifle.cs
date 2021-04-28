class RemingtonRifle : Gun
{
    protected override string Model { get; }
    protected override int GunDamage => 200;
    protected int Calibre { get; }
    public RemingtonRifle(string model, int calibre)
    {
        Model = model;
        Calibre = calibre;
        base.SetDamage(GunDamage);
    }
}