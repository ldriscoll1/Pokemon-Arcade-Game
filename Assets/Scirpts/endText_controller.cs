using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text ="GameOver\n Try Again soon \n DefeatedPokemon: "+Battle.defeatedPokemon;
    }
}
