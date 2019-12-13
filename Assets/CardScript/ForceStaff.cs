using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceStaff : MonoBehaviour
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

	public void force()
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

		initForceStaff(7);
		initForceStaff(10);
		initForceStaff(14);
		initForceStaff(16);
		initForceStaff(22);
		initForceStaff(29);
		initForceStaff(33);
		initForceStaff(36);
		initForceStaff(42);
		initForceStaff(46);
		initForceStaff(51);
		initForceStaff(57);
		initForceStaff(63);
		initForceStaff(66);
		initForceStaff(66);
		initForceStaff(73);
		initForceStaff(77);
		initForceStaff(82);
		initForceStaff(89);
		initForceStaff(94);
		initForceStaff(97);
		initForceStaff(101);
		initForceStaff(106);
		initForceStaff(109);
		initForceStaff(112);
		initForceStaff(121);
		initForceStaff(126);
		initForceStaff(130);
		initForceStaff(134);
		initForceStaff(139);
		initForceStaff(142);
		initForceStaff(148);
		initForceStaff(155);
		initForceStaff(160);
		initForceStaff(165);
		initForceStaff(169);
		initForceStaff(172);
		initForceStaff(178);
		initForceStaff(181);
		initForceStaff(200);
		initForceStaff(201);
		initForceStaff(208);
		initForceStaff(212);
		initForceStaff(217);
		initForceStaff(220);

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

	private void initForceStaff(int startPos){
		forceStaffPlayer(player1,startPos,startPos + 4);
		forceStaffPlayer(player2,startPos,startPos + 4);
		forceStaffPlayer(player3,startPos,startPos + 4);
		forceStaffPlayer(player4,startPos,startPos + 4);
	}

	private void forceStaffPlayer(GameObject player, int startPos, int endPos){
		if ((player.GetComponent<FollowThePath>().waypointIndex) == startPos + 1)
		{
			player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[endPos].transform.position;
			player.GetComponent<FollowThePath>().waypointIndex = endPos;
			//player.GetComponent<FollowThePath>().waypointIndex += 1;
			MovePlayer(1);
		}
	}
}
