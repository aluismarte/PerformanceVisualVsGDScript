using System;
using Godot;

public class FPSCounter : Label
{
    private float _maxFps = 0;
    private float _fps = 0;

    private int count = 0;

    public override void _Process(float delta)
    {
        var timeFps = Performance.GetMonitor(Performance.Monitor.TimeFps);
        if (_maxFps < timeFps)
        {
            _maxFps = timeFps;
        }

        count++;
        _fps += timeFps;
        Text = "FPS: " + timeFps;
    }

    public override void _ExitTree()
    {
        Console.Out.WriteLine("Max FPS: " + _maxFps);
        Console.Out.WriteLine("FPS Average: " + (_fps / count));
    }
}