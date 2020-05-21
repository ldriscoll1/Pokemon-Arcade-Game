using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pokemon_controller : MonoBehaviour
{
    public enum TypeOfPokemon
    {
        Ally,
        Enemy
    }
    public string name;
    public Move[] moveList;
    public Type type;
    public int[] stats;// Size 7
    public int level;
    public int maxExperience;
    public int experience;
    public Sprite sprite;
    public TypeOfPokemon typeOfPokemon;
    public AllyPokemon allyPokemon;
    public EnemyPokemon enemyPokemon;
    // Start is called before the first frame update
    void Start()
    {
        if (typeOfPokemon == TypeOfPokemon.Ally)
        {
            allyPokemon = new AllyPokemon(moveList, type, stats, level, maxExperience, experience, name, sprite);
        }
        else if(typeOfPokemon == TypeOfPokemon.Enemy)
        {
            enemyPokemon = new EnemyPokemon(moveList, type, stats, level, name, sprite);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class AllyPokemon
{
    public string m_name;
    public Move[] m_moveList;
    public Type m_type;
    public int[] m_stats;//each index has a different value of the stat 0-HP 1-Attack 2-Defense 3-Sp.Atk 4-Sp.Def 5-Speed 6-Current Health
    public int m_level;
    public int m_maxExperience;
    public int m_experience;
    public Sprite m_sprite;
    public AllyPokemon(Move[] moveList, Type type, int[] stats, int level, int maxExperience, int experience, string name, Sprite sprite)
    {
        m_moveList = moveList;
        m_type = type;
        m_stats = stats;
        m_level = level;
        m_maxExperience = maxExperience;
        m_experience = experience;
        m_name = name;
        m_sprite = sprite;
    }
    public void checkLevelUp()
    {
        while (m_experience >= m_maxExperience)
        {
            //Level increases
            m_level++;
            //Increase all stats by 5
            for (int i = 0; i < 7; i++)
            {
                m_stats[i] += 5;
            }
            m_experience -= m_maxExperience;
            m_maxExperience += 10;
        }
    }
    public override string ToString() 
    {
        string s = "";
        s += "Name: " + m_name + "\n";
        s += "Level: " + m_level +"\n";
        s += "Type: " + m_type + "\n";
        s += "Max Health: " + m_stats[0] + "\n";
        s += "Attack: " + m_stats[1] + "\n";
        s += "Defense: " + m_stats[2] + "\n";
        s += "Special Attack: " + m_stats[3] + "\n";
        s += "Special Defense: " + m_stats[4] + "\n";
        s += "Speed: " + m_stats[5] + "\n";
        s += "Current Health: " + m_stats[6] + "\n";
        s += "Current Experience: " + m_experience + "\n";
        s += "Max Experience: " + m_maxExperience + "\n";
        s += "Move1: " + m_moveList[0] + "\n";
        s += "Move2: " + m_moveList[1] + "\n";
        s += "Move3: " + m_moveList[2] + "\n";
        s += "Move4: " + m_moveList[3] + "\n";
        return s;
    }
}
public class EnemyPokemon
{
    public string m_name;
    public Move[] m_moveList;
    public Type m_type;
    public int[] m_stats;//each index has a different value of the stat 0-HP 1-Attack 2-Defense 3-Sp.Atk 4-Sp.Def 5-Speed
    public int m_level;
    public Sprite m_sprite;

    public EnemyPokemon()
    {

    }
    public EnemyPokemon(Move[] moveList, Type type, int[] stats, int level, string name, Sprite sprite)
    {
        m_moveList = moveList;
        m_type = type;
        m_stats = stats;
        m_level = level;
        m_name = name;
        m_sprite = sprite;
    }
    public override string ToString()
    {
        string s = "";
        s += "Name: " + m_name + "\n";
        s += "Level: " + m_level + "\n";
        s += "Type: " + m_type + "\n";
        s += "Max Health: " + m_stats[0] + "\n";
        s += "Attack: " + m_stats[1] + "\n";
        s += "Defense: " + m_stats[2] + "\n";
        s += "Special Attack: " + m_stats[3] + "\n";
        s += "Special Defense: " + m_stats[4] + "\n";
        s += "Speed: " + m_stats[5] + "\n";
        s += "Current Health: " + m_stats[6] + "\n";
        s += "Move1: " + m_moveList[0] + "\n";
        s += "Move2: " + m_moveList[1] + "\n";
        s += "Move3: " + m_moveList[2] + "\n";
        s += "Move4: " + m_moveList[3] + "\n";
        return s;
    }
}
