using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class experienceBar_controller : MonoBehaviour
{
    public Image experienceBar;
    public string name;
    private GameObject pokemon;
    private pokemon_controller script;
    // Start is called before the first frame update
    void Start()
    {
        pokemon = GameObject.FindGameObjectWithTag(name);
        script = pokemon.GetComponent<pokemon_controller>();
    }

    // Update is called once per frame
    void Update()
    {
        experienceBar.fillAmount = (float)script.experience / script.maxExperience;
    }
}
