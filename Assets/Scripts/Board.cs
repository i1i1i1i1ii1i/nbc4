using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Transform Cards;
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 16; i++)
        {
            Instantiate(card, this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
