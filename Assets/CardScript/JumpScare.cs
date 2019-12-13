using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    private static GameObject player1, player2, player3, player4;
    public static int whichPlayer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void jumpS() 
    { 
        player4 = GameObject.Find("Player4");
        player3 = GameObject.Find("Player3");
        player2 = GameObject.Find("Player2");
        player1 = GameObject.Find("Player1");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().moveAllowed = false;

        //if (player1.GetComponent<FollowThePath>().waypointIndex >
        //    player1StartWaypoint + diceSideThrown)
        //{
        
        if (whichPlayer==1)
        {
            Debug.Log("p1 awal " + (player1.GetComponent<FollowThePath>().waypointIndex));
            Debug.Log("p1 akhir " + (setengah(player1.GetComponent<FollowThePath>().waypointIndex + 1) - 1));
            jumpPlayer(player1,player1.GetComponent<FollowThePath>().waypointIndex-1, setengah(player1.GetComponent<FollowThePath>().waypointIndex + 1)-1);
        }
        if (whichPlayer == 2)
        {
            Debug.Log("p2 awal " + (player2.GetComponent<FollowThePath>().waypointIndex));
            Debug.Log("p2 akhir " + (setengah(player2.GetComponent<FollowThePath>().waypointIndex + 1) - 1));
            jumpPlayer(player2, player2.GetComponent<FollowThePath>().waypointIndex-1, setengah(player2.GetComponent<FollowThePath>().waypointIndex + 1)-1);
        }
        if (whichPlayer == 3)
        {
            Debug.Log("p3 awal " + (player3.GetComponent<FollowThePath>().waypointIndex));
            Debug.Log("p3 akhir " + (setengah(player3.GetComponent<FollowThePath>().waypointIndex + 1) - 1));
            jumpPlayer(player3, player3.GetComponent<FollowThePath>().waypointIndex-1, setengah(player3.GetComponent<FollowThePath>().waypointIndex + 1)-1);
        }
        if (whichPlayer == 4)
        {
            Debug.Log("p4 awal " + (player4.GetComponent<FollowThePath>().waypointIndex));
            Debug.Log("p4 akhir " + (setengah(player4.GetComponent<FollowThePath>().waypointIndex + 1) - 1));
            jumpPlayer(player4, player4.GetComponent<FollowThePath>().waypointIndex-1, setengah(player4.GetComponent<FollowThePath>().waypointIndex + 1)-1);
        }

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        GameControl.player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex;

        player2.GetComponent<FollowThePath>().moveAllowed = false;
        GameControl.player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex;

        player3.GetComponent<FollowThePath>().moveAllowed = false;
        GameControl.player3StartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex;

        player4.GetComponent<FollowThePath>().moveAllowed = false;
        GameControl.player4StartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex;
        //}
    }
    public static void MovePlayer(GameObject playerToMove)
    {
        if (playerToMove == player1)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = true;

        }
        if (playerToMove == player2)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = true;
        }
        if (playerToMove == player3)
        {
            player3.GetComponent<FollowThePath>().moveAllowed = true;
        }
        if (playerToMove == player4)
        {
            player4.GetComponent<FollowThePath>().moveAllowed = true;
        }
    }
    private int setengah(int nilai)
    {
        int set = 0;
        if (nilai % 2 == 0)
        {
            set = nilai / 2;
        }
        else
        {
            set = (nilai + 1) / 2;
        }
        return set;
    }

    private void jumpPlayer(GameObject player, int startPos, int endPos)
    {
            player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[endPos].transform.position;
            player.GetComponent<FollowThePath>().waypointIndex = endPos;
            MovePlayer(player);
            //Debug.Log("posisi sekarang"+player.GetComponent<FollowThePath>().waypointIndex);
        
    }
}
