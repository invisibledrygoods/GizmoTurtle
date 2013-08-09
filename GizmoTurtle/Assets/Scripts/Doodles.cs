using UnityEngine;
using System.Collections;

public class Doodles : MonoBehaviour
{
    void OnDrawGizmos()
    {
        DrawADoodle(new GizmoTurtle(Vector3.zero));
        DrawADoodle(new GizmoTurtle(new Ray(Vector3.zero, Vector3.right)));
        DrawADoodle(new GizmoTurtle(new Ray(Vector3.zero, Vector3.right), Vector3.up));

    }

    void DrawADoodle(GizmoTurtle turtle)
    {
        turtle.PenDown();
        turtle.Forward(1);
        turtle.RotateLeft(90);
        turtle.Forward(1);
        turtle.PenUp();
        turtle.Forward(1);
        turtle.PenDown();
        turtle.Forward(1);
        turtle.RotateRight(90);
        turtle.Forward(1);

        Gizmos.color = Color.white;
    }
}
