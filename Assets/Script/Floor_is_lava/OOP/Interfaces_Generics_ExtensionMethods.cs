using UnityEngine;
using System;
using System.Collections.Generic;

// Інтерфейс для звуків
public interface ISound
{
    void MakeSound();
}

// Клас для тварин
public class Animels : ISound
{
    public void MakeSound()
    {
        Debug.Log("Animels sound");
    }
}

// Клас для транспортних засобів
public class Vehicle : ISound
{
    public void MakeSound()
    {
        Debug.Log("Vehicle sound");
    }
}

// Універсальний клас для зберігання колекцій різних типів об'єктів, які реалізують ISound
public class SoundCollection<T> : IEnumerable<T> where T : ISound
{
    private List<T> sounds = new List<T>();

    public void AddSound(T sound)
    {
        sounds.Add(sound);
    }

    public void PlayAllSounds()
    {
        foreach (var sound in sounds)
        {
            sound.MakeSound();
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return sounds.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Розширений метод для виведення звуків, які зберігаються в колекції
public static class SoundCollectionExtensions
{
    public static void PrintSounds<T>(this SoundCollection<T> collection) where T : ISound
    {
        foreach (var sound in collection)
        {
            sound.MakeSound();
        }
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {
        // Створення колекції звуків тварин
        var animalSounds = new SoundCollection<Animels>();
        animalSounds.AddSound(new Animels());
        animalSounds.AddSound(new Animels());

        // Створення колекції звуків транспортних засобів
        var vehicleSounds = new SoundCollection<Vehicle>();
        vehicleSounds.AddSound(new Vehicle());
        vehicleSounds.AddSound(new Vehicle());

        // Відтворення всіх звуків
        animalSounds.PlayAllSounds();
        vehicleSounds.PlayAllSounds();

        // Виведення всіх звуків
        animalSounds.PrintSounds();
        vehicleSounds.PrintSounds();
    }
}
