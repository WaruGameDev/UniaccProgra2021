using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    public int atk, def, agi;
    public enum JOBS
    {
        PALADIN, ARQUERO, MAGO
    }
    public JOBS jobs;
    // Start is called before the first frame update
    void Start()
    {
        switch (jobs)
        {
            case JOBS.ARQUERO:
                atk = 5;
                def = 2;
                agi = 7;
                break;
            case JOBS.PALADIN:
                atk = 8;
                def = 7;
                agi = 1;
                break;
            case JOBS.MAGO:
                atk = 8;
                def = 1;
                agi = 5;
                break;
        }

    }
}
