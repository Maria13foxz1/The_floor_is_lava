using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public string targetTag; // �������� ��� ��������� ��'����
    public AudioSource audioSource; 

    void OnCollisionEnter(Collision collision)
    {
        // ����������, �� ��� ��������� ��'���� ������� � �������� �����
        if (collision.gameObject.CompareTag(targetTag))
        {
            audioSource.Play();
            // ���� ����� ���������� � ��'����� � �������� �����, ������ ��� ��'���
            Destroy(gameObject);
        }
    }
}
