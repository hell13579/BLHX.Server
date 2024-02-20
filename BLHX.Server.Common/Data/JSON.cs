﻿using System.Text.Json;

namespace BLHX.Server.Common.Data;

public static class JSON
{
    public static string ConfigPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.json");
    public static string ShareConfigPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\sharecfgdata\\");

    public static T Load<T>(string path, bool create = true) where T : new()
    {
        if (!File.Exists(path) && create)
        {
            T obj = new T();
            Save(path, obj);
        }

        return JsonSerializer.Deserialize<T>(File.ReadAllText(path));
    }

    public static void Save<T>(string path, T obj)
    {
        File.WriteAllText(path, JsonSerializer.Serialize(obj, new JsonSerializerOptions()
        {
            WriteIndented = true
        }));
    }

    public static string Stringify<T>(T obj)
    {
        return JsonSerializer.Serialize(obj, new JsonSerializerOptions()
        {
            WriteIndented = true
        });
    }
}