using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player_Knight/player_KnightStats")]
public class playerStats : ScriptableObject
{
    public float health;
    public float moveSpeed;
    public float attackDamage;
}
