using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class battle_controller : MonoBehaviour
{
    public GameObject overworldCamera;
    public GameObject battleCamera;
    public GameObject starterCamera;
    public GameObject StarterUI;
    public GameObject battleUI;
    public GameObject endUI;
    public GameObject endCamera;
    public Sprite[] pokemonSprites;
    public static Sprite[] pokemonStaticSprites;
    private System.Random random;
    // Start is called before the first frame update
    void Start()
    {
        //Changes Sprites from non-static to static
        pokemonStaticSprites = new Sprite[pokemonSprites.Length];
        for (int i = 0; i < pokemonSprites.Length; i++)
        {
            pokemonStaticSprites[i] = pokemonSprites[i];
        }
        //Chooses Starter
        battleCamera.SetActive(false);
        overworldCamera.SetActive(false);
        starterCamera.SetActive(true);
        StarterUI.SetActive(true);
        battleUI.SetActive(false);
        endUI.SetActive(false);
        endCamera.SetActive(false);
        random = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
public class Battle
{

    public static Move[] moveList= { new Move("Tackle", Move.MoveType.Physical, new Type(Type.type.Normal), 50, 20, 1),//0
                              new Move("Recover", Move.MoveType.Defensive, new Type(Type.type.Normal), 20, 0, 1),//1
                              new Move("Fire Blast", Move.MoveType.Special, new Type(Type.type.Fire), 12, 110, 0.75f),//2
                              new Move("FlameThrower", Move.MoveType.Special, new Type(Type.type.Fire), 24, 60, 0.9f),//3
                              new Move("HydroPump", Move.MoveType.Special, new Type(Type.type.Water), 12, 110, 0.75f),//4
                              new Move("Surf", Move.MoveType.Special, new Type(Type.type.Water), 24, 60, 0.9f),//5
                              new Move("Leaf Storm", Move.MoveType.Special, new Type(Type.type.Grass), 12, 110, 0.75f),//6
                              new Move("Leaf Blade", Move.MoveType.Physical, new Type(Type.type.Grass), 24, 60, 0.9f),//7
                              new Move("Thunder", Move.MoveType.Special, new Type(Type.type.Electric), 12, 110, 0.75f),//8
                              new Move("Thunder Punch", Move.MoveType.Physical, new Type(Type.type.Electric), 24, 60, 0.9f),//9
                              new Move("Psychic", Move.MoveType.Special, new Type(Type.type.Psychic), 12, 110, 0.75f),//10
                              new Move("Psybeam", Move.MoveType.Special, new Type(Type.type.Psychic), 24, 60, 0.9f),//11
                              new Move("Blizzard", Move.MoveType.Special, new Type(Type.type.Ice), 12, 110, 0.75f),//12
                              new Move("Ice Beam", Move.MoveType.Special, new Type(Type.type.Ice), 24, 60, 0.9f),//13
                              new Move("Draco Meteor", Move.MoveType.Special, new Type(Type.type.Dragon), 12, 110, 0.75f),//14
                              new Move("Dragon Pulse", Move.MoveType.Special, new Type(Type.type.Dragon), 24, 60, 0.9f),//15
                              new Move("Dark Pulse", Move.MoveType.Special, new Type(Type.type.Dark), 12, 110, 0.75f),//16
                              new Move("Night Slash", Move.MoveType.Physical, new Type(Type.type.Dark), 24, 60, 0.9f),//17
                              new Move("Moonblast", Move.MoveType.Special, new Type(Type.type.Fairy), 12, 110, 0.75f),//18
                              new Move("Dazzling Gleam", Move.MoveType.Special, new Type(Type.type.Fairy), 24, 60, 0.9f),//19
                              new Move("Close Combat", Move.MoveType.Physical, new Type(Type.type.Fighting), 12, 110, 0.75f),//20
                              new Move("Karate Chop", Move.MoveType.Physical, new Type(Type.type.Fighting), 24, 60, 0.9f),//21
                              new Move("Air Slash", Move.MoveType.Special, new Type(Type.type.Flying), 12, 110, 0.75f),//22
                              new Move("WingAttack", Move.MoveType.Physical, new Type(Type.type.Flying), 24, 60, 0.9f),//23
                              new Move("Sludge Bomb", Move.MoveType.Special, new Type(Type.type.Poison), 12, 110, 0.75f),//24
                              new Move("Poison Jab", Move.MoveType.Physical, new Type(Type.type.Poison), 24, 60, 0.9f),//25
                              new Move("Earthquake", Move.MoveType.Physical, new Type(Type.type.Ground), 12, 110, 0.75f),//26
                              new Move("Mud Bomb", Move.MoveType.Special, new Type(Type.type.Ground), 24, 60, 0.9f),//27
                              new Move("Rock Slide", Move.MoveType.Physical, new Type(Type.type.Rock), 12, 110, 0.75f),//28
                              new Move("Rock Throw", Move.MoveType.Physical, new Type(Type.type.Rock), 24, 60, 0.9f),//29
                              new Move("Bug Buzz", Move.MoveType.Special, new Type(Type.type.Bug), 12, 110, 0.75f),//30
                              new Move("Bug Bite", Move.MoveType.Physical, new Type(Type.type.Bug), 24, 60, 0.9f),//31
                              new Move("Shadow Ball", Move.MoveType.Special, new Type(Type.type.Ghost), 12, 110, 0.75f),//32
                              new Move("Lick", Move.MoveType.Physical, new Type(Type.type.Ghost), 24, 60, 0.9f),//33
                              new Move("Steel Beam", Move.MoveType.Special, new Type(Type.type.Steel), 12, 110, 0.75f),//34
                              new Move("Iron Head", Move.MoveType.Special, new Type(Type.type.Steel), 24, 60, 0.9f),//35
                              new Move("Hyper Beam", Move.MoveType.Special, new Type(Type.type.Normal), 12, 110, 0.75f),//36
                              new Move("Body Slam", Move.MoveType.Physical, new Type(Type.type.Normal), 24, 60, 0.9f)//37

    };
    public static AllyPokemon[] starters = { new AllyPokemon(new Move[] { moveList[0], moveList[1], moveList[2], moveList[3] }, new Type(Type.type.Fire), new int[] { 50, 50, 50, 50, 50, 50, 50 }, 30, 50, 0, "Lioness",battle_controller.pokemonStaticSprites[0]),//Fire Starter
                                       new AllyPokemon(new Move[] { moveList[0], moveList[1], moveList[4], moveList[5] }, new Type(Type.type.Water), new int[] { 50, 50, 50, 50, 50, 50, 50 }, 30, 50, 0, "Squidy",battle_controller.pokemonStaticSprites[1]),//Water Starter
                                       new AllyPokemon(new Move[] { moveList[0], moveList[1], moveList[6], moveList[7] }, new Type(Type.type.Grass), new int[] { 50, 50, 50, 50, 50, 50, 50 }, 30, 50, 0, "Dino",battle_controller.pokemonStaticSprites[2])//Grass Starter
    };
    public GameObject overworldCamera;
    public GameObject battleCamera;
    public GameObject battleUI;
    public static GameObject winScreen;
    public static int defeatedPokemon = 0;
    public static int wave = 0;
    public static Boolean startWave = true; 
    private System.Random random = new System.Random();
    public Battle(GameObject camera1, GameObject camera2, GameObject battleUI1, GameObject wScreen)
    {
        overworldCamera = camera1;
        battleCamera = camera2;
        battleUI = battleUI1;
        winScreen = wScreen;
    }
    public void startBattle()
    {
        //Change starter to actual pokemon
        battleCamera.SetActive(true);
        overworldCamera.SetActive(false);
        battleUI.SetActive(true);
        //Changing starterpokemon to GameObject
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player_controller script = player.GetComponent<player_controller>();
        GameObject Playerpokemon = GameObject.FindGameObjectWithTag("PlayerPokemon");
        pokemon_controller pokemonScript = Playerpokemon.GetComponent<pokemon_controller>();
        Playerpokemon.GetComponent<Image>().overrideSprite = script.starter.m_sprite;
        pokemonScript.name = script.starter.m_name;
        pokemonScript.level = script.starter.m_level;
        pokemonScript.stats = script.starter.m_stats;
        pokemonScript.experience = script.starter.m_experience;
        pokemonScript.maxExperience = script.starter.m_maxExperience;
        pokemonScript.moveList = script.starter.m_moveList;
        pokemonScript.type = script.starter.m_type;
        //Changing Enemy to GameObject
        //Checks what wave it is depending on the wave it changes the enemy
        EnemyPokemon enemyPokemon = new EnemyPokemon();
        //Wave 1
        //Pokemon Level 20-25
        //Types Normal, Bug, and Fighting
        if (defeatedPokemon < 5)
        {
            wave = 1;
            int choosePokemon = random.Next(1, 4);
            int lvl = random.Next(20, 26);
            if (choosePokemon == 1)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[30], moveList[31] }, new Type(Type.type.Bug), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Wormy", battle_controller.pokemonStaticSprites[3]);
            }
            else if (choosePokemon == 2)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[21], moveList[20] }, new Type(Type.type.Fighting), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Fighter Joe", battle_controller.pokemonStaticSprites[4]);
            }
            else if (choosePokemon == 3)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[36], moveList[37] }, new Type(Type.type.Normal), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Sciuridae", battle_controller.pokemonStaticSprites[5]);
            }
        }
        //Wave 2
        //Pokemon Level 25-30
        //Types Rock, Steel, and Ground
        else if (defeatedPokemon < 10 && defeatedPokemon >= 5)
        {
            
            wave = 2;
            if (defeatedPokemon == 5 && startWave)
            {
                pokemonScript.stats[6] = pokemonScript.stats[0];
                for (int i = 0; i < 7; i++)
                {
                    pokemonScript.stats[i] += 10;
                }
                pokemonScript.allyPokemon.m_experience+=100;
                pokemonScript.allyPokemon.checkLevelUp();
                startWave = false;
            }
            int choosePokemon = random.Next(1, 4);
            int lvl = random.Next(25, 31);
            if (choosePokemon == 1)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[28], moveList[29] }, new Type(Type.type.Rock), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Rock Man", battle_controller.pokemonStaticSprites[6]);
            }
            else if (choosePokemon == 2)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[34], moveList[35] }, new Type(Type.type.Steel), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Roboto", battle_controller.pokemonStaticSprites[7]);
            }
            else if (choosePokemon == 3)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[26], moveList[27] }, new Type(Type.type.Ground), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Agent Turtle", battle_controller.pokemonStaticSprites[8]);
            }
        }
        //Wave 3
        //Pokemon Level 30-35
        //Types Ice, Electric, and Flying
        else if (defeatedPokemon < 15 && defeatedPokemon >= 10)
        {
            wave = 3;
            if (defeatedPokemon == 10 && !startWave)
            {
                pokemonScript.stats[6] = pokemonScript.stats[0];
                for (int i = 0; i < 7; i++)
                {
                    pokemonScript.stats[i] += 10;
                }
                pokemonScript.allyPokemon.m_experience += 100;
                pokemonScript.allyPokemon.checkLevelUp();
                startWave = true;
            }
            int choosePokemon = random.Next(1, 4);
            int lvl = random.Next(30, 36);
            if (choosePokemon == 1)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[12], moveList[13] }, new Type(Type.type.Ice), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Icy King", battle_controller.pokemonStaticSprites[9]);
            }
            else if (choosePokemon == 2)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[7], moveList[8] }, new Type(Type.type.Electric), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Batteroid", battle_controller.pokemonStaticSprites[10]);
            }
            else if (choosePokemon == 3)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[22], moveList[23] }, new Type(Type.type.Flying), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Porkeet", battle_controller.pokemonStaticSprites[11]);
            }
        }
        //Wave 4
        //Pokemon Level 35-40
        //Types Ghost, Dark, and Poison
        else if (defeatedPokemon < 20 && defeatedPokemon >= 15)
        {
            wave = 4;
            if (defeatedPokemon == 15 && startWave)
            {
                pokemonScript.stats[6] = pokemonScript.stats[0];
                for (int i = 0; i < 7; i++)
                {
                    pokemonScript.stats[i] += 10;
                }
                pokemonScript.allyPokemon.m_experience += 100;
                pokemonScript.allyPokemon.checkLevelUp();
                startWave = false;
            }
            int choosePokemon = random.Next(1, 4);
            int lvl = random.Next(35, 41);
            if (choosePokemon == 1)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[32], moveList[33] }, new Type(Type.type.Ghost), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Tablooo", battle_controller.pokemonStaticSprites[12]);
            }
            else if (choosePokemon == 2)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[16], moveList[17] }, new Type(Type.type.Dark), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Dark Wizard", battle_controller.pokemonStaticSprites[13]);
            }
            else if (choosePokemon == 3)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[24], moveList[25] }, new Type(Type.type.Poison), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Aranid", battle_controller.pokemonStaticSprites[14]);
            }
        }
        //Wave 5
        //Pokemon Level 40-45
        //Types Fairy and Psychic
        else if (defeatedPokemon < 25 && defeatedPokemon >= 20)
        {
            wave = 5;
            if (defeatedPokemon == 20 && !startWave)
            {
                pokemonScript.stats[6] = pokemonScript.stats[0];
                for (int i = 0; i < 7; i++)
                {
                    pokemonScript.stats[i] += 10;
                }
                pokemonScript.allyPokemon.m_experience += 100;
                pokemonScript.allyPokemon.checkLevelUp();
                startWave = true;
            }
            int choosePokemon = random.Next(1, 3);
            int lvl = random.Next(40, 46);
            if (choosePokemon == 1)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[18], moveList[19] }, new Type(Type.type.Fairy), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Cuppy", battle_controller.pokemonStaticSprites[15]);
            }
            else if (choosePokemon == 2)
            {
                enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[10], moveList[11] }, new Type(Type.type.Psychic), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Monka", battle_controller.pokemonStaticSprites[16]);
            }
        }
        //Wave 6
        //Pokemon Level 50
        //Types Dragon
        else if (defeatedPokemon == 25)
        {
            wave = 6;
            if (defeatedPokemon == 25 && startWave)
            {
                pokemonScript.stats[6] = pokemonScript.stats[0];
                for (int i = 0; i < 7; i++)
                {
                    pokemonScript.stats[i] += 10;
                }
                pokemonScript.allyPokemon.m_experience += 100;
                pokemonScript.allyPokemon.checkLevelUp();
                startWave = false;
            }
            int lvl = 60;
            enemyPokemon = new EnemyPokemon(new Move[] { moveList[0], moveList[1], moveList[14], moveList[15] }, new Type(Type.type.Dragon), new int[] { lvl * 4, lvl * 2 - 10, lvl * 2, lvl * 2 - 10, lvl * 2, lvl * 2, lvl * 4 }, lvl, "Kaito Dragoon", battle_controller.pokemonStaticSprites[17]);
        }
        //Win GameScreen
        //otherwaves
        GameObject Enemypokemon = GameObject.FindGameObjectWithTag("EnemyPokemon");
        pokemon_controller enemyPokemonScript = Enemypokemon.GetComponent<pokemon_controller>();
        Enemypokemon.GetComponent<Image>().overrideSprite = enemyPokemon.m_sprite;
        enemyPokemonScript.name = enemyPokemon.m_name;
        enemyPokemonScript.level = enemyPokemon.m_level;
        enemyPokemonScript.stats = enemyPokemon.m_stats;
        enemyPokemonScript.moveList = enemyPokemon.m_moveList;
        enemyPokemonScript.type = enemyPokemon.m_type;
        pokemonScript.allyPokemon = script.starter;
        pokemonScript.enemyPokemon = enemyPokemon;
    }
}

