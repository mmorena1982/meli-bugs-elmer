class Crossbow : Gun
{
    protected override int GunDamage => 50;
    protected override string Model { get; }

    public Crossbow() {
        base.SetDamage(GunDamage);
    }
    public Crossbow(string model)
    {
        Model = model;
        base.SetDamage(GunDamage);
    }
}