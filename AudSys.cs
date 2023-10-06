using UnityEngine;
using UnityEngine.UI;

// written by witnn
public class AudSys : MonoBehaviour
{
     private Text volumeAmount;
     private Slider slider;

    

    public void SetAudio(float value)
    {
        AudioListener.volume = value;
        volumeAmount.text = ((int)(value * 100)).ToString();
        SaveAudio();
    }

    private void SaveAudio()
    {
        PlayerPrefs.SetFloat("audioVolume", AudioListener.volume);
    }

    
}
