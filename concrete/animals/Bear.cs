using System;

class Bear : Animal
{
    protected override int MinAge => 1;//years

    protected override int MaxAge => 30;//years

    protected override int MinHeight => 70;//centimeters

    protected override int MaxHeight => 240;//centimeters

    protected override int MinWeight => 70;//kilograms

    protected override int MaxWeight => 450;//kilograms

    protected override int MaxHealth => 800;

    public Bear(int age, int weight, int height) : base(age, weight, height){
        base.Health = CalculateHealth(MaxHealth);
    }

    public Bear() {
        base.Age = GenerateAge(MinAge, MaxAge);
        base.Height = GenerateHeight(MinHeight, MaxHeight);
        base.Weight = GenerateWeight(MinWeight, MaxWeight);
        base.Health = CalculateHealth(MaxHealth);
    }
}