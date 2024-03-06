using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savec
{
    public string Name { get; private set; }
    public Rigidbody AnimalBody { get; private set; }
    public static string Status = "life";

    public Savec(string name, Rigidbody animal)
    {
        Name = name;
        AnimalBody = animal;
    }

    public virtual void GrowFur()
    {
        Debug.Log("GrowFur");
    }
}

public class Cats : Animal
{
    public float Speed { get; set; }
    public Vector3 Vector { get; set; }

    public Cats(string name, Rigidbody animal, float speed, Vector3 vector) : base(name, animal)
    {
        Speed = speed;
        Vector = vector;
    }

    public override void GrowFur()
    {
        Debug.Log("Meon");
    }

    public void GrowFur(string name)
    {
        Debug.Log("Meon " + name);
    }
}

