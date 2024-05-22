using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrafficSimulator : MonoBehaviour
{
    public GameObject[] lights;
    public int activeLight;
    public TextMeshProUGUI timerText;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        LightChanger();
        ChangingLights();
    }

    // Update is called once per frame
    void Update()
    {
        timer -=Time.deltaTime;
        LightChanger();
        timerText.text = timer.ToString();
    }

    public void LightChanger()
    {
        for(int i = 0; i < lights.Length; i++) 
        {
            lights[i].SetActive(i == activeLight);
        }
    }

    IEnumerator ChangingLights()
    {
        yield return new WaitForSeconds(10f);
        ColorRed();
        yield return new WaitForSeconds(4.5f);
        ColorOrange();
        yield return new WaitForSeconds(5f);
        ColorGreen();
    }

    public void ColorRed()
    {
        activeLight = 0;
    }

    public void ColorOrange()
    {
        activeLight = 1;
    }

    public void ColorGreen()
    {
        activeLight = 2;
    }


}
