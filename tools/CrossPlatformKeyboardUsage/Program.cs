using SharpHook;

namespace CrossPlatformKeyboardUsage;

class Program
{
    static void Main(string[] args)
    {
        using var hook = new TaskPoolGlobalHook();
        hook.KeyPressed += OnKeyPressed;
        hook.KeyReleased += OnKeyReleased;
        hook.KeyTyped += OnKeyTyped;
        hook.Run();
    }

    private static void OnKeyPressed(object? sender, KeyboardHookEventArgs e)
    {
        var data = e.Data;
        Console.WriteLine($"Press: char: {data.KeyChar} code: {data.KeyCode} rawchar: {data.RawKeyChar} rawcode: {data.RawCode} all: {data}");
    }

    private static void OnKeyTyped(object? sender, KeyboardHookEventArgs e)
    {
        var data = e.Data;
        Console.WriteLine($"Typed: char: {data.KeyChar} code: {data.KeyCode} rawchar: {data.RawKeyChar} rawcode: {data.RawCode} all: {data}");
    }

    private static void OnKeyReleased(object? sender, KeyboardHookEventArgs e)
    {
        var data = e.Data;
        Console.WriteLine($"Release: char: {data.KeyChar} code: {data.KeyCode} rawchar: {data.RawKeyChar} rawcode: {data.RawCode} all: {data}");
    }

}
