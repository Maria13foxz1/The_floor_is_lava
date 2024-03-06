using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public string targetTag; // «бер≥гаЇмо тег ц≥льового об'Їкта
    public AudioSource audioSource; 

    void OnCollisionEnter(Collision collision)
    {
        // ѕерев≥р€Їмо, чи тег з≥ткненого об'Їкта сп≥впадаЇ з ц≥льовим тегом
        if (collision.gameObject.CompareTag(targetTag))
        {
            audioSource.Play();
            // якщо кол≥з≥€ в≥дбуваЇтьс€ з об'Їктом з вибраним тегом, знищте цей об'Їкт
            Destroy(gameObject);
        }
    }
}
