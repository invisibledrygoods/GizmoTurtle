using UnityEngine;
using System.Collections;

public class GizmoTurtle
{
    Vector3 forward;
    Vector3 right;
    Vector3 up;
    Vector3 position;
    bool penOnPaper;

    public Vector3 Position
    {
        get
        {
            return position;
        }
    }

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

    public bool UpsideDown()
    {
        if (forward == Camera.current.transform.right)
        {
            return false;
        }
        return Vector3.Dot(-this.right, Vector3.up) > 0;
    }

    public void Mirror()
    {
        forward = -forward;
    }

    public GizmoTurtle PenDown()
    {
        penOnPaper = true;
        return this;
    }

    public GizmoTurtle PenUp()
    {
        penOnPaper = false;
        return this;
    }

    public GizmoTurtle Forward(float distance)
    {
        if (penOnPaper)
        {
            Gizmos.DrawLine(position, position + forward * distance);
        }
        position += forward * distance;
        return this;
    }

    public GizmoTurtle RotateLeft(float angle)
    {
        forward = Quaternion.AngleAxis(-angle, up) * forward;
        right = Quaternion.AngleAxis(-angle, up) * right;
        return this;
    }

    public GizmoTurtle RotateRight(float angle)
    {
        forward = Quaternion.AngleAxis(angle, up) * forward;
        right = Quaternion.AngleAxis(angle, up) * right;
        return this;
    }
}
