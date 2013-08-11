using UnityEngine;
using System.Collections;

public class Doodles : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        new RobotLetters(new GizmoTurtle(new Ray(Vector3.up * 0.6f, Vector3.right)), 0.6f).Write("0123456789 !?.:");
        new RobotLetters(new GizmoTurtle(new Ray(Vector3.up * 1.2f, Vector3.right)), 0.6f).Write("abcdefghijklmnopqrstuvwxyz");
        new RobotLetters(new GizmoTurtle(new Ray(Vector3.up * 1.8f, Vector3.right)), 0.6f).Write("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        new RobotLetters(new GizmoTurtle(new Ray(Vector3.up * 0.6f, Vector3.forward)), 0.6f).Write("0123456789 !?.:");
        new RobotLetters(new GizmoTurtle(new Ray(Vector3.up * 1.2f, Vector3.forward)), 0.6f).Write("abcdefghijklmnopqrstuvwxyz");
        new RobotLetters(new GizmoTurtle(new Ray(Vector3.up * 1.8f, Vector3.forward)), 0.6f).Write("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
    }
}
