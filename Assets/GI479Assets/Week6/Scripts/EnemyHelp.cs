using UnityEngine;
using UnityEngine.Events;

public class EnemyHelp : MonoBehaviour
{
    public float maxhealth = 100f;
    
    public UnityEvent OnTakeDamage;
    public UnityEvent OnDeath;
    
    private float currenthealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currenthealth = maxhealth;
        
    }

    public void TakeDamage(float damageAmount)
    {
        if (!isDead())
        {
            OnTakeDamage.Invoke();
            if (isDead())
            {
                OnDeath.Invoke();
            }
        }
    }

    public bool isDead()
    {
        return currenthealth <= 0;
    }
}
