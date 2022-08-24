using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private HealthSystem healthSystem;
    public void HealthSetUp(HealthSystem healthSystem){
        this.healthSystem = healthSystem;

        healthSystem.OnHealthChanged += HealthSystem_OnHealthChanged;
    }

    private void HealthSystem_OnHealthChanged(object sender, System.EventArgs e){
        //throw new System.NotImplementedException();
        transform.Find("HealthBarContainer").localScale = new Vector3(healthSystem.GetHealthPercent(), 1); 
    }
}
