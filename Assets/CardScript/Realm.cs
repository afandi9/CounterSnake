using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Realm : MonoBehaviour
{
	private static GameObject player1, player2, player3, player4;
	public static int diceSideThrown = 0;
    // Start is called before the first frame update
	void Start()
	{

	}

    // Update is called once per frame
	public void Update()
	{

	}

	public void realm()
	{
		diceSideThrown = GameControl.diceSideThrown;

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

		initRealm(7);
		initRealm(10);
		initRealm(14);
		initRealm(16);
		initRealm(22);
		initRealm(29);
		initRealm(33);
		initRealm(36);
		initRealm(42);
		initRealm(46);
		initRealm(51);
		initRealm(57);
		initRealm(63);
		initRealm(66);
		initRealm(66);
		initRealm(73);
		initRealm(77);
		initRealm(82);
		initRealm(89);
		initRealm(94);
		initRealm(97);
		initRealm(101);
		initRealm(106);
		initRealm(109);
		initRealm(112);
		initRealm(121);
		initRealm(126);
		initRealm(130);
		initRealm(134);
		initRealm(139);
		initRealm(142);
		initRealm(148);
		initRealm(155);
		initRealm(160);
		initRealm(165);
		initRealm(169);
		initRealm(172);
		initRealm(178);
		initRealm(181);
        initRealm(186);
        initRealm(200);
		initRealm(201);
		initRealm(208);
		initRealm(212);
		initRealm(217);
		initRealm(220);

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

	private void initRealm(int startPos){
		realmPlayer(player1,startPos,startPos + diceSideThrown);
		realmPlayer(player2,startPos,startPos + diceSideThrown);
		realmPlayer(player3,startPos,startPos + diceSideThrown);
		realmPlayer(player4,startPos,startPos + diceSideThrown);
	}

	private void realmPlayer(GameObject player, int startPos, int endPos){
		if ((player.GetComponent<FollowThePath>().waypointIndex) == startPos + 1)
		{
			player.GetComponent<FollowThePath>().transform.position = player.GetComponent<FollowThePath>().waypoints[endPos].transform.position;
			player.GetComponent<FollowThePath>().waypointIndex = endPos;
			MovePlayer(1);
		}
	}
}
