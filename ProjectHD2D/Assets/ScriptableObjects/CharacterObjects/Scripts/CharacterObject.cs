using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    Human,
    Demon,
    Monster
}
public class CharacterObject : ScriptableObject
{
    int life;
    int mana;
    

    public CharacterType type;

    public int GetLife()
    {
        return life;
    }
    public void SetLife(int life)
    {
        this.life = life;
    }
    public int GetMana()
    {
        return mana;
    }
    public void SetMana(int mana)
    {
        this.mana = mana;
    }
    public void IncreaseLife(int life)
    {
        this.life += life;
    }
    public void DecreaseLife(int life)
    {
        this.life -= life;
    }
    public void IncreaseMana(int mana)
    {
        this.mana += mana;
    }
    public void DecreaseMana(int mana)
    {
        this.mana -= mana;
    }
}
