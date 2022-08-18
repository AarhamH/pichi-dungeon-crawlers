using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    protected int currentHealth {get; set;}

    static public bool isDead;

    protected void InitializeHealth(int maxHealth)  {currentHealth = maxHealth;}

    public virtual void TakeDamage(int damage){       
        currentHealth -= damage;

        if(currentHealth <= 0){
            Die();
        }
    }

    public virtual void Die(){
        isDead = true;
        Debug.Log(transform.name + "died");
        Invoke(nameof(DestroyCharacter),2);
    }

    protected void DestroyCharacter(){
        Destroy(gameObject);
    }

    protected void PlayParticleEffects(GameObject effect){
        Instantiate(effect, transform.position,Quaternion.identity);
    }
     
}
