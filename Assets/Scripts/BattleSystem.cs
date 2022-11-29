using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI playerLabel;
    [SerializeField]
    private TextMeshProUGUI enemyLabel;
    [SerializeField]
    private TextMeshProUGUI attackLabel;

    private int damageDealt = 0;
    private int attackPower = 0;
    private int playerHP = 0;
    private int enemyHP = 0;

    private void Start()
    {
        playerHP = 100;
        enemyHP = 100;
    }

    public void UpdatePlayerHealth()
    {
        int damageTaken = Random.Range(0, 30);
        playerHP -= damageTaken;

        if (playerHP < 0)
            playerHP = 0;

        playerLabel.text = playerHP.ToString();
    }

    public void UpdateEnemyHealth()
    {
        enemyHP -= damageDealt;
        enemyLabel.text = enemyHP.ToString();
    }

    public void CalculateDamage(TMP_Dropdown dropdown)
    {
        damageDealt = 0;
        attackPower = 0;
        switch (dropdown.value)
        {
            case 0:
                damageDealt = Attack();
                break;
            case 1:
                damageDealt = MultipleOfThree();
                break;
            case 2:
                damageDealt = MultipleOfFour();
                break;
            case 3:
                damageDealt = MultipleOfFive();
                break;
            case 4:
                damageDealt = MultipleOfSeven();
                break;
            case 5:
                damageDealt = Prime();
                break;
        }

        attackLabel.text = attackPower.ToString();
        UpdateEnemyHealth();
        UpdatePlayerHealth();
    }

    private int Attack()
    {
        attackPower = 1;
        return 2 * attackPower;
    }

    private int MultipleOfThree()
    {
        attackPower = 2;
        if (enemyHP % 3 == 0)
            return 3 * attackPower;
        return 0;
    }
    private int MultipleOfFour()
    {
        attackPower = 3;
        if (enemyHP % 4 == 0)
            return 4 * attackPower;
        return 0;
    }
    private int MultipleOfFive()
    {
        attackPower = 4;
        if (enemyHP % 5 == 0)
            return 5 * attackPower;
        return 0;
    }
    private int MultipleOfSeven()
    {
        attackPower = 5;
        if (enemyHP % 7 == 0)
            return 7 * attackPower;
        return 0;
    }
    private int Prime()
    {
        attackPower = 6;
        return 0;
    }
}
