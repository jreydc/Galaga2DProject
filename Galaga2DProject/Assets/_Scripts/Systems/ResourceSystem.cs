using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// One repository for all scriptable objects. Create your query methods here to keep your business logic clean.
/// </summary>

public class ResourceSystem : MonoBehaviour
{
    public List<UnitBase> units { get; private set; }
    private Dictionary<Faction, UnitBase> _unitDict;

    protected void Awake() {
        AssembleResources();
    }

    private void AssembleResources() {
        units = Resources.LoadAll<UnitBase>("Prefabs").ToList();
        _unitDict = units.ToDictionary(r => r.Faction, r => r);
    }

    public UnitBase GetUnit(Faction t) => _unitDict[t];
    public UnitBase GetRandomHero() => units[Random.Range(0, units.Count)];
}
