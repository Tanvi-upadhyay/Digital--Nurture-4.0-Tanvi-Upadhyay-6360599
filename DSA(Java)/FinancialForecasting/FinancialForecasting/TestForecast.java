// public class TestForecast {
//     public static void main(String[] args) {
//         Forecast f = new Forecast();
//         double current = 1000.0;
//         double growth = 0.1; // 10%
//         int years = 5;

//         System.out.println("Recursive Forecast: " + f.predictFutureValue(current, growth, years));

//         double[] memo = new double[years + 1];
//         System.out.println("Memoized Forecast: " + f.predictWithMemo(current, growth, years, memo));
//     }
// }
public class TestForecast {
    public static void main(String[] args) {
        Forecast f = new Forecast();
        double currentValue = 1000;
        double growthRate = 0.10; // 10%
        int years = 5;

        double futureValue = f.predictFutureValue(currentValue, growthRate, years);
        System.out.println("Future value after " + years + " years: " + futureValue);
    }
}
