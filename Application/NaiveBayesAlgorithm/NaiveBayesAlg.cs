using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveBayesAlgorithm
{
    class NaiveBayesAlg
    {
        private int i = 0, j = 0, k = 0;    // broj elemenata u svakoj klasi(Iris-setosa, Iris-versicolor, Iris-virginica)

        // funkcija je namenjena za ucitavanje podataka iz fajla
        private string[] loadIrisDataset()
        {
            string filename = @"iris_data.txt"; // NaiveBayesAlgorithm\bin\Debug

            string[] lines = System.IO.File.ReadAllLines(filename); // jedan red iz fajla je jedan element niza tipa string

            return lines;
        }

        // funkcija je namenjena za razvrstavanje uzoraka po klasama
        private string[,] separateByClass(string[] irisDataset)
        {

            string[,] separatedDataByClass = new string[3, 50];

            foreach(string row in irisDataset)
            {
                if (row.Contains("Iris-setosa"))
                {
                    separatedDataByClass[0, i++] = row;
                }
                if (row.Contains("Iris-versicolor"))
                {
                    separatedDataByClass[1, j++] = row;
                }
                if (row.Contains("Iris-virginica"))
                {
                    separatedDataByClass[2, k++] = row;
                }
            }
                       
            return separatedDataByClass;
        }

        // funkcija je namenjena za racunanje srednje vrednosti
        private double mean(double[] numbers)
        {
            double sum = 0.0;
            int counter = 0;

            foreach (double number in numbers)
            {
                sum += number;
                counter++;
            }

            return sum / counter;
        }

        // funkcija je namenjena za racunanje standardne devijacije
        private double stdev(double[] numbers)
        {
            double average = mean(numbers);
            double standardDeviation = 0.0;
            int counter = 0;

            foreach (double num in numbers)
            {
                standardDeviation += Math.Pow((num - average), 2);
                counter++;
            }

            return Math.Sqrt(standardDeviation / counter);
        }

        // funkcija je namenjena za racunanje statistickih podataka
        private double[,] summarizeDataset(string[,] separatedDataByClass, int x)
        {
            int q = 0;
            double[] sepalLength = new double[50];
            double[] sepalWidth = new double[50];
            double[] petalLength = new double[50];
            double[] petalWidth = new double[50];
            double[,] result = new double[4,3];

            switch(x)
            {
                case 0:
                    q = i;
                    break;
                case 1:
                    q = j;
                    break;
                case 2:
                    q = k;
                    break;
            }

            for(int u = 0; u < q; u++)
            {
                int z = 0, c = 0;
                string sl = "";
                string sw = "";
                string pl = "";
                string pw = "";
                string row = separatedDataByClass[x,u];
                bool state = true;

                while (state)
                {
                    if (!row[z].Equals(','))
                    {
                        switch (c) {
                            case 0:
                                if (row[z].Equals('.'))
                                    sl += ',';
                                else
                                    sl += row[z];
                                break;
                            case 1:
                                if (row[z].Equals('.'))
                                    sw += ',';
                                else
                                    sw += row[z];
                                break;
                            case 2:
                                if (row[z].Equals('.'))
                                    pl += ',';
                                else
                                    pl += row[z];
                                break;
                            case 3:
                                if (row[z].Equals('.'))
                                    pw += ',';
                                else
                                    pw += row[z];
                                break;
                            case 4:
                                state = false;
                                break;
                        }
                    }
                    else
                    {
                        c++;
                    }
                    z++;
                }

                sepalLength[u] = double.Parse(sl);
                sepalWidth[u] = double.Parse(sw);
                petalLength[u] = double.Parse(pl);
                petalWidth[u] = double.Parse(pw);
            }

            result[0,0] = mean(sepalLength);
            result[0,1] = stdev(sepalLength);
            result[0,2] = q;

            result[1,0] = mean(sepalWidth);
            result[1,1] = stdev(sepalWidth);
            result[1,2] = q;

            result[2,0] = mean(petalLength);
            result[2,1] = stdev(petalLength);
            result[2,2] = q;

            result[3,0] = mean(petalWidth);
            result[3,1] = stdev(petalWidth);
            result[3,2] = q;

            return result;
        }

        // funkcija je namenjena za pozivanje funkcije „summarizeDataset“
        private double[,] summarizeByClass(string[,] separated, int x)
        {
            return summarizeDataset(separated, x);
        }

        // funkcija je namenjena za racunanje verovatnoce, primenom Gausove funkcija gustine verovatnoce
        private double calculateProbability(double x, double mean, double stdev)
        {
            double exponent = Math.Exp(-(Math.Pow((x-mean), 2)/(2 * Math.Pow(stdev, 2))));

            return (1 / (Math.Sqrt(2 * Math.PI) * stdev)) * exponent;
        }

        // funkcija je namenjena za racunanje verovatnoce za svaku klasu(pomocu funkcije "calculateProbability")
        private double[] calculateClassProbabilities(double[,] summaries1, double[,] summaries2, double[,] summaries3, double sepalLength, double sepalWidth, double petalLength, double petalWidth)
        {
            int total_rows = (int)(summaries1[0,2] + summaries2[0,2] + summaries3[0,2]);

            double[] probabilities = new double[3];
            probabilities[0] = summaries1[0,2] / (double)total_rows;
            probabilities[1] = summaries2[0,2] / (double)total_rows;
            probabilities[2] = summaries3[0,2] / (double)total_rows;

            probabilities[0] *= calculateProbability(sepalLength, summaries1[0,0], summaries1[0,1]);
            probabilities[0] *= calculateProbability(sepalWidth, summaries1[1,0], summaries1[1,1]);
            probabilities[0] *= calculateProbability(petalLength, summaries1[2,0], summaries1[2,1]);
            probabilities[0] *= calculateProbability(petalWidth, summaries1[3,0], summaries1[3,1]);

            probabilities[1] *= calculateProbability(sepalLength, summaries2[0,0], summaries2[0,1]);
            probabilities[1] *= calculateProbability(sepalWidth, summaries2[1,0], summaries2[1,1]);
            probabilities[1] *= calculateProbability(petalLength, summaries2[2,0], summaries2[2,1]);
            probabilities[1] *= calculateProbability(petalWidth, summaries2[3,0], summaries2[3,1]);

            probabilities[2] *= calculateProbability(sepalLength, summaries3[0,0], summaries3[0,1]);
            probabilities[2] *= calculateProbability(sepalWidth, summaries3[1,0], summaries3[1,1]);
            probabilities[2] *= calculateProbability(petalLength, summaries3[2,0], summaries3[2,1]);
            probabilities[2] *= calculateProbability(petalWidth, summaries3[3,0], summaries3[3,1]);
            
            return probabilities;
        }

        // funkcija je namenjena za predvidjanje vrste biljke Irisa na osnovu izracunate verovatnoce
        private int predict(double[,] summaries1, double[,] summaries2, double[,] summaries3, double sepalLength, double sepalWidth, double petalLength, double petalWidth)
        {
            double[] probabilities = calculateClassProbabilities(summaries1, summaries2, summaries3, sepalLength, sepalWidth, petalLength, petalWidth);

            if (probabilities[0] > probabilities[1] && probabilities[0] > probabilities[2])
            {
                return 0;   // Iris-Setosa
            }
            else if(probabilities[1] > probabilities[0] && probabilities[1] > probabilities[2])
            {
                return 1;   // Iris-versicolor
            }
            else if (probabilities[2] > probabilities[0] && probabilities[2] > probabilities[1])
            {
                return 2;   // Iris-virginica
            }

            return 3;
        }

        // prva funkcija koja se poziva i koja vraca rezultat predvidjanja vrste biljke Irisa
        public string result(double sepalLength, double sepalWidth, double petalLength, double petalWidth)
        {
            string result = "Result: ";

            string[] irisDataset = loadIrisDataset();

            string[,] separated = separateByClass(irisDataset);

            double[,] summaries1 = summarizeByClass(separated, 0);
            double[,] summaries2 = summarizeByClass(separated, 1);
            double[,] summaries3 = summarizeByClass(separated, 2);

            switch(predict(summaries1, summaries2, summaries3, sepalLength, sepalWidth, petalLength, petalWidth))
            {
                case 0:
                    result += "Iris-Setosa";
                    break;
                case 1:
                    result += "Iris-versicolor";
                    break;
                case 2:
                    result += "Iris-virginica";
                    break;
                default:
                    result += "Unknown";
                    break;
            }

            return result;
        }
    }
}
