using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Relógio : MonoBehaviour
{
    private int countdownDays = 0;
    private int halfdays = 0;
    private Thread t = null;
    private float speed = 1.0;

    static void NovaThread(Relógio relogio)
    {
        int min = 0;
        while (relogio.halfdays > 0)
        {
            min = (relogio.halfdays % 2) == 0 ? 2 : 1;
            Thread.Sleep(1000*60*min/relogio.speed);
            relogio.halfdays--;
        }
    }

    public Relógio(int countdownDays)
    {
        halfdays = 2*countdownDays;
        this.countdownDays = countdownDays;
        t = new Thread(NovaThread,this); 
        t.Start();
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

