# LiteNinja-ScriptableObjects-Demo
A demo project to show the usage of LiteNinja Scriptable Object architecture libraries

## Demos

### EventDemo
Demo for the [LiteNinja-SOEvents](https://github.com/sponticelli/LiteNinja-SOEvents)
It shows the usage of Scriptable Object Events to decouple the code and creating small classes with single responsibility.
The listening is decoupled from the response to the event, using the listeners

4 Events are created:
- IsTicklingEvent (BoolEvent) is triggered when the user clicks the Start/Pause button.
  - The BoolEventSwitcher on the Start/pause button emits the event when the button is clicked (alternating between true and false).
  - The Start/Pause button listens for it and changes the button label accordingly.
  - The Ticker object listens for it and starts or pauses the timer.
- TickEvent (GameEvent) is triggered every seconds by the Ticker class.
  - The Countdown object listens for it and emits a SecondLeftEvent
- SecondLeftEvent (IntEvent) is triggered every seconds by the Countdown object.
  - The CountdownText object listens for it and changes the label accordingly.
- EndCountdownEvent (GameEvent) is triggered when the Countdown object reaches 0.
  - The CountdownLogic object listens for it and reset the timer.
  - The Ticker object listens for it and stops to emit the TickEvent.
  - The StartButton object listens for it and changes the button label accordingly.
  - The ParticleSystem object listens for it and plays some fireworks.
 