using System;

abstract class Animal  {
    protected abstract int MinAge { get; }
    protected abstract int MaxAge { get; }    
    protected abstract int MinHeight { get; }
    protected abstract int MaxHeight { get; }
    protected abstract int MinWeight { get; }
    protected abstract int MaxWeight { get; }
    protected abstract int MaxHealth { get; }
    protected int Age { get; set; }
    protected int Weight { get; set; }
    protected int Height { get; set; }
    protected int Health {get; set; }

    protected int CalculateHealth(int maxHealth){
        int calculatedHealth = (int)(Age * 0.1 + Height * 0.1 + Weight * 0.9);
        return calculatedHealth < maxHealth ? calculatedHealth : MaxHealth;
    }

    protected int GenerateHeight(int min, int max) {
        Random rnd = new Random();
        return rnd.Next(min, max);
    }

    protected int GenerateWeight(int min, int max){
        Random rnd = new Random();
        return rnd.Next(min, max);
    }

    protected int GenerateAge(int min, int max){
        Random rnd = new Random();
        return rnd.Next(min, max);
    }
    public Animal() {
        
    }
    public Animal (int age, int weight, int height) {
        Age = age;
        Weight = weight;
        Height = height;
    }

    internal void DecreaseHealth(int damage) {
        Health -= damage;        
    }

    public bool IsAlive() {
        return Health > 0;
    }
}