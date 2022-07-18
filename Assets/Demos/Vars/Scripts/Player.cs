using LiteNinja.SOEvents;
using UnityEngine;


namespace LiteNinja.SOVars.Demo
{

    public class Player : MonoBehaviour
    {
        [Header("Variables")]
        [SerializeField] private IntVar _lives;
        [SerializeField] private IntVar _health;
        


        public void OnHealth(int healthVariation)
        {
            
            if (healthVariation< 0)
            {
                OnDamage(healthVariation);
            }
            else
            {
                OnHeal(healthVariation);
            }
        }
        private void OnDamage(int damage)
        {
            _health.Value += damage;
            if (_health.Value > 0) return;
            _health.Value = 0;
            DecreaseLives();
        }
        
        private void OnHeal(int heal)
        {
            _health.Value += heal;
            if (_health.Value > _health.InitialValue)
            {
                _health.Value = 0;
                _lives.Value++;
            }
            if (_lives.Value<=0) _lives.Value = 1;
        }

        private void DecreaseLives()
        {
            _lives.Value--;
            switch (_lives.Value)
            {
                case > 0:
                    _health.SetRuntimeValue(_health.InitialValue);
                    return;
                case < 0:
                    _lives.Value = 0;
                    break;
            }
        }
    }

}