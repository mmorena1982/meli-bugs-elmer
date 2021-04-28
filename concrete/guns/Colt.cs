class Colt : Gun
{
    protected override string Model { get; }
    protected override int GunDamage => 100;
    protected int Calibre { get; }
    public Colt(string model, int calibre)
    {
        Model = model;
        Calibre = calibre;
        base.SetDamage(GunDamage);
    }
}