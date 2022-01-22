using Godot;

namespace WhoIsHunting.game.lights
{
	public class FlashingLight : SpotLight
	{
		private Timer _timer;
		private RandomNumberGenerator _randomNumberGenerator;

		public override void _Ready()
		{
			_timer = new Timer();
			_randomNumberGenerator = new RandomNumberGenerator();
			_timer.WaitTime = _randomNumberGenerator.RandfRange(0.05f, 0.1f);
			_timer.Connect("timeout", this, "OnTimerTimeout");
			AddChild(_timer);
			_timer.Start();
		}

		private void OnTimerTimeout()
		{
			_timer.WaitTime = _randomNumberGenerator.RandfRange(0.05f, 0.1f);
			LightEnergy = _randomNumberGenerator.RandfRange(0.0f, 1.0f);
		}
	}
}
