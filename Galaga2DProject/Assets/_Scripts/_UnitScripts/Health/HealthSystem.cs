/* 
Special thanks to the Code Monkey YT channel (https://www.youtube.com/c/CodeMonkeyUnity) for the Health Systems and Health bar

https://www.youtube.com/watch?v=Gtw7VyuMdDc
https://www.youtube.com/watch?v=0T5ei9jN63M
 */

using System;
public class HealthSystem
{
    public event EventHandler OnHealthChanged;
    private float health;
    private float healthMax;

    public HealthSystem(float healthMax){
        this.healthMax = healthMax;
        health = healthMax;
    }

    public float GetHealth(){
        return health;
    }

    public float GetHealthPercent(){
        return health / healthMax;
    }

    public void Damage(float damageAmount){
        health -= damageAmount;
        if (health < 0) health = 0;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }

    public void Heal(float healAmount){
        health += healAmount;
        if (health > healthMax) health = healthMax;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }
}
