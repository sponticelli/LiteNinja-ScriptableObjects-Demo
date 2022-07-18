using TMPro;
using UnityEngine;


namespace LiteNinja.SOVars.Demo
{


    public class LifeUIText : MonoBehaviour
    {
        [Header("Variables")] 
        [SerializeField] private IntVar _playerLife; //used to get the initial player life
        
        [Header("UI")]
        [SerializeField] private TMP_Text _lifeText; //used to display the player life
        
        public void OnEnable()
        {
            if (!_lifeText) _lifeText = GetComponent<TMP_Text>();
            UpdateUI(_playerLife ? _playerLife.InitialValue : 0);
        }

        public void UpdateUI(int lives)
        {
            _lifeText.text = "LIVES: " + lives;
        }
    }
}