public class Move
{
    public string m_name;
    private MoveType m_typeOfMove { get; set; }// Like defensive, physical, special 
    private Type m_type { get; set; }// Move type like normal, fire
    public int m_powerPoints;// Amount of times the user can use the move
    private int m_power { get; set; }// Damage move does
    private float m_accuracy { get; set; }//Percent chance of move hitting
    private System.Random m_random = new System.Random();

    public Move()
    {

    }
    public Move(string name, MoveType typeOfMove,Type type, int powerPoints, int power, float accuracy)
    {
        m_name = name;
        m_typeOfMove = typeOfMove;
        m_type = type;
        m_powerPoints = powerPoints;
        m_power = power;
        m_accuracy = accuracy;
    }
    //Attacking pokemon 0 is ally 1 is the enemy
    public void useMove(AllyPokemon allyPokemon, EnemyPokemon enemyPokemon, int attackingPokemon)
    {
        //Check what type of move
        //Attacking
        if (this.m_typeOfMove == MoveType.Physical)
        {
            //Checks if the move hits through accuracy
            if (m_accuracy * 100 >= m_random.Next(1, 101))
            {
                float moveDamage = 0;
                //Ally Pokemon attacks
                if (attackingPokemon == 0)
                {
                    moveDamage = (((((2 * allyPokemon.m_level) / 5f) + 2) * this.m_power * ((allyPokemon.m_stats[1] / (float)enemyPokemon.m_stats[2])) / 50f) + 2)*Type.checkEffectiveness(this.m_type,enemyPokemon.m_type);
                    
                    //Checks for crit 1/16
                    if (m_random.Next(1, 17) == 1)
                    {
                        moveDamage *= 2;
                    }
                    this.m_powerPoints--;
                    enemyPokemon.m_stats[6] -= (int)moveDamage;
                }
                else if(attackingPokemon == 1)
                {
                    moveDamage = (((((2 * enemyPokemon.m_level) / 5f) + 2) * this.m_power * ((enemyPokemon.m_stats[1] / (float)allyPokemon.m_stats[2])) / 50f) + 2) * Type.checkEffectiveness(this.m_type, allyPokemon.m_type)/ 2.5f;
                    
                    //Checks for crit 1/16
                    if (m_random.Next(1, 17) == 1)
                    {
                        moveDamage *= 2;
                    }
                    this.m_powerPoints--;
                    allyPokemon.m_stats[6] -= (int)moveDamage;
                }
            }
        }
        else if (this.m_typeOfMove == MoveType.Special)
        {
            //Checks if the move hits through accuracy
            if (m_accuracy * 100 >= m_random.Next(1, 101))
            {
                float moveDamage = 0;
                //Ally Pokemon attacks
                if (attackingPokemon == 0)
                {
                    moveDamage = (((((2 * allyPokemon.m_level) / 5f) + 2) * this.m_power * ((allyPokemon.m_stats[3] / (float)enemyPokemon.m_stats[4])) / 50f) + 2) * Type.checkEffectiveness(this.m_type, enemyPokemon.m_type);
                    
                    //Checks for crit 1/16
                    if (m_random.Next(1, 17) == 1)
                    {
                        moveDamage *= 2;
                    }
                    this.m_powerPoints--;
                    enemyPokemon.m_stats[6] -= (int)moveDamage;
                }
                else if (attackingPokemon == 1)
                {
                    moveDamage = (((((2 * enemyPokemon.m_level) / 5f) + 2) * this.m_power * ((enemyPokemon.m_stats[3] / (float)allyPokemon.m_stats[4])) / 50f) + 2) * Type.checkEffectiveness(this.m_type, allyPokemon.m_type)/2.5f;
                    
                    //Checks for crit 1/16
                    if (m_random.Next(1, 17) == 1)
                    {
                        moveDamage *= 2;
                    }
                    this.m_powerPoints--;
                    allyPokemon.m_stats[6] -= (int)moveDamage;
                }
                
                
            }
            
        }
        //Defensive
        else if (this.m_typeOfMove == MoveType.Defensive)
        {
            if (attackingPokemon == 0)
            {
                allyPokemon.m_stats[6] += allyPokemon.m_stats[0] / 10;
                if(allyPokemon.m_stats[6]> allyPokemon.m_stats[0])
                {
                    allyPokemon.m_stats[6] = allyPokemon.m_stats[0];
                }
            }
            else if (attackingPokemon == 1)
            {
                enemyPokemon.m_stats[6] += enemyPokemon.m_stats[0] / 8;
                if (enemyPokemon.m_stats[6] > enemyPokemon.m_stats[0])
                {
                    enemyPokemon.m_stats[6] = enemyPokemon.m_stats[0];
                }
            }
        }
    }
        public override string ToString()
    {
        string s = "";
        s += "Name: " + m_name + "\n";
        s += "Type: " + m_type + "\n";
        s += "TypeOfMove: " + m_typeOfMove + "\n";
        s += "PowerPoints: " + m_powerPoints + "\n";
        s += "Power: " + m_power + "\n";
        s += "Accuracy: " + m_accuracy + "\n";
        return s;
    }
    public enum MoveType
    {
        Physical,
        Special,
        Defensive
    }
}
public class Type
{
    public enum type
    {
        Normal,
        Fighting,
        Flying,
        Poison,
        Ground,
        Rock,
        Bug,
        Ghost,
        Steel,
        Fire,
        Water,
        Grass,
        Electric,
        Psychic,
        Ice,
        Dragon,
        Dark,
        Fairy
    }
    public type m_type { get; set; }
    public Type(type type)
    {
        
        m_type = type;
    }
    public override string ToString()
    {
        string s = "";
        s += m_type;
        return s;
    }
    //Method that takes two types and returns what happens when one hits the other
    //Returns the amount the move is multiplied by the type
    //Offensive type is the type that is attacking
    //Defensive type is the type defending
    public static float checkEffectiveness(Type offensiveType, Type defensiveType)
    {
        //Normal
        //SuperEffective:
        //N/A
        //Resists:
        //Rock and Steel
        //No Effect:
        //Ghost
        //Neutral:
        //Remainder of types
        if (offensiveType.m_type == type.Normal)
        {
            //Resist
            if (defensiveType.m_type == type.Rock || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //No Effect
            else if (defensiveType.m_type == type.Ghost)
            {
                return 0;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Fire
        //SuperEffective:
        //Grass, Ice, Bug, and Steel
        //Resists:
        //Fire, Water, Rock, and Dragon
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Fire)
        {
            //Super Effective
            if (defensiveType.m_type == type.Grass || defensiveType.m_type == type.Ice || defensiveType.m_type == type.Bug || defensiveType.m_type == type.Steel)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Water || defensiveType.m_type == type.Rock || defensiveType.m_type == type.Dragon)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Water
        //SuperEffective:
        //Fire, Ground, and Rock
        //Resists:
        //Water, Grass, and Dragon
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Water)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Ground || defensiveType.m_type == type.Rock)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Water || defensiveType.m_type == type.Grass || defensiveType.m_type == type.Dragon)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Electric
        //SuperEffective:
        //Water and Flying
        //Resists:
        //Electric, Grass, and Dragon
        //No Effect:
        //Ground
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Electric)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Water || defensiveType.m_type == type.Flying)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Electric || defensiveType.m_type == type.Grass || defensiveType.m_type == type.Dragon)
            {
                return 1 / 2f;
            }
            //No Effect
            else if (defensiveType.m_type == type.Ground)
            {
                return 0;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Grass
        //SuperEffective:
        //Water, Ground and Rock
        //Resists:
        //Fire, Grass, Poison, Flying, Bug, Dragon, and Steel
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Grass)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Water || defensiveType.m_type == type.Ground || defensiveType.m_type == type.Rock)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Grass || defensiveType.m_type == type.Poison || defensiveType.m_type == type.Flying
                || defensiveType.m_type == type.Bug || defensiveType.m_type == type.Dragon || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Ice
        //SuperEffective:
        //Grass, Ground, Flying, and Dragon
        //Resists:
        //Fire, Water, Ice, and Steel
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Ice)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Grass || defensiveType.m_type == type.Ground || defensiveType.m_type == type.Flying || defensiveType.m_type == type.Dragon)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Water || defensiveType.m_type == type.Ice || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Ice
        //SuperEffective:
        //Grass, Ground, Flying, and Dragon
        //Resists:
        //Fire, Water, Ice, and Steel
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Ice)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Grass || defensiveType.m_type == type.Ground || defensiveType.m_type == type.Flying || defensiveType.m_type == type.Dragon)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Water || defensiveType.m_type == type.Ice || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Fighting
        //SuperEffective:
        //Normal, Ice, Rock, Dark, Steel
        //Resists:
        //Poison, Flying, Psychic, Bug, and Fairy
        //No Effect:
        //Ghost
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Fighting)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Normal || defensiveType.m_type == type.Ice || defensiveType.m_type == type.Rock || defensiveType.m_type == type.Dark || defensiveType.m_type == type.Steel)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Poison || defensiveType.m_type == type.Flying || defensiveType.m_type == type.Psychic || defensiveType.m_type == type.Bug || defensiveType.m_type == type.Fairy)
            {
                return 1 / 2f;
            }
            //No Effect
            else if (defensiveType.m_type == type.Ghost)
            {
                return 0;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Poison
        //SuperEffective:
        //Grass, Fairy
        //Resists:
        //Poison, Ground, Rock, and Ghost
        //No Effect:
        //Steel
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Poison)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Grass || defensiveType.m_type == type.Fairy)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Poison || defensiveType.m_type == type.Ground || defensiveType.m_type == type.Rock || defensiveType.m_type == type.Ghost)
            {
                return 1 / 2f;
            }
            //No Effect
            else if (defensiveType.m_type == type.Steel)
            {
                return 0;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Ground
        //SuperEffective:
        //Fire, Electric, Poison, Rock, and Steel
        //Resists:
        //Grass and Bug
        //No Effect:
        //Flying
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Ground)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Electric || defensiveType.m_type == type.Poison || defensiveType.m_type == type.Rock || defensiveType.m_type == type.Steel)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Grass || defensiveType.m_type == type.Bug)
            {
                return 1 / 2f;
            }
            //No Effect
            else if (defensiveType.m_type == type.Flying)
            {
                return 0;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Flying
        //SuperEffective:
        //Grass, Fighting, and Bug
        //Resists:
        //Electric, Rock and Steel
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Flying)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Grass || defensiveType.m_type == type.Fighting || defensiveType.m_type == type.Bug)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Electric || defensiveType.m_type == type.Rock || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Psychic
        //SuperEffective:
        //Fighting, and Poison
        //Resists:
        //Psychic and Steel
        //No Effect:
        //Dark
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Psychic)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Fighting || defensiveType.m_type == type.Poison)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Psychic || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //No Effect
            else if (defensiveType.m_type == type.Dark)
            {
                return 0;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Bug
        //SuperEffective:
        //Grass, Psychic and Dark
        //Resists:
        //Fire, Fighting, Poison, Flying, Ghost, Steel and Fairy
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Bug)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Grass || defensiveType.m_type == type.Psychic || defensiveType.m_type == type.Dark)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Fighting || defensiveType.m_type == type.Poison || defensiveType.m_type == type.Flying || defensiveType.m_type == type.Ghost
                || defensiveType.m_type == type.Steel || defensiveType.m_type == type.Fairy)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Rock
        //SuperEffective:
        //Fire, Ice, Flying, and Bug
        //Resists:
        //Fighting, Ground, and Steel
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Rock)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Ice || defensiveType.m_type == type.Flying || defensiveType.m_type == type.Bug)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fighting || defensiveType.m_type == type.Ground || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Ghost
        //SuperEffective:
        //Psychic, and Ghost
        //Resists:
        //Dark
        //No Effect:
        //Normal
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Ghost)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Psychic || defensiveType.m_type == type.Ghost)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Dark)
            {
                return 1 / 2f;
            }
            //No Effect
            else if (defensiveType.m_type == type.Normal)
            {
                return 0;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Dragon
        //SuperEffective:
        //Dragon
        //Resists:
        //Steel
        //No Effect:
        //Fairy
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Dragon)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Dragon)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //No Effect
            else if (defensiveType.m_type == type.Fairy)
            {
                return 0;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Dark
        //SuperEffective:
        //Psychic and Ghost
        //Resists:
        //Fighting, Dark, and Fairy
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Dark)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Psychic || defensiveType.m_type == type.Ghost)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fighting || defensiveType.m_type == type.Dark || defensiveType.m_type == type.Fairy)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Steel
        //SuperEffective:
        //Ice, Rock and Fairy
        //Resists:
        //Fire, Water, Electric, and Steel
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Steel)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Ice || defensiveType.m_type == type.Rock || defensiveType.m_type == type.Fairy)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Water || defensiveType.m_type == type.Electric || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //Fairy
        //SuperEffective:
        //Fighting, Dragon and Dark
        //Resists:
        //Fire, Poison, and Steel
        //No Effect:
        //N/A
        //Neutral:
        //Remainder of types
        else if (offensiveType.m_type == type.Fairy)
        {
            //SuperEffective
            if (defensiveType.m_type == type.Fighting || defensiveType.m_type == type.Dragon || defensiveType.m_type == type.Dark)
            {
                return 1.5f;
            }
            //Resist
            else if (defensiveType.m_type == type.Fire || defensiveType.m_type == type.Poison || defensiveType.m_type == type.Steel)
            {
                return 1 / 2f;
            }
            //Neutral
            else
            {
                return 1;
            }
        }
        //If not a type in type
        else
        {
            return -1;
        }
    }
}

