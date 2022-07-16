using LiteNinja.SOEvents;
using UnityEngine;

namespace LiteNinja.Demos.Events
{

    /// <summary>
    /// Every second, this script will emit a "tick" event (GameEvent)
    /// </summary>
    public class Ticker : MonoBehaviour
    {
        [SerializeField]
        private GameEvent tickEvent;
        
        private float _time;
        private bool _isTicking;
        
        private void Update()
        {
            if (!_isTicking) return;
            _time += Time.deltaTime;
            if (!(_time >= 1f)) return;
            _time = 1f - _time;
            tickEvent.Raise();
        }
        
        public void StartTicking()
        {
            _isTicking = true;
            _time = 0f;
        }
        
        public void StopTicking()
        {
            _isTicking = false;
        }
        
    }
}