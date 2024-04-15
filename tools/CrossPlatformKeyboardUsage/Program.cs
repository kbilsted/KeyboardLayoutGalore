using SharpHook;

namespace CrossPlatformKeyboardUsage;

class Program
{
    static void Main(string[] args)
    {
        using var hook = new SimpleGlobalHook(GlobalHookType.Keyboard); // new TaskPoolGlobalHook();
        hook.KeyPressed += OnKeyPressed;
        hook.KeyReleased += OnKeyReleased;
        hook.KeyTyped += OnKeyTyped;
        hook.Run();
    }

    private static void OnKeyPressed(object? sender, KeyboardHookEventArgs e)
    {
        var data = e.Data;
        Console.WriteLine($"P: char: {data.KeyChar} code: {data.KeyCode} rawchar: {data.RawKeyChar} rawcode: {data.RawCode} all: {data}");
    }

    private static void OnKeyTyped(object? sender, KeyboardHookEventArgs e)
    {
        var data = e.Data;
        Console.WriteLine($"T: char: {data.KeyChar} code: {data.KeyCode} rawchar: {data.RawKeyChar} rawcode: {data.RawCode} all: {data}");
    }

    private static void OnKeyReleased(object? sender, KeyboardHookEventArgs e)
    {
        var data = e.Data;
        Console.WriteLine($"R: char: {data.KeyChar} code: {data.KeyCode} rawchar: {data.RawKeyChar} rawcode: {data.RawCode} all: {data}");
    }

}
