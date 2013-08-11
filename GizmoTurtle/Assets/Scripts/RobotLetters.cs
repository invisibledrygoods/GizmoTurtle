using UnityEngine;
using System.Collections;

public class RobotLetters : GizmoFont
{
    public RobotLetters(GizmoTurtle turtle, float size) : base(turtle, size)
    {
    }

    public override GizmoTurtle Write(string str)
    {
        foreach (char letter in str.ToLower().ToCharArray())
        {
            switch (letter) {
                case ' ':
                    Up().F(7);
                    break;
                case 'a':
                    Down().L(5).R45(1).F(2).R45(1).F(5).Up().R(4).R(2).Down().R(4).Up().R(2).L(2);
                    break;
                case 'b':
                    Down().L(6).R(3).R45(1).F(1).R45(1).F(3).Reverse(3).R45(1).F(1).R45(1).F(3).Up().Reverse(6);
                    break;
                case 'c':
                    Up().L(1).Down().F(4).R45(1).F(2).R45(1).Up().F(4).Down().R45(1).F(2).R45(1).Up().Reverse(1).L(6);
                    break;
                case 'd':
                    Down().L(6).R(2).R45(2).F(2).R45(2).F(2).Up().Reverse(6);
                    break;
                case 'e':
                    Down().L(6).R(4).Up().R(6).Down().R(4).Up().R(3).Down().R(3).Up().R(3).L(3);
                    break;
                case 'f':
                    Down().L(6).R(4).Up().R(3).R(1).Down().F(3).Up().L(3).L(6);
                    break;
                case 'g':
                    Up().L(3).R(2).Down().F(2).R(3).R(3).R45(1).F(4).R45(1).F(2).R45(1).Up().F(5).L(2);
                    break;
                case 'h':
                    Down().L(6).Up().R(4).Down().R(6).Up().R(4).R(3).Down().R(4).Up().R(3).L(2);
                    break;
                case 'i':
                    Up().F(1).Down().F(2).Up().L(6).Down().L(2).Up().Reverse(1).Down().R(6).Up().L(4);
                    break;
                case 'j':
                    Up().L(1).Reverse(0).Down().L45(1).F(1).L45(1).F(5).Up().L(1).Down().Reverse(2).Up().R(6).L(2);
                    break;
                case 'k':
                    Down().L(6).Up().R(4).Reverse(0).Down().L45(3).R(1).Up().Reverse(1).Down().R45(3).Up().L(2);
                    break;
                case 'l':
                    Down().F(4).Up().L(6).L(4).Down().L(6).Up().L(6);
                    break;
                case 'm':
                    Down().L(6).Reverse(0).L45(2).R(1).Up().Reverse(1).Down().R45(2).R(6).Up().L(2);
                    break;
                case 'n':
                    Down().L(6).Up().Reverse(1).Down().L45(4).Up().L(5).Down().Reverse(6).Up().L(2);
                    break;
                case 'o':
                    Up().F(1).Down().F(2).L45(1).F(4).L45(1).F(2).L45(1).F(4).L45(1).Up().F(5);
                    break;
                case 'p':
                    Down().L(6).R(3).R45(1).F(1).R45(1).F(3).Up().L(3).L(6);
                    break;
                case 'q':
                    Up().F(1).Down().F(1).L45(2).F(3).L45(1).F(2).L45(1).F(4).L45(1).Up().F(1).L(2).Reverse(0).Down().L45(2).Up().F(2);
                    break;
                case 'r':
                    Down().L(6).R(3).R45(1).F(1).R45(1).F(3).Up().Reverse(1).Down().R45(3).Up().L(2);
                    break;
                case 's':
                    Down().F(3).L45(1).F(1).L45(1).F(2).R45(1).F(1).R45(1).F(3).Up().R(6).L(2);
                    break;
                case 't':
                    Up().F(2).Down().L(6).Up().L(2).Down().Reverse(4).Up().R(6).L(2);
                    break;
                case 'u':
                    Up().L(6).Down().Reverse(5).L45(1).F(2).L45(1).F(5).Up().Reverse(6).L(2);
                    break;
                case 'v':
                    Up().L(6).Down().Reverse(4).L45(2).L45(2).F(4).Up().Reverse(6).L(2);
                    break;
                case 'w':
                    Up().L(6).Down().Reverse(5).L45(1).L45(1).F(2).Up().Reverse(2).Down().L45(1).L45(1).F(5).Up().Reverse(6).L(2);
                    break;
                case 'x':
                    Down().L(1).R45(4).L(1).Up().L(4).Down().L(1).L45(4).R(1).Up().L(2);
                    break;
                case 'y':
                    Up().L(6).Down().Reverse(2).L45(2).R(2).Up().Reverse(2).Down().R45(2).L(2).Up().Reverse(6).L(2);
                    break;
                case 'z':
                    Up().L(6).Down().R(4).R(1).R45(4).L(1).L(4).Up().F(2);
                    break;
                case '.':
                    Up().F(1).Down().F(1).L(1).L(1).L(1).Up().L(5);
                    break;
                case '!':
                    Up().F(2).Down().Dot().Up().L(3).Down().F(3).Up().Reverse(6).L(3);
                    break;
                case '?':
                    Up().F(2).Down().Dot().Up().L(2).Down().R45(2).L(1).L45(1).F(2).L45(1).Up().F(5).L(6);
                    break;
                case ':':
                    Up().L45(1).Down().F(1).R(1).R(1).R(1).Up().R(3).Down().F(1).R(1).R(1).R(1).Up().L(4).L(6);
                    break;
                default:
                    Down().L(6).R(4).R(6).R(4).Up().Reverse(6);
                    break;
            }
        }
        return turtle;
    }
}
