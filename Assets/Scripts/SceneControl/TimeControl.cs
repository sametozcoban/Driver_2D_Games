using UnityEngine;
using UnityEngine.UI;
using Driver.Collison;

namespace Driver.SceneControl
{
    public class TimeControl : MonoBehaviour
    {
        public Slider _timeSlider;

        public void maxTime(float time)
        {
            _timeSlider.maxValue = time;
            _timeSlider.value = time;
        }
        
        public void timeSlider(float time)
        {
            _timeSlider.value = time;
        }
        
    }
    
   
}