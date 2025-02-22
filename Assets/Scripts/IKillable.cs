using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKillable
{
    void Kill();

    float ReturnHealth();

    float GetHealth();

    bool IsAlive();
}
