using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [HideInInspector]
    public GameObject car;
    public GameObject pauseMenu;
    int x = 0;
    
    void Start()
    {
        car = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(x==0)
            {

                car.GetComponent<UnityStandardAssets.Vehicles.Car.CarAudio>().lowPitchMax = 0;
                car.GetComponent<UnityStandardAssets.Vehicles.Car.CarAudio>().lowPitchMin = 0;
                Time.timeScale = 0;
                x = 1;
                pauseMenu.SetActive(true);
            }else if(x==1)
            {
                Resume();
            }
        }
        
    }
    public void Resume()
    {
        car.GetComponent<UnityStandardAssets.Vehicles.Car.CarAudio>().lowPitchMax = 1;
        car.GetComponent<UnityStandardAssets.Vehicles.Car.CarAudio>().lowPitchMin = 1;
        Time.timeScale = 1;
        x = 0;
        pauseMenu.SetActive(false);
    }
}
