using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    List<Animal> animals;

    void Start()
    {
        animals = new List<Animal> { new Bird(), new Dog(), new Elephant() };
        foreach (Animal a in animals)
        {
            a.Eat();
            a.Move();
        }
    }

    /*  
        Maak nu zelf de volgende classes:

        Zoo : MonoBehariour
        Animal
        Bird
        Dog
        Elephant
        
        Welke van deze is de abstracte class? Animal

        Maak een abstracte methode in de Abstracte class die Move heet. Deze mag geen implementatie hebben.

        Geef alle dieren een eigen implementatie van de Move methode. Bijvoorbeeld: Debug.Log("Flaps it's wings")

        Maak in de abstracte class ook een methode Eat die je de volgende implementatie geeft : Debug.Log("Njam Njam");

        Maak in de Zoo class alle dieren aan en zet ze in een List of Array die animals heet.

        Roep met een loop voor alle dieren de methode Eat en Move aan.

        Test je code door Zoo.cs aan de camera te hangen in unity.
    */
}
