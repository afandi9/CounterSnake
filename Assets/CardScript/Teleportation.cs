using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
	private static GameObject player1, player2, player3, player4;
    // Start is called before the first frame update
	void Start()
	{

	}

    // Update is called once per frame
	public void Update()
	{

	}

	public void teleport()
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

		initTeleport(7,24);
		initTeleport(10,21);
		initTeleport(14,17);
		initTeleport(16,45);
		initTeleport(22,39);
		initTeleport(29,32);
		initTeleport(33,58);
		initTeleport(36,55);
		initTeleport(42,49);
		initTeleport(46,75);
		initTeleport(51,70);
		initTeleport(57,64);
		initTeleport(63,88);
		initTeleport(66,85);
		//initTeleport(66,83);
		initTeleport(73,78);
		initTeleport(77,104);
		initTeleport(82,99);
		initTeleport(89,92);
		initTeleport(94,117);
		initTeleport(97,114);
		initTeleport(101,110);
		initTeleport(106,135);
		initTeleport(109,132);
		initTeleport(112,129);
		initTeleport(121,150);
		initTeleport(126,145);
		initTeleport(130,141);
		initTeleport(134,137);
		initTeleport(139,162);
		initTeleport(142,159);
		initTeleport(148,153);
		initTeleport(155,176);
		initTeleport(160,171);
		initTeleport(165,166);
		initTeleport(169,192);
		initTeleport(172,189);
		initTeleport(178,183);
		initTeleport(181,210);
		initTeleport(200,221);
		initTeleport(201,220);
		initTeleport(208,213);
		initTeleport(212,212);
		initTeleport(217,217);
		initTeleport(220,220);

		player1.GetComponent<FollowThePath>().moveAllowed = false;
		GameControl.player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;

		player2.GetComponent<FollowThePath>().moveAllowed = false;
        GameControl.player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;

		player3.GetComponent<FollowThePath>().moveAllowed = false;
        GameControl.player3StartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex - 1;

		player4.GetComponent<FollowThePath>().moveAllowed = false;
        GameControl.player4StartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex - 1;
        //}
	}
	public static void MovePlayer(int playerToMove)
	{
		switch (playerToMove)
		{
			case 1:
			player1.GetComponent<FollowThePath>().moveAllowed = true;
			break;

			case 2:
			player2.GetComponent<FollowThePath>().moveAllowed = true;
			break;
			case 3:
			player3.GetComponent<FollowThePath>().moveAllowed = true;
			break;
			case 4:
			player4.GetComponent<FollowThePath>().moveAllowed = true;
			break;
		}
	}

	private void initTeleport(int startPos, int endPos){
		teleportPlayer(player1,startPos,endPos);
		teleportPlayer(player2,startPos,endPos);
		teleportPlayer(player3,startPos,endPos);
		teleportPlayer(player4,startPos,endPos);
	}

	private void teleportPlayer(GameObject player, int startPos, int endPos){
		if ((player.GetComponent<FollowThePath>().waypointIndex) == startPos + 1)
		{
			player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[endPos].transform.position;
			player.GetComponent<FollowThePath>().waypointIndex = endPos;
			player.GetComponent<FollowThePath>().waypointIndex += 1;
			MovePlayer(1);
		}
	}
}
