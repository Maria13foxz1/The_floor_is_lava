using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        Rigidbody redball;
        float speed;

        public PlayerMovement(Rigidbody rb)
        {
            redball = rb;
        }

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void PlayerMove(Vector3 direction)
        {
            Vector3 movement = direction * speed * Time.deltaTime;//deltaTime - це переміщення включно зі швидкістю і таким іншим
            redball.MovePosition(redball.transform.position + movement);
        }

        public void PlayerJump()
        {
            float jumpForce = 10f; 
            redball.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        public void PlayerStop()
        {
            redball.velocity = new Vector3(0f, redball.velocity.y, 0f);
        }
    }
}
