using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeTurn : MonoBehaviour
{
    public GameObject pare;
    public GameObject Turn2;

    public Transform TurnTurn;

    RaycastHit PushBlockhit0;
    RaycastHit PushBlockhit1;
    RaycastHit PushBlockhit2;
    RaycastHit PushBlockhit3;
    RaycastHit PushBlockhit4;
    RaycastHit PushBlockhit5;
    RaycastHit PushBlockhit6;
    RaycastHit PushBlockhit7;
    RaycastHit PushBlockhit8;
    RaycastHit PushBlockhit9;
    RaycastHit PushBlockhit10;
    RaycastHit PushBlockhit11;
    RaycastHit PushBlockhit12;
    RaycastHit PushBlockhit13;
    RaycastHit PushBlockhit14;
    RaycastHit PushBlockhit15;
    RaycastHit PushBlockhit16;
    RaycastHit PushBlockhit17;
    RaycastHit PushBlockhit18;
    RaycastHit PushBlockhit19;
    RaycastHit PushBlockhit20;
    RaycastHit PushBlockhit21;
    RaycastHit PushBlockhit22;
    RaycastHit PushBlockhit23;
    RaycastHit PushBlockhit24;
    RaycastHit PushBlockhit25;
    RaycastHit PushBlockhit26;

    public LayerMask PushBlocks;

    public void CubeReset()
    {

        if (Physics.Raycast(transform.position + new Vector3(0, 0, 0), transform.up, out PushBlockhit0, 1, PushBlocks))
        {
            PushBlockhit0.transform.parent = pare.transform;
        }

        if (Physics.Raycast(transform.position + new Vector3(0, 0, 1), transform.up, out PushBlockhit1, 1, PushBlocks))
        {
            PushBlockhit1.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(0, 0, 2), transform.up, out PushBlockhit2, 1, PushBlocks))
        {
            PushBlockhit2.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 0, 0), transform.up, out PushBlockhit3, 1, PushBlocks))
        {
            PushBlockhit3.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 0, 1), transform.up, out PushBlockhit4, 1, PushBlocks))
        {
            PushBlockhit4.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 0, 2), transform.up, out PushBlockhit5, 1, PushBlocks))
        {
            PushBlockhit5.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 0, 0), transform.up, out PushBlockhit6, 1, PushBlocks))
        {
            PushBlockhit6.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 0, 1), transform.up, out PushBlockhit7, 1, PushBlocks))
        {
            PushBlockhit7.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 0, 2), transform.up, out PushBlockhit8, 1, PushBlocks))
        {
            PushBlockhit8.transform.parent = pare.transform;
        }






        if (Physics.Raycast(transform.position + new Vector3(0, 1, 0), transform.up, out PushBlockhit9, 1, PushBlocks))
        {
            PushBlockhit9.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(0, 1, 1), transform.up, out PushBlockhit10, 1, PushBlocks))
        {
            PushBlockhit10.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(0, 1, 2), transform.up, out PushBlockhit11, 1, PushBlocks))
        {
            PushBlockhit11.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 1, 0), transform.up, out PushBlockhit12, 1, PushBlocks))
        {
            PushBlockhit12.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 1, 1), transform.up, out PushBlockhit13, 1, PushBlocks))
        {
            PushBlockhit13.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 1, 2), transform.up, out PushBlockhit14, 1, PushBlocks))
        {
            PushBlockhit14.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 1, 0), transform.up, out PushBlockhit15, 1, PushBlocks))
        {
            PushBlockhit15.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 1, 1), transform.up, out PushBlockhit16, 1, PushBlocks))
        {
            PushBlockhit16.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 1, 2), transform.up, out PushBlockhit17, 1, PushBlocks))
        {
            PushBlockhit17.transform.parent = pare.transform;
        }






        if (Physics.Raycast(transform.position + new Vector3(0, 2, 0), transform.up, out PushBlockhit18, 1, PushBlocks))
        {
            PushBlockhit18.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(0, 2, 1), transform.up, out PushBlockhit19, 1, PushBlocks))
        {
            PushBlockhit19.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(0, 2, 2), transform.up, out PushBlockhit20, 1, PushBlocks))
        {
            PushBlockhit20.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 2, 0), transform.up, out PushBlockhit21, 1, PushBlocks))
        {
            PushBlockhit21.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 2, 1), transform.up, out PushBlockhit22, 1, PushBlocks))
        {
            PushBlockhit22.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(1, 2, 2), transform.up, out PushBlockhit23, 1, PushBlocks))
        {
            PushBlockhit23.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 2, 0), transform.up, out PushBlockhit24, 1, PushBlocks))
        {
            PushBlockhit24.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 2, 1), transform.up, out PushBlockhit25, 1, PushBlocks))
        {
            PushBlockhit25.transform.parent = pare.transform;
        }
        if (Physics.Raycast(transform.position + new Vector3(2, 2, 2), transform.up, out PushBlockhit26, 1, PushBlocks))
        {
            PushBlockhit26.transform.parent = pare.transform;
        }

        TurnTurn.transform.localEulerAngles = new Vector3(0, 0, 0);
    }
    public void Trun1()
    {
        if (Player.TurnCube >= 1)
        {


            CubeReset();

            PushBlockhit0.transform.parent = Turn2.transform;
            PushBlockhit1.transform.parent = Turn2.transform;
            PushBlockhit2.transform.parent = Turn2.transform;
            PushBlockhit9.transform.parent = Turn2.transform;
            PushBlockhit10.transform.parent = Turn2.transform;
            PushBlockhit11.transform.parent = Turn2.transform;
            PushBlockhit18.transform.parent = Turn2.transform;
            PushBlockhit19.transform.parent = Turn2.transform;
            PushBlockhit20.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(TurnTurn.rotation.x + 90, 0, 0), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun2()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit0.transform.parent = Turn2.transform;
            PushBlockhit1.transform.parent = Turn2.transform;
            PushBlockhit2.transform.parent = Turn2.transform;
            PushBlockhit9.transform.parent = Turn2.transform;
            PushBlockhit10.transform.parent = Turn2.transform;
            PushBlockhit11.transform.parent = Turn2.transform;
            PushBlockhit18.transform.parent = Turn2.transform;
            PushBlockhit19.transform.parent = Turn2.transform;
            PushBlockhit20.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(TurnTurn.rotation.x - 90, 0, 0), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun3()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit3.transform.parent = Turn2.transform;
            PushBlockhit4.transform.parent = Turn2.transform;
            PushBlockhit5.transform.parent = Turn2.transform;
            PushBlockhit12.transform.parent = Turn2.transform;
            PushBlockhit13.transform.parent = Turn2.transform;
            PushBlockhit14.transform.parent = Turn2.transform;
            PushBlockhit21.transform.parent = Turn2.transform;
            PushBlockhit22.transform.parent = Turn2.transform;
            PushBlockhit23.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(TurnTurn.rotation.x + 90, 0, 0), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun4()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit3.transform.parent = Turn2.transform;
            PushBlockhit4.transform.parent = Turn2.transform;
            PushBlockhit5.transform.parent = Turn2.transform;
            PushBlockhit12.transform.parent = Turn2.transform;
            PushBlockhit13.transform.parent = Turn2.transform;
            PushBlockhit14.transform.parent = Turn2.transform;
            PushBlockhit21.transform.parent = Turn2.transform;
            PushBlockhit22.transform.parent = Turn2.transform;
            PushBlockhit23.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(TurnTurn.rotation.x - 90, 0, 0), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun5()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit6.transform.parent = Turn2.transform;
            PushBlockhit7.transform.parent = Turn2.transform;
            PushBlockhit8.transform.parent = Turn2.transform;
            PushBlockhit15.transform.parent = Turn2.transform;
            PushBlockhit16.transform.parent = Turn2.transform;
            PushBlockhit17.transform.parent = Turn2.transform;
            PushBlockhit24.transform.parent = Turn2.transform;
            PushBlockhit25.transform.parent = Turn2.transform;
            PushBlockhit26.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(TurnTurn.rotation.x + 90, 0, 0), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun6()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit6.transform.parent = Turn2.transform;
            PushBlockhit7.transform.parent = Turn2.transform;
            PushBlockhit8.transform.parent = Turn2.transform;
            PushBlockhit15.transform.parent = Turn2.transform;
            PushBlockhit16.transform.parent = Turn2.transform;
            PushBlockhit17.transform.parent = Turn2.transform;
            PushBlockhit24.transform.parent = Turn2.transform;
            PushBlockhit25.transform.parent = Turn2.transform;
            PushBlockhit26.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(TurnTurn.rotation.x - 90, 0, 0), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }

    }

    public void Trun7()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit2.transform.parent = Turn2.transform;
            PushBlockhit5.transform.parent = Turn2.transform;
            PushBlockhit8.transform.parent = Turn2.transform;
            PushBlockhit11.transform.parent = Turn2.transform;
            PushBlockhit14.transform.parent = Turn2.transform;
            PushBlockhit17.transform.parent = Turn2.transform;
            PushBlockhit20.transform.parent = Turn2.transform;
            PushBlockhit23.transform.parent = Turn2.transform;
            PushBlockhit26.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(0, 0, TurnTurn.rotation.z - 90), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun8()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit2.transform.parent = Turn2.transform;
            PushBlockhit5.transform.parent = Turn2.transform;
            PushBlockhit8.transform.parent = Turn2.transform;
            PushBlockhit11.transform.parent = Turn2.transform;
            PushBlockhit14.transform.parent = Turn2.transform;
            PushBlockhit17.transform.parent = Turn2.transform;
            PushBlockhit20.transform.parent = Turn2.transform;
            PushBlockhit23.transform.parent = Turn2.transform;
            PushBlockhit26.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(0, 0, TurnTurn.rotation.z + 90), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun9()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit1.transform.parent = Turn2.transform;
            PushBlockhit4.transform.parent = Turn2.transform;
            PushBlockhit7.transform.parent = Turn2.transform;
            PushBlockhit10.transform.parent = Turn2.transform;
            PushBlockhit13.transform.parent = Turn2.transform;
            PushBlockhit16.transform.parent = Turn2.transform;
            PushBlockhit19.transform.parent = Turn2.transform;
            PushBlockhit22.transform.parent = Turn2.transform;
            PushBlockhit25.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(0, 0, TurnTurn.rotation.z - 90), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun10()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit1.transform.parent = Turn2.transform;
            PushBlockhit4.transform.parent = Turn2.transform;
            PushBlockhit7.transform.parent = Turn2.transform;
            PushBlockhit10.transform.parent = Turn2.transform;
            PushBlockhit13.transform.parent = Turn2.transform;
            PushBlockhit16.transform.parent = Turn2.transform;
            PushBlockhit19.transform.parent = Turn2.transform;
            PushBlockhit22.transform.parent = Turn2.transform;
            PushBlockhit25.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(0, 0, TurnTurn.rotation.z + 90), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun11()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit0.transform.parent = Turn2.transform;
            PushBlockhit3.transform.parent = Turn2.transform;
            PushBlockhit6.transform.parent = Turn2.transform;
            PushBlockhit9.transform.parent = Turn2.transform;
            PushBlockhit12.transform.parent = Turn2.transform;
            PushBlockhit15.transform.parent = Turn2.transform;
            PushBlockhit18.transform.parent = Turn2.transform;
            PushBlockhit21.transform.parent = Turn2.transform;
            PushBlockhit24.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(0, 0, TurnTurn.rotation.z - 90), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }

    public void Trun12()
    {
        if (Player.TurnCube >= 1)
        {
            CubeReset();

            PushBlockhit0.transform.parent = Turn2.transform;
            PushBlockhit3.transform.parent = Turn2.transform;
            PushBlockhit6.transform.parent = Turn2.transform;
            PushBlockhit9.transform.parent = Turn2.transform;
            PushBlockhit12.transform.parent = Turn2.transform;
            PushBlockhit15.transform.parent = Turn2.transform;
            PushBlockhit18.transform.parent = Turn2.transform;
            PushBlockhit21.transform.parent = Turn2.transform;
            PushBlockhit24.transform.parent = Turn2.transform;

            TurnTurn.DORotate(new Vector3(0, 0, TurnTurn.rotation.z + 90), 2f);
            Invoke("CubeReset", 2.1f);
            Player.TurnCube -= 1;
        }
    }
}
