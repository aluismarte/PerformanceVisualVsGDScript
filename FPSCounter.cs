using System;
using Godot;

public class FPSCounter : Label
{
    private ulong _startTime;
    private float _maxFps;
    private float _fps;

    private int _count;

    public override void _Ready()
    {
        _startTime = OS.GetSystemTimeSecs();
    }

    public override void _Process(float delta)
    {
        var timeFps = Performance.GetMonitor(Performance.Monitor.TimeFps);
        if (_maxFps < timeFps)
        {
            _maxFps = timeFps;
        }

        OS.GetUnixTime();
        _count++;
        _fps += timeFps;
        Text = "FPS: " + timeFps + " -- Running Time: " + (OS.GetSystemTimeSecs() - _startTime + " Seconds");
    }

    public override void _ExitTree()
    {
        Console.Out.WriteLine("Run Time: " + (OS.GetSystemTimeSecs() - _startTime));
        Console.Out.WriteLine("Max FPS: " + _maxFps);
        Console.Out.WriteLine("FPS Average: " + (_fps / _count));
    }
}