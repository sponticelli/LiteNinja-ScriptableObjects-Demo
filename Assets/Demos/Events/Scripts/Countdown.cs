using LiteNinja.SOEvents;
using UnityEngine;

namespace LiteNinja.Demos.Events
{
    /// <summary>
    /// MonoBehaviour that count down from a given number of seconds to 0 every time it receives a "tick" event (GameEvent).
    /// When the countdown reaches 0, it will emit a "end" event (GameEvent).
    /// </summary>
    public class Countdown : MonoBehaviour
    {

        [SerializeField]
        private GameEvent endEvent;
        [SerializeField]
        private IntEvent secondsLeftEvent;
        
        [SerializeField]
        private int countdownTime = 10;
        private int _time;
        
        private bool _isCountingDown;
        private bool _isEnded;
        


        public void Reset()
        {
            _time = countdownTime;
            _isEnded = false;
        }

        public void OnTick()
        {
            if (_isEnded) return;
            if (!_isCountingDown)
            {
                _isCountingDown = true;
                Reset();
                secondsLeftEvent.Raise(countdownTime);
                return;
            }
            _time -= 1;
            secondsLeftEvent.Raise(_time <= 0 ? 0 : Mathf.RoundToInt( _time));
            if (_time > 0) return;
            _isEnded = true;
            endEvent.Raise();
        }
    }
}