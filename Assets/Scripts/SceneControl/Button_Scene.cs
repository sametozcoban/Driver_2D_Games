using System;
using System.Collections;
using System.Collections.Generic;
using Driver.Collison;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Driver.SceneControl
{
    public class Button_Scene : MonoBehaviour
    {
        [SerializeField] Image finishImage;
        [SerializeField] public int sceneIndex;

        public static bool textControl,level2, level3, level4, level5, level6, restartLevel, gameFinished;
        
        private void Update()
        {
            GameFinish();
        }

        public void RestartLevel()
        {
            SceneManager.LoadScene(sceneIndex);
            restartLevel = true;
        }
        
        public void MainMenuToLevels()
        {
            SceneManager.LoadScene("Levels");
            textControl = true;
        }

        public void Game1ToLevelSelect()
        {
            if (Time.gameOver)
            {
                level2 = false;
                SceneManager.LoadScene("Levels");
            }
            else if (!Time.gameOver)
            {
                SceneManager.LoadScene("Levels");
                level2 = true;
            }
        }

        public void Game2ToLevelSelect()
        {
            if (Time.gameOver)
            {
                level3 = false;
                SceneManager.LoadScene("Levels");
            }
            else if (!Time.gameOver)
            {
                SceneManager.LoadScene("Levels");
                level3 = true;
            }
        }

        public void Game3ToMainMenu()
        {
            if (Time.gameOver)
            {
                level4 = false;
                SceneManager.LoadScene("Levels");
            }
            else if (!Time.gameOver)
            {
                SceneManager.LoadScene("Levels");
                level4 = true;
            }
        }
        
        public void Game4ToMainMenu()
        {
            if (Time.gameOver)
            {
                level5 = false;
                SceneManager.LoadScene("Levels");
            }
            else if (!Time.gameOver)
            {
                SceneManager.LoadScene("Levels");
                level5 = true;
            }
        }
        
        public void Game5ToMainMenu()
        {
            if (Time.gameOver)
            {
                level6 = false;
                SceneManager.LoadScene("Levels");
            }
            else if (!Time.gameOver)
            {
                SceneManager.LoadScene("Levels");
                level6 = true;
            }
        }
        
        public void Game6ToMainMenu()
        {
            
            if (Time.gameOver)
            {
                SceneManager.LoadScene("Levels");
                gameFinished = false;
            }
            else if (!Time.gameOver)
            {
                SceneManager.LoadScene("EnterGame");
                gameFinished = true;
            }
        }

        public void LevelSelectToLevel1()
        {
            SceneManager.LoadScene("Level1");
            CollisonControl.isFinished = false;
        }

        public void LevelSelectToLevel2()
        {
            SceneManager.LoadScene("Level2");
            CollisonControl.isFinished = false;
        }

        public void LevelSelectToLevel3()
        {
            SceneManager.LoadScene("Level3");
            CollisonControl.isFinished = false;
        }
        
        public void LevelSelectToLevel4()
        {
            SceneManager.LoadScene("Level4");
            CollisonControl.isFinished = false;
        }
        
        public void LevelSelectToLevel5()
        {
            SceneManager.LoadScene("Level5");
            CollisonControl.isFinished = false;
        }
        
        public void LevelSelectToLevel6()
        {
            SceneManager.LoadScene("Level6");
            CollisonControl.isFinished = false;
        }
        
        public void GameFinish()
        {
            if (CollisonControl.isFinished)
            {
                finishImage.gameObject.SetActive(true);
            }
        }
        
    }

}