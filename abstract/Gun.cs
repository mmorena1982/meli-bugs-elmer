using System;
abstract class Gun {

    protected abstract string Model { get; }

    protected abstract int GunDamage { get; }

    protected int Damage { get; set; }

    protected void SetDamage(int damage) {
        Damage = damage;
    }

    public int GetDamage() {
        return Damage;
    }
    

    public Gun(){
    }

    public override string ToString()
    {
        return $"Damage = {GunDamage}";
    }   
}