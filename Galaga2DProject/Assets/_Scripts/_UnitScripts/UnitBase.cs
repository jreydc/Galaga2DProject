using UnityEngine;
/// <summary>
/// This will share logic for any unit on the field. Could be friend or foe, controlled or not.
/// Things like taking damage, dying, animation triggers etc
/// </summary>
public class UnitBase : MonoBehaviour
{
    public System.Action killed;
    public UnitAnimator unitAnim82r;
    public UnitStats Stats { get; private set; }

    public virtual void Awake() => unitAnim82r = transform.GetChild(0).gameObject.GetComponent<UnitAnimator>();
    public virtual void SetStats(UnitStats stats) => Stats = stats;

    public virtual void TakeDamage(int dmg) {
        //Override this to do some specific logic to each units.
    }
}
