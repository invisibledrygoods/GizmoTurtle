using UnityEngine;
using System.Collections;

public class Doodles : MonoBehaviour
{
    void OnDrawGizmos()
    {
        DrawADoodle(new GizmoTurtle(Vector3.zero), 0.5f);
        DrawADoodle(new GizmoTurtle(Vector3.up * 2.0f), 1f);
        //DrawADoodle(new GizmoTurtle(new Ray(Vector3.zero, Vector3.right), Vector3.up));

    }

    void DrawADoodle(GizmoTurtle turtle, float size)
    {
        new RobotLetters(turtle, size).Write("0123456789 !?.:");
        Gizmos.color = Color.white;
    }
}
