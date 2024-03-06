using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals
{
    public void MakeSound()
    {
        Debug.Log("Animals sound");
    }

    public void MakeSound(string sound)
    {
        Debug.Log(sound);
    }
}

public class Predator : Animals
{
    public new void MakeSound()
    {
        Debug.Log("Predator sound");
    }
}

public class Herbivore : Animals
{
    public new void MakeSound()
    {
        Debug.Log("Herbivore sound");
    }
}

public class Lion : Predator
{
    public new void MakeSound()
    {
        Debug.Log("Lion sound");
    }
}

public class Deer : Herbivore
{
    public new void MakeSound()
    {
        Debug.Log("Deer sound");
    }
}

public class AnimalsWorld : MonoBehaviour
{
    void Start()
    {
        Animals Animals = new Animals();
        Animals predator = new Predator();
        Animals herbivore = new Herbivore();
        Animals lion = new Lion();
        Animals deer = new Deer();

        Animals.MakeSound();             // Output: Animals sound
        Animals.MakeSound("Roar!");      // Output: Roar!
        predator.MakeSound();           // Output: Predator sound
        herbivore.MakeSound();          // Output: Herbivore sound
        lion.MakeSound();               // Output: Lion sound
        deer.MakeSound();               // Output: Deer sound
    }
}


