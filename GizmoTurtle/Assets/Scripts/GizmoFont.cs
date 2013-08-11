using UnityEngine;
using System.Collections;

public abstract class GizmoFont
{
    public GizmoTurtle turtle;
    float size;

    public GizmoFont(GizmoTurtle turtle, float size)
    {
        this.turtle = turtle;
        this.size = size;
    }

    public abstract void Render(string str);

    public GizmoTurtle Write(string str)
    {
        if (turtle.UpsideDown())
        {
            Color oldColor = Gizmos.color;
            Color invisible = new Color(0, 0, 0, 0);
            Gizmos.color = invisible;
            Render(str);
            turtle.Mirror();
            Gizmos.color = oldColor;
            Render(str);
            turtle.Mirror();
            Gizmos.color = invisible;
            Render(str);
            Gizmos.color = oldColor;
        }
        else
        {
            Render(str);
        }
        return turtle;
    }

    public GizmoFont R45(int points)
    {
        turtle.RotateRight(45);
        turtle.Forward(Mathf.Sqrt(points * points * 0.02f) * size);
        turtle.RotateRight(45);
        return this;
    }

    public GizmoFont L45(int points)
    {
        turtle.RotateLeft(45);
        turtle.Forward(Mathf.Sqrt(points * points * 0.02f) * size);
        turtle.RotateLeft(45);
        return this;
    }

    public GizmoFont F(int points)
    {
        turtle.Forward(points * 0.1f * size);
        return this;
    }

    public GizmoFont Up()
    {
        turtle.PenUp();
        return this;
    }

    public GizmoFont Down()
    {
        turtle.PenDown();
        return this;
    }

    public GizmoFont Reverse(int points)
    {
        turtle.RotateRight(180);
        turtle.Forward(points * 0.1f * size);
        return this;
    }

    public GizmoFont R(int points)
    {
        turtle.RotateRight(90);
        turtle.Forward(points * 0.1f * size);
        return this;
    }

    public GizmoFont L(int points)
    {
        turtle.RotateLeft(90);
        turtle.Forward(points * 0.1f * size);
        return this;
    }

    public GizmoFont Dot()
    {
        turtle.Forward(0.03f * size);
        turtle.RotateLeft(90);
        turtle.Forward(0.03f * size);
        turtle.RotateLeft(90);
        turtle.Forward(0.03f * size);
        turtle.RotateLeft(90);
        turtle.Forward(0.03f * size);
        turtle.RotateLeft(90);
        return this;
    }
}
