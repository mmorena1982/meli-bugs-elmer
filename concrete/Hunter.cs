class Hunter {
    public Hunter() {}

    public void Shoot(Animal animal, Gun gun) {
        animal.DecreaseHealth(gun.GetDamage());
    }
}