using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject exitPanel;
    public GameObject menuPanel;
    public static GameObject cardMenu, playerMenu;
    public static int cardIndex = 0;

    void Start(){

        cardMenu = GameObject.Find("CardMenu");
        playerMenu = GameObject.Find("PlayerMenu");
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
        cardMenu.SetActive(false);
        playerMenu.SetActive(false);
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(SceneManager.GetActiveScene().name == "Menu"){
                exitPanel.SetActive(true);
            }
            else{
                AdmobScript.instance.showInterstitialAd();
                menuPanel.SetActive(true);
            }
        }
    }
    public void CancelBtn(){
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene("Menu");
        menuPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    public void ResetBtn()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    public void oneP()
    {
        GameControl.nofPlayers = 1;
        SceneManager.LoadScene("Main");
    }

    public void twoP()
    {
        GameControl.nofPlayers = 2;
        SceneManager.LoadScene("Main");
    }

    public void threeP()
    {
        GameControl.nofPlayers = 3;
        SceneManager.LoadScene("Main");
    }

    public void fourP()
    {
        GameControl.nofPlayers = 4;
        SceneManager.LoadScene("Main");
    }
    public void Pone()
    {
        JumpScare.whichPlayer = 1;
        JumpScare jumpS = FindObjectOfType<JumpScare>(); 
        jumpS.jumpS();
        playerMenu.SetActive(false);
    }
    public void Ptwo()
    {
        JumpScare.whichPlayer = 2;
        JumpScare jumpS = FindObjectOfType<JumpScare>();
        jumpS.jumpS();
        playerMenu.SetActive(false);
    }
    public void Pthree()
    {
        JumpScare.whichPlayer = 3;
        JumpScare jumpS = FindObjectOfType<JumpScare>();
        jumpS.jumpS();
        playerMenu.SetActive(false);
    }
    public void Pfour()
    {
        JumpScare.whichPlayer = 4;
        JumpScare jumpS = FindObjectOfType<JumpScare>();
        jumpS.jumpS();
        playerMenu.SetActive(false);
    }
    public void noButton()
    {
        cardMenu.SetActive(false);
    }
   
    public void yesButton()
    {
        if (cardIndex == 3)
        {
            Teleportation teleport = FindObjectOfType<Teleportation>();
            teleport.teleport();
        }
        if (cardIndex == 2)
        {
            Realm real = FindObjectOfType<Realm>();
            real.realm();
        }
        if (cardIndex == 1)
        {
            ForceStaff fStaff = FindObjectOfType<ForceStaff>();
            fStaff.force();
        }
        if (cardIndex == 0)
        {
            playerMenu.SetActive(true);
        }
        Card cd = FindObjectOfType<Card>();
        cd.renderKartuAktif();
        cardMenu.SetActive(false);
    }
    public void OpenUrl(){
        Application.OpenURL("http://raviikmr.github.io/privacy-snakeladder.html");

    }

}
