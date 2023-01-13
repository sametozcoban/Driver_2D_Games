using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Driver.Movement
{
    public class Driver : MonoBehaviour
    {
        [SerializeField] float steerSpeed = 0.5f;
        [SerializeField] float moveSpeed = 0.01f;
        [SerializeField] float boostSpeed = 30f;
        [SerializeField] float bumpsSpeed = 15f;

        float boosterDestroyTime = 0.5f;
        float x;
        float y;
        // Start is called before the first frame update
        void Start()
        {
         
        }

        // Update is called once per frame
        void Update()
        {
            x = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
            y = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            Debug.Log(moveSpeed);
            transform.Rotate(0,0, -x);
            transform.Translate(0, y, 0);
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            moveSpeed = bumpsSpeed;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Booster")
            {
                moveSpeed = boostSpeed;
                
                Destroy(other.gameObject, boosterDestroyTime);
            }
        }
    }
}
