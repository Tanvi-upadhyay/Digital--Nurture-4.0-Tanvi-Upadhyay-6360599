using System;

public class Forecast
{
  // Recursive method to predict future value without memoization
  public static double PredictValue(double[] data, int years)
  {
    if (years == 0)
      return data[data.Length - 1];

    double lastValue = data[data.Length - 1];
    double secondLastValue = data[data.Length - 2];
    double growthRate = (lastValue - secondLastValue) / secondLastValue;

    return PredictValue(data, years - 1) * (1 + growthRate);
  }

  // Optimized with memoization
  public static double PredictValueMemoized(double[] data, int years, double[] memo)
  {
    if (memo[years] != 0)
      return memo[years];

    if (years == 0)
      return data[data.Length - 1];

    double lastValue = data[data.Length - 1];
    double secondLastValue = data[data.Length - 2];
    double growthRate = (lastValue - secondLastValue) / secondLastValue;

    memo[years] = PredictValueMemoized(data, years - 1, memo) * (1 + growthRate);
    return memo[years];
  }
}
