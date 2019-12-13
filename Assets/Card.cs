using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private Sprite[] cards, cardM;
    private SpriteRenderer rend, rendKm;
    public static int whosTurn = 1;
    private bool coroutineAllowed = true;
    GameObject kartuMuncul;
    public int kartuTerima = 0;
    // Start is called before the first frame update
    void Start()
    {
        whosTurn = 1;
        rend = GetComponent<SpriteRenderer>();
        cards = Resources.LoadAll<Sprite>("Card/");
        //rend.sprite = cards[0];

        kartuMuncul = GameObject.Find("KartuMuncul");
        rendKm = kartuMuncul.gameObject.GetComponent<SpriteRenderer>();
        cardM = Resources.LoadAll<Sprite>("Card/");
        rendKm.sprite = cardM[3];
    }
 
    public IEnumerator RollTheCard()
    {
        coroutineAllowed = false;
        int randomCard = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomCard = Random.Range(0, 4);

            rendKm.sprite = cardM[randomCard];
            yield return new WaitForSeconds(0.01f);
        }
        kartuTerima = randomCard;
        ButtonControl.cardIndex = randomCard;
        Debug.Log("kartu index "+randomCard);
        coroutineAllowed = true;
    }

    public void renderKartuAktif()
    {
        rend.sprite = cards[kartuTerima];
    }


}
