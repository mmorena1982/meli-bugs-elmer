class Duck : Animal
{
    protected override int MinAge => 1;

    protected override int MaxAge => 5;

    protected override int MinHeight => 20;

    protected override int MaxHeight => 40;

    protected override int MinWeight => 1;

    protected override int MaxWeight => 4;

    protected override int MaxHealth => 50;

    public Duck(int age, int weight, int height) : base(age, weight, height){
        base.Health = CalculateHealth(MaxHealth);
    }

    public Duck() : base (){
        base.Age = GenerateAge(MinAge, MaxAge);
        base.Height = GenerateHeight(MinHeight, MaxHeight);
        base.Weight = GenerateWeight(MinWeight, MaxWeight);
    }
}