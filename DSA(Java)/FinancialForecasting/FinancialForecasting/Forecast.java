
// class FinancialForecast {

//     static double forecast(double currentValue, double growthRate, int years) {
//         if (years == 0) return currentValue;
//         return forecast(currentValue * (1 + growthRate), growthRate, years - 1);
//     }

//     public static void main(String[] args) {
//         double result = forecast(1000, 0.05, 5);
//         System.out.println("Forecasted value: " + result);
//     }
// }
public class Forecast {
    // Recursive method to forecast future value
    public double predictFutureValue(double currentValue, double growthRate, int years) {
        if (years == 0) return currentValue;
        return predictFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
    }
}
