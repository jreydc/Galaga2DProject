using UnityEngine;

[CreateAssetMenu(fileName = "Unit Config", menuName = "ScriptableObjects/Unit Config", order = 0)]
public class Unit : ScriptableObject { 
    public float maxHealthPoints;
    public float currentHealthPoints;
    public float maxLifePoints;
    public float currentLifePoints;
    public string skills;
}
