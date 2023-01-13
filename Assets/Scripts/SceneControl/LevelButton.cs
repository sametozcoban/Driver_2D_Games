using System.Collections;
using System.Collections.Generic;
using Driver.SceneControl;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] Button[] _buttons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelButtonInteractable();
    }

    private void LevelButtonInteractable()
    {
        if (Button_Scene.level2)
        {
            _buttons[1].interactable = true;
        }

        if (Button_Scene.level3)
        {
            _buttons[2].interactable = true;
        }
        if (Button_Scene.level4)
        {
            _buttons[3].interactable = true;
        }
        if (Button_Scene.level5)
        {
            _buttons[4].interactable = true;
        }
        if (Button_Scene.level6)
        {
            _buttons[5].interactable = true;
        }
        

        if (Button_Scene.gameFinished)
        {
            _buttons[1].interactable = false;
            _buttons[2].interactable = false;
            _buttons[3].interactable = false;
            _buttons[4].interactable = false;
            _buttons[5].interactable = false;
        }
    }
}
