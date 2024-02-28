using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal { 
    public string name;
    public Rigidbody animal;
    public static string status = "life";

    public Animal(string name, Rigidbody animal)
    {
        this.name = name;
        this.animal = animal;
    }

    public virtual void GrowFur()
    {
        Debug.Log("GrowFur");
    }
}

public class Cat:Animal
{
    public float speed;
    public Vector3 vector;

    public Cat(string name, Rigidbody animal, float speed, Vector3 vector):base(name, animal)
    {
        this.name = name;
        this.animal = animal;
        this.speed = speed;
        this.vector = vector;
    }

    public override void GrowFur()
    {
        Debug.Log("Meon");
    }
    public void GrowFur(string name) {
        Debug.Log("Meon "+name);
    }
}
