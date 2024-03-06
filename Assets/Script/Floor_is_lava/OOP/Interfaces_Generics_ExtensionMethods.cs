using UnityEngine;
using System;
using System.Collections.Generic;

// ��������� ��� �����
public interface ISound
{
    void MakeSound();
}

// ���� ��� ������
public class Animels : ISound
{
    public void MakeSound()
    {
        Debug.Log("Animels sound");
    }
}

// ���� ��� ������������ ������
public class Vehicle : ISound
{
    public void MakeSound()
    {
        Debug.Log("Vehicle sound");
    }
}

// ������������ ���� ��� ��������� �������� ����� ���� ��'����, �� ��������� ISound
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

// ���������� ����� ��� ��������� �����, �� ����������� � ��������
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
        // ��������� �������� ����� ������
        var animalSounds = new SoundCollection<Animels>();
        animalSounds.AddSound(new Animels());
        animalSounds.AddSound(new Animels());

        // ��������� �������� ����� ������������ ������
        var vehicleSounds = new SoundCollection<Vehicle>();
        vehicleSounds.AddSound(new Vehicle());
        vehicleSounds.AddSound(new Vehicle());

        // ³��������� ��� �����
        animalSounds.PlayAllSounds();
        vehicleSounds.PlayAllSounds();

        // ��������� ��� �����
        animalSounds.PrintSounds();
        vehicleSounds.PrintSounds();
    }
}
