using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public float Health = 100f;
    public Health1 healthbar;
    public GameObject player;
    public Slider slider;
    public GameObject gameOverScreen;

    public void TakeDamage(float amount)
    {
        healthbar.SetHealth(Health);
        Health -= amount;
        if (Health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        gameOverScreen.SetActive(true);
    }
    void Update()
    {
        slider.value = Health;
        healthbar.SetHealth(Health);
        if(player.transform.position.y <= -30f)
        {
            Die();
        }
    }
}
