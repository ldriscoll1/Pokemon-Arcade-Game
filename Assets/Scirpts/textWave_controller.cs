using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textWave_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Battle.wave != 6)
        {
            GetComponent<Text>().text = "Wave: " + Battle.wave + "\n Defeated Pokemon: " + Battle.defeatedPokemon;

        }
        else
        {
            GetComponent<Text>().text = "Wave: Final Wave" + "\n Defeated Pokemon: "+ Battle.defeatedPokemon;
                
        }
    }
}
