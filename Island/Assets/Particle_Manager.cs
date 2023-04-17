using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Manager : MonoBehaviour
{

    public ParticleSystem particleIn;
    public ParticleSystem particleOut;
    ParticleSystem.EmissionModule emitIn;
    ParticleSystem.EmissionModule emitOut;

    private int breathingState;

    // Start is called before the first frame update
    void Start()
    {
        emitIn = particleIn.emission;
        emitOut = particleOut.emission;
        emitIn.enabled = false;
        emitOut.enabled = false;
        breathingState = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("XRI_Right_GripButton") && Input.GetButton("XRI_Left_GripButton"))
        {
            breathingState = 1;
        }
        else if (!Input.GetButton("XRI_Right_GripButton") && Input.GetButton("XRI_Left_GripButton"))
        {
            breathingState = 2;
        }
        else {
            breathingState = 0;
        }

        switch (breathingState) {
            case 0:
                emitIn.enabled = false;
                emitOut.enabled = false;
                break;
            case 1:
                emitIn.enabled = true;
                emitIn.enabled = false; 
                break;
            case 2:
                emitIn.enabled = false;
                emitOut.enabled = true;
                break;
            default:
                break;
        }

    }
}
