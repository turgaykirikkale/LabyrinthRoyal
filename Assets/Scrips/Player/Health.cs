using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Image _healthBar;
    public static float _currentHealth, _maxHealth = 100f;
    float _lerpSpeed;
    public static bool isGameOver;

    void Start()
    {
        _currentHealth = _maxHealth;
        isGameOver = false;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (isGameOver)
        {
            GameOver.isGameOver = true;
        }
        else
        {
            _lerpSpeed = 4f * Time.deltaTime;
            HealthBarFiller();
            ColorChanger();
        }
    }

    void HealthBarFiller()
    {
        _healthBar.fillAmount = Mathf.Lerp(_healthBar.fillAmount, _currentHealth / _maxHealth, _lerpSpeed);
    }

    void ColorChanger()
    {
        Color healthColor = Color.Lerp(Color.red, Color.green, (_currentHealth / _maxHealth));
        _healthBar.color = healthColor;
    }


    public static void Damage(float damagePOints)
    {
        if (_currentHealth > -1)
        {
            _currentHealth -= damagePOints;
        }
        else
        {
            isGameOver = true;
        }

    }

    public static void Heal(float healingPoints)
    {
        if (_currentHealth < _maxHealth)
        {
            _currentHealth += healingPoints;
        }
    }
}
