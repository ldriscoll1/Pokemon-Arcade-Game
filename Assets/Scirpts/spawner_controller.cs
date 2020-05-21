using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_controller : MonoBehaviour
{
    private System.Random random;
    public GameObject overworldCamera;
    public GameObject battleCamera;
    public GameObject battleUI;
    public GameObject winScreen;
    public float spawnChance;
    // Start is called before the first frame update
    void Start()
    {
        
        random = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.tag=="Player")
        {
            if (spawnChance * 100 >= random.Next(1, 101))
            {
                //Enter Battle by
                Battle battle = new Battle(overworldCamera, battleCamera,battleUI,winScreen);
                battle.startBattle();

            }
        }
    }
}
