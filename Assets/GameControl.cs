using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText,player3MoveText, player4MoveText, cardRandom;

    private static GameObject player1, player2, player3, player4;

    public static int nofPlayers;
	
    public static int diceSideThrown = 0;
	public static int cardGet = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int player3StartWaypoint = 0;
    public static int player4StartWaypoint = 0;

    public static bool gameOver = false;
    

    // Use this for initialization
    void Start () {

        diceSideThrown = 0;
		cardGet = 0;
        player1StartWaypoint = 0;
        player2StartWaypoint = 0;
        player3StartWaypoint = 0;
        player4StartWaypoint = 0;
        gameOver = false;

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("P1Move");
        player2MoveText = GameObject.Find("P2Move");
        player3MoveText = GameObject.Find("P3Move");
        player4MoveText = GameObject.Find("P4Move");

        player4 = GameObject.Find("Player4");
        player3 = GameObject.Find("Player3");
        player2 = GameObject.Find("Player2");
        player1 = GameObject.Find("Player1");        

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().moveAllowed = false;

        
        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver){
            AdmobScript.instance.showInterstitialAd();
        }
        if(Dice.whosTurn == 1){
            player1MoveText.gameObject.SetActive(true);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
        }else if(Dice.whosTurn == 2){
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
        }
        else if(Dice.whosTurn == 3){
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(true);
            player4MoveText.gameObject.SetActive(false);
        }
        else if(Dice.whosTurn == 4){
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(true);
        }
		// ** PLAYER 1
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            //Debug.Log(player1StartWaypoint+diceSideThrown);
            //Tangga 1
            cardRandom = GameObject.Find("CardsActive");
            if (player1StartWaypoint+diceSideThrown == 7){
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                //ButtonControl.statusKartuMenu = true;
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 10)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 14)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 16)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 22)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 29)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 33)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 36)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 42)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 46)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 51)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 57)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 63)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 66)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 68)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 73)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 77)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 82)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 89)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 94)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 97)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 101)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 106)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 109)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 112)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 121)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 126)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 130)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 134)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 139)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 142)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 148)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 155)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 160)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 165)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 169)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 172)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard()); 
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 178)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 181)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 186)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 192)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 200)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 201)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 208)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());

                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 212)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 217)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint + diceSideThrown == 220)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player1StartWaypoint+diceSideThrown == 12){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[41].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 41;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 28){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[56].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 56;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 38){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[67].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 67;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 47){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[76].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 76;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 61){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[90].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 90;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 80){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[113].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 113;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
			}
            if(player1StartWaypoint+diceSideThrown == 111){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[131].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 131;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
			if(player1StartWaypoint+diceSideThrown == 117){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[149].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 149;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
			if(player1StartWaypoint+diceSideThrown == 125){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[173].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 173;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
			if(player1StartWaypoint+diceSideThrown == 137){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[163].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 163;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
			if(player1StartWaypoint+diceSideThrown == 161){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[198].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 198;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
			if(player1StartWaypoint+diceSideThrown == 174){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[216].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 216;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
			if(player1StartWaypoint+diceSideThrown == 182){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[210].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 210;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
			//Ular 1
            if(player1StartWaypoint+diceSideThrown == 45){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[17].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 17;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 55){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[4].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 4;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 71){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[44].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 44;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 87){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[31].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 31;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 98){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[21].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 21;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 116){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[84].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 84;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 135){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[110].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 110;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 150){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[92].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 92;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 154){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[119].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 119;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 170){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[144].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 144;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 183){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[175].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 175;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 197){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[168].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 168;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 203){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[190].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 190;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 221){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[188].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 188;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 215){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[151].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 151;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
			//if((player1StartWaypoint+diceSideThrown) > 225){
			//	int point = (player1StartWaypoint+diceSideThrown)-225;
			//	int mundur = (225 - point);
			//	player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[mundur].transform.position;
   //             player1.GetComponent<FollowThePath>().waypointIndex = mundur;
   //             player1.GetComponent<FollowThePath>().waypointIndex +=1;
   //             MovePlayer(1);
			//}
            player1.GetComponent<FollowThePath>().moveAllowed = false;            
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }
		
// Player 2
        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {

            //Tangga 1
            cardRandom = GameObject.Find("CardsActive");
            if (player2StartWaypoint + diceSideThrown == 7)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                //ButtonControl.statusKartuMenu = true;
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 10)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 14)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 16)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 22)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 29)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 33)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 36)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 42)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 46)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 51)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 57)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 63)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 66)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 68)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 73)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 77)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 82)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 89)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 94)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 97)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 101)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 106)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 109)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 112)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 121)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 126)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 130)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 134)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 139)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 142)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 148)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 155)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 160)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 165)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 169)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 172)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 178)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 181)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 186)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 192)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 200)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 201)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 208)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());

                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 212)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 217)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint + diceSideThrown == 220)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player2StartWaypoint+diceSideThrown == 12){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[41].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 41;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 28){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[56].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 56;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 38){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[67].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 67;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 47){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[76].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 76;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 61){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[90].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 90;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 80){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[113].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 113;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
			}
            if(player2StartWaypoint+diceSideThrown == 111){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[131].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 131;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
			if(player2StartWaypoint+diceSideThrown == 117){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[149].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 149;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
			if(player2StartWaypoint+diceSideThrown == 125){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[173].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 173;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
			if(player2StartWaypoint+diceSideThrown == 137){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[163].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 163;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
			if(player2StartWaypoint+diceSideThrown == 161){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[198].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 198;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
			if(player2StartWaypoint+diceSideThrown == 174){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[216].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 216;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
			if(player2StartWaypoint+diceSideThrown == 182){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[210].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 210;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
			//Ular 2
            if(player2StartWaypoint+diceSideThrown == 45){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[17].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 17;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 55){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[4].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 4;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 71){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[44].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 44;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 87){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[31].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 31;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 98){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[21].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 21;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 116){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[84].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 84;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 135){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[110].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 110;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 150){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[92].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 92;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 154){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[119].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 119;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 170){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[144].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 144;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 183){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[175].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 175;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 197){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[168].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 168;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 203){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[190].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 190;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if (player2StartWaypoint + diceSideThrown == 215)
            {
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[151].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 151;
                player2.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(2);
            }
            if (player2StartWaypoint+diceSideThrown == 221){
                player2.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[188].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 188;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            player2.GetComponent<FollowThePath>().moveAllowed = false;            
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

// ** Player 3
         if (player3.GetComponent<FollowThePath>().waypointIndex > 
            player3StartWaypoint + diceSideThrown)
        {
            //Debug.Log(player3StartWaypoint+diceSideThrown);
            //Tangga 3
            cardRandom = GameObject.Find("CardsActive");
            if (player3StartWaypoint + diceSideThrown == 7)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                //ButtonControl.statusKartuMenu = true;
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 10)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 14)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 16)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 22)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 29)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 33)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 36)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 42)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 46)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 51)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 57)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 63)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 66)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 68)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 73)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 77)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 82)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 89)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 94)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 97)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 101)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 106)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 109)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 112)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 121)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 126)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 130)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 134)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 139)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 142)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 148)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 155)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 160)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 165)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 169)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 172)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 178)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 181)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 186)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 192)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 200)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 201)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 208)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());

                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 212)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 217)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint + diceSideThrown == 220)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player3StartWaypoint+diceSideThrown == 12){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[41].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 41;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 28){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[56].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 56;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 38){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[67].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 67;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 47){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[76].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 76;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 61){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[90].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 90;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 80){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[113].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 113;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
			}
            if(player3StartWaypoint+diceSideThrown == 111){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[131].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 131;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
			if(player3StartWaypoint+diceSideThrown == 117){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[149].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 149;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
			if(player3StartWaypoint+diceSideThrown == 125){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[173].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 173;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
			if(player3StartWaypoint+diceSideThrown == 137){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[163].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 163;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
			if(player3StartWaypoint+diceSideThrown == 161){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[198].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 198;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
			if(player3StartWaypoint+diceSideThrown == 174){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[216].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 216;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
			if(player3StartWaypoint+diceSideThrown == 182){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[210].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 210;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
			//Ular 3
            if(player3StartWaypoint+diceSideThrown == 45){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[17].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 17;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 55){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[4].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 4;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 71){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[44].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 44;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 87){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[31].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 31;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 98){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[21].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 21;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 116){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[84].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 84;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 135){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[110].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 110;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 150){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[92].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 92;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 154){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[119].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 119;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 170){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[144].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 144;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 183){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[175].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 175;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 197){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[168].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 168;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 203){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[190].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 190;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if (player3StartWaypoint + diceSideThrown == 215)
            {
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[151].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 151;
                player3.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(3);
            }
            if (player3StartWaypoint+diceSideThrown == 221){
                player3.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[188].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 188;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            player3.GetComponent<FollowThePath>().moveAllowed = false;            
            player3StartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex - 1;
        }
//
        //Player4
        if (player4.GetComponent<FollowThePath>().waypointIndex > 
            player4StartWaypoint + diceSideThrown)
        {
            //Debug.Log(player4StartWaypoint+diceSideThrown);
            //Tangga 4
            cardRandom = GameObject.Find("CardsActive");
            if (player4StartWaypoint + diceSideThrown == 7)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                //ButtonControl.statusKartuMenu = true;
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 10)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 14)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 16)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 22)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 29)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 33)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 36)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 42)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 46)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 51)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 57)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 63)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 66)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 68)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 73)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 77)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 82)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 89)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 94)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 97)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 101)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 106)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 109)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 112)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 121)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 126)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 130)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 134)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 139)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 142)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 148)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 155)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 160)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 165)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 169)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 172)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 178)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 181)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 186)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 192)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 200)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 201)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 208)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());

                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 212)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 217)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint + diceSideThrown == 220)
            {
                StartCoroutine(cardRandom.GetComponent<Card>().RollTheCard());
                ButtonControl.cardMenu.SetActive(true);
            }
            if (player4StartWaypoint+diceSideThrown == 12){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[41].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 41;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 28){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[56].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 56;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 38){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[67].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 67;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 47){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[76].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 76;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 61){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[90].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 90;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 80){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[113].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 113;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
			}
            if(player4StartWaypoint+diceSideThrown == 111){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[131].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 131;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
			if(player4StartWaypoint+diceSideThrown == 117){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[149].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 149;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
			if(player4StartWaypoint+diceSideThrown == 125){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[173].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 173;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
			if(player4StartWaypoint+diceSideThrown == 137){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[163].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 163;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
			if(player4StartWaypoint+diceSideThrown == 161){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[198].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 198;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
			if(player4StartWaypoint+diceSideThrown == 174){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[216].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 216;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
			if(player4StartWaypoint+diceSideThrown == 182){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[210].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 210;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
			//Ular 4
            if(player4StartWaypoint+diceSideThrown == 45){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[17].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 17;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 55){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[4].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 4;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 71){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[44].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 44;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 87){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[31].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 31;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 98){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[21].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 21;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 116){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[84].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 84;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 135){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[110].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 110;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 150){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[92].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 92;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 154){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[119].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 119;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 170){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[144].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 144;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 183){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[175].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 175;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 197){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[168].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 168;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 203){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[190].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 190;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if (player4StartWaypoint + diceSideThrown == 215)
            {
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[151].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 151;
                player4.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(4);
            }
            if (player4StartWaypoint+diceSideThrown == 221){
                player4.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[188].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 188;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            player4.GetComponent<FollowThePath>().moveAllowed = false;            
            player4StartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex - 1;
        }
        //pl4


        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }
        if (player3.GetComponent<FollowThePath>().waypointIndex ==
            player3.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 3 Wins";
            gameOver = true;
        }
        if (player4.GetComponent<FollowThePath>().waypointIndex ==
            player4.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 4 Wins";
            gameOver = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
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

    public void teleport()
    {
        
            if ((player1.GetComponent<FollowThePath>().waypointIndex) == 8)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 24;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            Debug.Log(player1.GetComponent<FollowThePath>().waypointIndex);
            }
            if ((player1.GetComponent<FollowThePath>().waypointIndex) == 11)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[21].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 21;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            Debug.Log(player1.GetComponent<FollowThePath>().waypointIndex);
        }
            if ((player1.GetComponent<FollowThePath>().waypointIndex) == 15)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[17].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 17;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            Debug.Log(player1.GetComponent<FollowThePath>().waypointIndex);
        }
            if ((player1.GetComponent<FollowThePath>().waypointIndex) == 17)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[45].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 45;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            Debug.Log(player1.GetComponent<FollowThePath>().waypointIndex);
        }
            if ((player1.GetComponent<FollowThePath>().waypointIndex) == 23)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[39].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 39;
                player1.GetComponent<FollowThePath>().waypointIndex += 1;
                MovePlayer(1);
            Debug.Log(player1.GetComponent<FollowThePath>().waypointIndex);
        }
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }
    
}
