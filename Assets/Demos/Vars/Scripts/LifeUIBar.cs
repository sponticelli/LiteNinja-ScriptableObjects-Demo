using System;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

namespace LiteNinja.SOVars.Demo
{
    public class LifeUIBar : MonoBehaviour
    {
        [Header("Variables")] 
        [SerializeField] private IntVar _health; // Used to set the max value of the bar.
        private int _maxHealth;
  
        
        [Header("UI")]
        [SerializeField] Image _bar; // The bar that will be filled.

        private void OnEnable()
        {
            _maxHealth = _health.InitialValue;
            if (!_bar) _bar = GetComponent<Image>();
     
            UpdateUI(_maxHealth);
        }
        
        public void UpdateUI(int value)
        {
            _bar.fillAmount = value / (float)_maxHealth;
        }
    }
}