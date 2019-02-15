using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator knight;

    public GameObject trail;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                knight.SetTrigger("Attack0" + Random.Range(1, 6));
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            knight.SetTrigger("Attack0" + Random.Range(1, 6));
        }

        if (knight.GetCurrentAnimatorStateInfo(0).IsName("2Handed_Idle_1"))
        {
            trail.SetActive(false);
        }
        else 
        {
            trail.SetActive(true);
        }
    }
}