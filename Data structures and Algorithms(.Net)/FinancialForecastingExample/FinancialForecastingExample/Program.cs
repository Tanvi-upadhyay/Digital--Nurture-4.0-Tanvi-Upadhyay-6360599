using System;

class Program
{
  static void Main(string[] args)
  {
    double[] pastValues = { 1000, 1100, 1210 }; // Example growth data (10% yearly)
    int yearsToForecast = 3;

    Console.WriteLine("=== Financial Forecasting ===");
    Console.WriteLine("Past values: " + string.Join(", ", pastValues));

    double predicted = Forecast.PredictValue(pastValues, yearsToForecast);
    Console.WriteLine($"Predicted value after {yearsToForecast} years (recursive): {predicted:F2}");

    double[] memo = new double[yearsToForecast + 1];
    double predictedMemo = Forecast.PredictValueMemoized(pastValues, yearsToForecast, memo);
    Console.WriteLine($"Predicted value after {yearsToForecast} years (memoized): {predictedMemo:F2}");
  }
}
