using Imc.Models;

namespace Imc;

public static class AppState
{
    public static List<ImcData> History { get; set; } = new();
    public static event EventHandler<EventArgs>? OnChanged; //Aquele que manipula o eevento

    public static void NotifyChanges(object? sender, EventArgs args)
    {
        OnChanged?.Invoke(sender, args);
    }
}