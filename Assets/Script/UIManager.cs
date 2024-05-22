using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    public int healthValue;
    public float poisonTime;
    public bool poisoned;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = healthValue.ToString();
    }

    public void PlayerDamage()
    {
        healthValue -= 5;
    }

    public void poisonCountdown()
    {
        InvokeRepeating("PlayerPoisoned", 1f, 1f);
    }

    public void PlayerPoisoned()
    {
        if (healthValue > 0) { 
            if (poisonTime > 0)
            {
                poisoned = true;
                poisonTime -= 1;
                healthValue -= 1;
            }
            if (poisonTime == 0) {
                poisoned = false;
            }
        }
        
    }
}
