using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textName_controller : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActiveAndEnabled)
        {
            GameObject pokemon = GameObject.FindGameObjectWithTag(name);
            pokemon_controller script = pokemon.GetComponent<pokemon_controller>();
            GetComponent<Text>().text = script.name;
        }
    }
}
