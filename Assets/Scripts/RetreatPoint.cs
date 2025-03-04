using NUnit.Framework;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RetreatPoint : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        List<RetreatPoint> retreatPoints = new List<RetreatPoint>(GetComponents<RetreatPoint>());
        Gizmos.color = Color.blue;

        for (int i = 0; i < retreatPoints.Count; i++)
        {
            Vector3 retreatPosition = retreatPoints[i].transform.position;
        }
    }
}
