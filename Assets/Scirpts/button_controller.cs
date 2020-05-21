using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class button_controller : MonoBehaviour
{
    public enum ButtonType
    {
        Fight,
        Run,
        Move,
        StarterFire,
        StarterWater,
        StarterGrass,
        Quit,
        Pause

    }
    public ButtonType buttonType;
    public GameObject overworldCamera;
    public GameObject battleCamera;
    public GameObject starterCamera;
    public GameObject battleUI;
    public GameObject starterButtonContainer;
    public GameObject fightButtonContainer;
    public GameObject moveButtonContainer;
    public GameObject endCamera;
    public GameObject endUI;
    public GameObject battleTextPlayer;
    public Boolean isPaused;
    public GameObject pauseUI;
    public GameObject nonPauseUI;
    public GameObject nonPauseCamera;
    public System.Random random = new System.Random();
    public int buttonNum; // 0-3
    private Move move;
    // Start is called before the first frame update
    void Start()
    {
        battleTextPlayer.SetActive(false);
        if (this.buttonType == ButtonType.Move)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player_controller script = player.GetComponent<player_controller>();
            this.move = script.starter.m_moveList[buttonNum];
            GetComponentInChildren<Text>().text = this.move.m_name;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
        

    }
    public void OnButtonPress()
    {
        //After fight is won ui resets
        if(this.buttonType == ButtonType.Fight)
        {
            fightButtonContainer.gameObject.SetActive(false);
            moveButtonContainer.gameObject.SetActive(true);
            battleTextPlayer.SetActive(false);
        }
        else if (this.buttonType == ButtonType.Run)
        {
            battleCamera.SetActive(false);
            overworldCamera.SetActive(true);
            battleUI.SetActive(false);
            battleTextPlayer.SetActive(false);
        }
        else if (this.buttonType == ButtonType.Move)
        {
            GameObject pokemonPlayer = GameObject.FindGameObjectWithTag("PlayerPokemon");
            pokemon_controller pokemonScript = pokemonPlayer.GetComponent<pokemon_controller>();
            move.useMove(pokemonScript.allyPokemon, pokemonScript.enemyPokemon,0);
            //Enable Battle Text
            battleTextPlayer.SetActive(true);
            if (pokemonScript.allyPokemon.m_stats[6] <= 0)
            {
                battleCamera.SetActive(false);
                overworldCamera.SetActive(false);
                battleUI.SetActive(false);
                endCamera.SetActive(true);
                endUI.SetActive(true);
                //Show gameover
            }
            else if (pokemonScript.enemyPokemon.m_stats[6] <= 0)
            {
                pokemonScript.allyPokemon.m_experience += 40;
                pokemonScript.allyPokemon.checkLevelUp();
                //Win UI showing exp gained
                //Ends battle
                Battle.defeatedPokemon++;
                battleCamera.SetActive(false);
                overworldCamera.SetActive(true);
                battleTextPlayer.SetActive(false);
                battleUI.SetActive(false);
                if(Battle.defeatedPokemon==26)
                {
                    Battle.winScreen.SetActive(true);
                    overworldCamera.SetActive(false);
                }
            }
            //Random number to choose enemy attack
            int enemyMovePosistion = random.Next(1, 4);
            Move enemyMove = pokemonScript.enemyPokemon.m_moveList[enemyMovePosistion];
            battleTextPlayer.GetComponentInChildren<Text>().text = pokemonScript.enemyPokemon.m_name+" has used "+ pokemonScript.enemyPokemon.m_moveList[enemyMovePosistion].m_name;
            enemyMove.useMove(pokemonScript.allyPokemon, pokemonScript.enemyPokemon, 1);
            if (pokemonScript.allyPokemon.m_stats[6]<=0)
            {
                battleCamera.SetActive(false);
                overworldCamera.SetActive(false);
                battleUI.SetActive(false);
                endCamera.SetActive(true);
                endUI.SetActive(true);
                //Show gameover
            }
            fightButtonContainer.gameObject.SetActive(true);
            moveButtonContainer.gameObject.SetActive(false);
        }
        //Gives Starter to Player if depending which pokemon they choose
        else if (this.buttonType == ButtonType.StarterFire)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player_controller script = player.GetComponent<player_controller>();
            script.starter = Battle.starters[0];
            starterButtonContainer.SetActive(false);
            starterCamera.SetActive(false);
            overworldCamera.SetActive(true);
        }
        else if (this.buttonType == ButtonType.StarterWater)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player_controller script = player.GetComponent<player_controller>();
            script.starter = Battle.starters[1];
            starterButtonContainer.SetActive(false);
            starterCamera.SetActive(false);
            overworldCamera.SetActive(true);
        }
        else if (this.buttonType == ButtonType.StarterGrass)
        {

            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player_controller script = player.GetComponent<player_controller>();
            script.starter = Battle.starters[2];
            starterButtonContainer.SetActive(false);
            starterCamera.SetActive(false);
            overworldCamera.SetActive(true);

        }
        else if(this.buttonType == ButtonType.Quit)
        {
            Application.Quit();
        }
        else if (this.buttonType == ButtonType.Pause)
        {

            if(isPaused)
            {
                pauseUI.SetActive(false);
                nonPauseUI.SetActive(true);
                nonPauseCamera.SetActive(true);
                Time.timeScale = 1f;
                this.GetComponentInChildren<Text>().text = "Pause";
                isPaused = false;
            }
            else
            {
                pauseUI.SetActive(true);
                nonPauseUI.SetActive(false);
                nonPauseCamera.SetActive(false);
                this.GetComponentInChildren<Text>().text = "Resume";
                Time.timeScale = 0f;
                isPaused = true;
            }
            
        }
    }

}
