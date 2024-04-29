using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class Animal
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal sound");
    }
}

[System.Serializable]
public class Mammal : Animal
{
    public override void MakeSound()
    {
        Debug.Log("Mammal sound");
    }
}

[System.Serializable]
public class Cat : Mammal
{
    public override void MakeSound()
    {
        Debug.Log("Meow");
    }
}

[System.Serializable]
public class Dog : Mammal
{
    public override void MakeSound()
    {
        Debug.Log("Woof");
    }
}

public class Polymorphism_and_casting : MonoBehaviour
{
    void Start()
    {
        Animal[] animals = new Animal[3];
        animals[0] = new Animal();
        animals[1] = new Cat();
        animals[2] = new Dog();

        foreach (Animal animal in animals)
        {
            animal.MakeSound();

            if (animal is Mammal)
            {
                Mammal mammal = (Mammal)animal;
                mammal.MakeSound();
            }

            if (animal is Cat)
            {
                Cat cat = animal as Cat;
                cat.MakeSound();
            }

            if (animal is Dog)
            {
                Dog dog = animal as Dog;
                dog.MakeSound();
            }
        }
    }
}

