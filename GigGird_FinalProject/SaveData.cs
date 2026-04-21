using GigGird_FinalProject.Money;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GigGird_FinalProject
{
    public static class SaveData
    {
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        public static void SaveData(IncomeManager manager, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(manager, _options);
            File.WriteAllText(filePath, jsonString);
        }

    }
}
