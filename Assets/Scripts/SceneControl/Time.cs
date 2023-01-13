using System;
using System.Collections;
using Driver.Collison;
using UnityEngine;
using UnityEngine.UI;

namespace Driver.SceneControl
{
    public class Time : MonoBehaviour
    {
        [SerializeField] public Image _gameOver;
        public float maxTime = 30;
        public float currentTime;

        public TimeControl TimeControl;
        public static bool gameOver;
        void Start()
        {
            currentTime = maxTime;
            TimeControl.maxTime(maxTime);
            if (Button_Scene.restartLevel)
            {
                _gameOver.gameObject.SetActive(false);
                CollisonControl.isFinished = false;
            }
        }

        private void Update()
        {
            StartCoroutine(TakeTime(1f * UnityEngine.Time.deltaTime));
            if (gameOver || CollisonControl.isFinished)
            {
                StopCoroutine(TakeTime(0));
            }
            
        }
        
        IEnumerator TakeTime(float  time)
        {
            if (!CollisonControl.isFinished)
            {
                currentTime -= time ;
            
                if (currentTime < 0)
                {
                    _gameOver.gameObject.SetActive(true);
                    CollisonControl.isFinished = false;
                    gameOver = true;
                }
                TimeControl.timeSlider(currentTime);
                yield return new WaitForSeconds(maxTime);
            }
            
        }
    }
}