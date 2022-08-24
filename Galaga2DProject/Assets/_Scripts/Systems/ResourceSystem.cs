using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// One repository for all scriptable objects. Create your query methods here to keep your business logic clean.
/// </summary>

public class ResourceSystem : StaticInstance<ResourceSystem>
{
    private UnitBase unit;
    public UnitBase[] units { get; private set; }
    private Dictionary<Faction, UnitBase> _unitDict;

    protected void Start() {
        AssembleResources();
    }

    private void AssembleResources() {
        units = Resources.LoadAll<UnitBase>("Prefabs/ships");
        //_unitDict = units.ToDictionary(r => r.Faction, r => r);
        foreach(var t in units){
            Debug.Log(t.name);
        }

    }

    public UnitBase GetUnit(Faction t) => _unitDict[t];
    public UnitBase GetRandomHero() => units[Random.Range(0, units.Length)];
}
