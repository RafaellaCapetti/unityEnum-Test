using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mod4 : MonoBehaviour
{
    public enum Animals
    {
        Flamingo,
        Zebra,
        Dog
    }

    private void CheckSwitchCase(Animals a)
    {
        switch (a)
        {
            case Animals.Flamingo:
                OnReadFlamingo();
                break;
            case Animals.Zebra:
                OnReadZebra();
                break;
            case Animals.Dog:
                OnReadDog();
                break;
        }
    }

    private void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CheckSwitchCase(Animals.Flamingo);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            CheckSwitchCase(Animals.Zebra);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            CheckSwitchCase(Animals.Dog);
        }
    }

    private void OnReadFlamingo()
    {
        Debug.Log("Flamingo");
    }

    private void OnReadZebra()
    {
        Debug.Log("Zebra");
    }

    private void OnReadDog()
    {
        Debug.Log("Dog");
    }

    void Start()
    {

    }

    void Update()
    {
        CheckKeys();
    }
}
