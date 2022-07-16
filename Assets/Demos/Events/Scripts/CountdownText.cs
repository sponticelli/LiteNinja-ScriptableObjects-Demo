using System;
using TMPro;
using UnityEngine;

namespace LiteNinja.Demos.Events
{
    /// <summary>
    /// MonoBehaviour that update a TextMesh with the number of seconds left in the countdown in the format "00:00".
    /// </summary>
    public class CountdownText : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _text;

        private void OnEnable()
        {
            if (!_text)
            {
                _text = GetComponent<TMP_Text>();
            }
        }

        private void Start()
        {
            _text.text = "--:--";
        }

        public void UpdateText(int seconds)
        {
            _text.text = $"{seconds / 60:00}:{seconds % 60:00}";
        }
        
    }
}