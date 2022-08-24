using UnityEngine;

[CreateAssetMenu(fileName = "Unit Config", menuName = "ScriptableObjects/Unit Config", order = 0)]
public class Unit : ScriptableObject { 
    public Faction _faction;
    [SerializeField]private UnitStats _stats;
    public UnitStats BaseStats => _stats;
    public UnitBase unitPrefab;
    public Projectile _projectile;
    
}
