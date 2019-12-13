using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
	private static GameObject player1, player2, player3, player4;
	public static int diceSideThrown = 0;
	public static int player1StartWaypoint = 0;
	public static int player2StartWaypoint = 0;
	public static int player3StartWaypoint = 0;
	public static int player4StartWaypoint = 0;
    // Start is called before the first frame update
	void Start()
	{

	}

    // Update is called once per frame
	public void Update()
	{

	}

	public void blackHole()
	{
		diceSideThrown = GameControl.diceSideThrown;
		player1StartWaypoint = GameControl.player1StartWaypoint;
		player2StartWaypoint = GameControl.player2StartWaypoint;
		player3StartWaypoint = GameControl.player3StartWaypoint;
		player4StartWaypoint = GameControl.player4StartWaypoint;

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

		initBlackHole(7);
		initBlackHole(10);
		initBlackHole(14);
		initBlackHole(16);
		initBlackHole(22);
		initBlackHole(29);
		initBlackHole(33);
		initBlackHole(36);
		initBlackHole(42);
		initBlackHole(46);
		initBlackHole(51);
		initBlackHole(57);
		initBlackHole(63);
		initBlackHole(66);
		initBlackHole(66);
		initBlackHole(73);
		initBlackHole(77);
		initBlackHole(82);
		initBlackHole(89);
		initBlackHole(94);
		initBlackHole(97);
		initBlackHole(101);
		initBlackHole(106);
		initBlackHole(109);
		initBlackHole(112);
		initBlackHole(121);
		initBlackHole(126);
		initBlackHole(130);
		initBlackHole(134);
		initBlackHole(139);
		initBlackHole(142);
		initBlackHole(148);
		initBlackHole(155);
		initBlackHole(160);
		initBlackHole(165);
		initBlackHole(169);
		initBlackHole(172);
		initBlackHole(178);
		initBlackHole(181);
		initBlackHole(200);
		initBlackHole(201);
		initBlackHole(208);
		initBlackHole(212);
		initBlackHole(217);
		initBlackHole(220);

		player1.GetComponent<FollowThePath>().moveAllowed = false;
		player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;

		player2.GetComponent<FollowThePath>().moveAllowed = false;
		player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;

		player3.GetComponent<FollowThePath>().moveAllowed = false;
		player3StartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex - 1;

		player4.GetComponent<FollowThePath>().moveAllowed = false;
		player4StartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex - 1;
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

	private void initBlackHole(int startPos){
		blackHolePlayer(player1,startPos);
		blackHolePlayer(player2,startPos);
		blackHolePlayer(player3,startPos);
		blackHolePlayer(player4,startPos);
	}

	private void blackHolePlayer(GameObject player, int startPos){
		if ((player.GetComponent<FollowThePath>().waypointIndex) == startPos + 1)
		{
			movePlayerToCenter(player1,startPos,startPos);
			movePlayerToCenter(player2,startPos,startPos);
			movePlayerToCenter(player3,startPos,startPos);
			movePlayerToCenter(player4,startPos,startPos);
		}
	}
	private void movePlayerToCenter(GameObject player, int startPos, int endPos){
		player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[endPos].transform.position;
			player.GetComponent<FollowThePath>().waypointIndex = endPos;
			player.GetComponent<FollowThePath>().waypointIndex += 1;
			MovePlayer(1);
			Debug.Log(player.GetComponent<FollowThePath>().waypointIndex);
	}
}
