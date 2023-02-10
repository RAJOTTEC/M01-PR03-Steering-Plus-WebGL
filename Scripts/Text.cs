using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    private float count;

    void Update()
    {
        if (count < 5.0f)
        {
            count += Time.deltaTime;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
