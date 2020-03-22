using System.Collections;
using System.Collections.Generic;
using System.DateTime;
using UnityEngine;

public class Relógio : MonoBehaviour
{
    private int countdownDays = 0;
    private int halfdays = 0;
    private float speed = 1.0;
    private date now = null;

    static string start(Relógio relogio)
    {
        int min = 0;
        date milisecSleep = null;
        date them = null;
        
        while (relogio.halfdays > 0)
        {
        	now = DateTime.now;
            min = (relogio.halfdays % 2) == 0 ? 2 : 1;
            milisecSleep = (1000*60*min/relogio.speed);
            them = now+milisecSleep
            if (them<=now) {
            	relogio.halfdays--;
            }    
        }
    }

    public Relógio(int countdownDays)
    {
        halfdays = 2*countdownDays;
        this.countdownDays = countdownDays;
        
    }


    // Update is called once per frame
    public bool isDay()
    {

        return (halfdays % 2 == 0);
            
    }

    public int getRemainingDays()
    {
        return (halfdays / 2);
    }

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }


}

