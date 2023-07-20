using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public CubeTurn CubeTurn;
    public int Num;
    private void OnMouseDown()
    {
        if(Num == 1)
        {
            CubeTurn.Trun1();
        }

        if (Num == 2)
        {
            CubeTurn.Trun2();
        }

        if (Num == 3)
        {
            CubeTurn.Trun3();
        }

        if (Num == 4)
        {
            CubeTurn.Trun4();
        }

        if (Num == 5)
        {
            CubeTurn.Trun5();
        }

        if (Num == 6)
        {
            CubeTurn.Trun6();
        }

        if (Num == 7)
        {
            CubeTurn.Trun7();
        }

        if (Num == 8)
        {
            CubeTurn.Trun8();
        }

        if (Num == 9)
        {
            CubeTurn.Trun9();
        }

        if (Num == 10)
        {
            CubeTurn.Trun10();
        }

        if (Num == 11)
        {
            CubeTurn.Trun11();
        }

        if (Num == 12)
        {
            CubeTurn.Trun12();
        }
    }
}
