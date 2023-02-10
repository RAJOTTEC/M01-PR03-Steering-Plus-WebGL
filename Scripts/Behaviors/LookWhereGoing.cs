using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWhereGoing : Align
{
    public override float getTargetAngle()
    {
        Vector3 velocity = character.linearVelocity;
        if (velocity.magnitude == 0)
        {
            return character.transform.eulerAngles.y;
        }

        float targetAngle = Mathf.Atan2(velocity.x, velocity.z);
        targetAngle *= Mathf.Rad2Deg;

        return targetAngle;
    }
}