const int numTemperatures = 6;
double[] temperaturesC = new double[numTemperatures];


for (int i = 0; i < numTemperatures; i++)
{
    Console.Write($"Enter temperature {i + 1} in °C: ");
    temperaturesC[i] = double.Parse(Console.ReadLine());
}

// Convert and display temperatures
Console.WriteLine("\nTemperatures:");
for (int i = 0; i < numTemperatures; i++)
{
    double tempC = temperaturesC[i];
    double tempK = tempC + 273.15;
    double tempF = (tempC * 9 / 5) + 32;
    Console.WriteLine($"°C: {tempC}, K: {tempK}, °F: {tempF}");
}