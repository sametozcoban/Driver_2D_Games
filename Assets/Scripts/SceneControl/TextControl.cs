using System;
using System.Collections;
using Driver.Collison;
using UnityEngine;
using UnityEngine.UI;

namespace Driver.SceneControl
{
    public class TextControl : MonoBehaviour
    {
        [SerializeField] Image textImage;
        public float delay = 0.1f;
        
        [Multiline]
        public string writing;
        
        Text _text;
        
        private void Awake()
        {
            if (CollisonControl.isFinished)
            {
                textImage.gameObject.SetActive(false);
            }
        }
        
        private void Start()
        {
            _text = GetComponent<Text>();
            if (Button_Scene.textControl)
            {
                textImage.gameObject.SetActive(true);
                StartCoroutine(Writing());
            }
        }

        IEnumerator Writing()
        {
            foreach (char i in writing)
            {
                _text.text += i.ToString();

                if (i.ToString() == ".")
                {
                    yield return new WaitForSeconds(1); 
                    
                }
                else
                {
                     yield return new WaitForSeconds(delay);
                }
            }
        }

        public void Continue()
        {
            textImage.gameObject.SetActive(false);
        }
    }
}