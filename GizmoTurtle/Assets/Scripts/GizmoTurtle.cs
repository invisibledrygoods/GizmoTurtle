using UnityEngine;
using System.Collections;

public class GizmoTurtle
{
    Vector3 forward;
    Vector3 right;
    Vector3 up;
    Vector3 position;
    bool penOnPaper;

    public GizmoTurtle(Vector3 position)
    {
        this.position = position;
        forward = Camera.current.transform.right;
        right = -Camera.current.transform.up;
        up = -Camera.current.transform.forward;
        penOnPaper = false;
    }

    public GizmoTurtle(Ray forward)
    {
        position = forward.origin;
        this.forward = forward.direction;
        right = Vector3.Cross(Camera.current.transform.forward, this.forward); 
        up = Vector3.Cross(this.right, this.forward);
        penOnPaper = false;
    }

    public GizmoTurtle(Ray forward, Vector3 right)
    {
        position = forward.origin;
        this.forward = forward.direction;
        this.right = right;
        up = Vector3.Cross(this.right, this.forward);
        penOnPaper = false;
    }

    public void PenDown()
    {
        penOnPaper = true;
    }

    public void PenUp()
    {
        penOnPaper = false;
    }

    public void Forward(float distance)
    {
        if (penOnPaper)
        {
            Gizmos.DrawLine(position, position + forward * distance);
        }
        position += forward * distance;
    }

    public void RotateLeft(float angle)
    {
        forward = Quaternion.AngleAxis(-angle, up) * forward;
        right = Quaternion.AngleAxis(-angle, up) * right;
    }

    public void RotateRight(float angle)
    {
        forward = Quaternion.AngleAxis(angle, up) * forward;
        right = Quaternion.AngleAxis(angle, up) * right;
    }
}
