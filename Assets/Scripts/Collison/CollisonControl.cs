using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Driver.Collison
{
    public class CollisonControl : MonoBehaviour
    {
        //[SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
        //[SerializeField] private Color32 noHasPackageColor = new Color32(1, 1, 1, 1);

        [SerializeField] GameObject[] package;
        [SerializeField] float destroyTime = 0.5f;
        [SerializeField] int deliveredPackage = 0;
        
        bool hasPackage;
        public static bool isFinished;
        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            FinishGame();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        private void FinishGame()
        {
            if (deliveredPackage == package.Length)
            {
                Debug.Log("Application finished");
                isFinished = true;
            }
        }

        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "Obstacle")
            {
                Debug.Log("Ouch");
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Package" && !hasPackage)
            {
                Debug.Log("Package picked up");
                hasPackage = true;
                Destroy(col.gameObject, destroyTime);
                _spriteRenderer.color = Color.yellow;
                
                //_spriteRenderer.color = hasPackageColor;
                //gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            }
            
            if (col.tag == "Customer" && hasPackage)
            {
                Debug.Log("Delivered package ");
                _spriteRenderer.color = Color.white;
                hasPackage = false;
                deliveredPackage += 1;

                //_spriteRenderer.color = noHasPackageColor;
                //gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }
}