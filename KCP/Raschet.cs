using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Raschet
    {
        public static string FirstIterat(DateTimePicker Value, int i)
        {
            StreamReader Timet = new StreamReader("Statistics\\BusTimetable.txt");
            string Timetable;
            Timetable = Convert.ToString(Timet.ReadToEnd());
            double[,] G = new double[6, 40];
            string Per;
            string[] Cron = new string[1000];
            Per = "";
            int j = 0;

            for (int k = 0; k < Timetable.Length; k++)
            {
                Per = Per + Convert.ToString(Timetable[i]);
                if (Timetable[i] == Convert.ToChar("\r"))
                {
                    k = k + 1;
                    Cron[j] = Convert.ToString(Per);
                    Per = "";
                    j++;
                }
            }
            //Маршрутка
            if (i < 4)
            {
                for (int k = 0; k < 30; k++)
                {
                    G[i, k] = 6 * 60 + 15 + 30 * k;
                }
            }
            //
            //Ласточка
            //
            if (i == 4)
            {
                G[i, 0] = 8 * 60 + 12;
                G[i, 1] = 8 * 60 + 25;
                G[i, 2] = 8 * 60 + 30;
                G[i, 3] = 8 * 60 + 37;
                G[i, 4] = 8 * 60 + 46;
                G[i, 5] = 8 * 60 + 53;
                G[i, 6] = 9 * 60;
                G[i, 7] = 9 * 60 + 25;
                G[i, 8] = 9 * 60 + 42;
                G[i, 9] = 10 * 60 + 11;
                G[i, 10] = 14 * 60;
                G[i, 11] = 14 * 60 + 10;
                G[i, 12] = 14 * 60 + 13;
                G[i, 13] = 14 * 60 + 21;
                G[i, 14] = 14 * 60 + 30;
                G[i, 15] = 14 * 60 + 38;
                G[i, 16] = 14 * 60 + 45;
                G[i, 17] = 15 * 60 + 10;
                G[i, 18] = 15 * 60 + 27;
                G[i, 19] = 15 * 60 + 56;
                G[i, 20] = 18 * 60;
                G[i, 21] = 18 * 60 + 10;
                G[i, 22] = 18 * 60 + 15;
                G[i, 23] = 18 * 60 + 22;
                G[i, 24] = 18 * 60 + 30;
                G[i, 25] = 18 * 60 + 38;
                G[i, 26] = 18 * 60 + 45;
                G[i, 27] = 19 * 60 + 10;
                G[i, 28] = 19 * 60 + 28;
                G[i, 29] = 19 * 60 + 56;
                G[i, 30] = 20 * 60 + 15;
                G[i, 31] = 20 * 60 + 23;
                G[i, 32] = 20 * 60 + 28;
                G[i, 33] = 20 * 60 + 35;
                G[i, 34] = 20 * 60 + 45;
                G[i, 35] = 20 * 60 + 52;
                G[i, 36] = 20 * 60 + 59;
                G[i, 37] = 21 * 60 + 25;
                G[i, 38] = 21 * 60 + 42;
                G[i, 39] = 22 * 60 + 11;
            }
            //
            //Метробус
            //
            if (i == 5)
            {
                G[5, 0] = 7 * 60;
                G[5, 1] = 13 * 60;
                G[5, 2] = 18 * 60 + 30;
            }
            //
            //
            //Время поездок
            double[] Time = new double[6];
            Time[0] = 2 * 60 + 30;
            Time[1] = 2 * 60 + 47;
            Time[2] = 2 * 60 + 5;
            Time[3] = 2 * 60 + 50;
            Time[4] = 60 + 56;
            Time[5] = 60 + 10;
            //
            //Цена за билет
            double[] Price = new double[6];
            Price[0] = 370;
            Price[1] = 370;
            Price[2] = 370;
            Price[3] = 370;
            Price[4] = 199;
            Price[5] = 179;
            //
            // Время прибытия
            double[,] EndTime = new double[6, 40];

            switch (i)
            {
                case 0:
                    for (j = 0; j < 30; j++)
                    {
                        EndTime[i, j] = G[i, j] + Time[i];
                    }
                    break;
                case 1:
                    for (j = 0; j < 30; j++)
                    {
                        EndTime[i, j] = G[i, j] + Time[i];
                    }
                    break;
                case 2:
                    for (j = 0; j < 30; j++)
                    {
                        EndTime[i, j] = G[i, j] + Time[i];
                    }
                    break;
                case 3:
                    for (j = 0; j < 30; j++)
                    {
                        EndTime[i, j] = G[i, j] + Time[i];
                    }
                    break;
                case 4:
                    for (j = 0; j < 40; j++)
                    {
                        EndTime[i, j] = G[i, j] + Time[i];
                    }
                    break;
                case 5:
                    for (j = 0; j < 3; j++)
                    {
                        EndTime[i, j] = G[i, j] + Time[i];
                    }
                    break;
            }

            /*            for (int i = 0; i < j; i++)
                        {   

                            if (Cron[i] == "№602\r" || Cron[i] == "№652Т\r" || Cron[i] == "№652Д\r" || Cron[i] == "№607\r")
                            {
                                k++;
                            }
                            else
                            {  
                                G[k, i] = Convert.ToDouble(Cron[i].Substring(0) + Cron[i].Substring(1)) * 60 + Convert.ToDouble(Cron[i].Substring(3) + Cron[i].Substring(4));

                            }
                        }
                        Cron.
                       */
            // string Duration = Convert.ToString(Durat.ReadToEnd());
            //            StreamReader Durat = new StreamReader("Statisctics\\TripDuration.txt");

            string X = Value.Value.DayOfWeek.ToString();

            switch (X)
            {
                case "Monday":





                    if (i < 4 && G[i, j] > 300 && G[i, j] < 800)
                    {
                        for (j = 0; j < 30; j++)
                        {
                            EndTime[i, j] = EndTime[i, j] + 14 + j * 0.8;
                        }
                    }
                    else
                    {
                        for (j = 0; j < 30; j++)
                        {
                            EndTime[i, j] = EndTime[i, j] + 63 - j * 1.2;
                        }
                    }

                    break;

                case "Tuesday":

                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 1000 && G[i, j] < 1200)
                        {
                            EndTime[i, j] = EndTime[i, j] + 35 - j * 1.3;
                        }
                    }
                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 300 && G[i, j] < 800)
                        {
                            EndTime[i, j] = EndTime[i, j] + j * 0.9;
                        }
                    }

                    break;

                case "Wednesday":

                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 1000 && G[i, j] < 1200)
                        {
                            EndTime[i, j] = EndTime[i, j] + 41 - j;
                        }
                    }
                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 300 && G[i, j] < 800)
                        {
                            EndTime[i, j] = EndTime[i, j] + j * 0.9;
                        }
                    }

                    break;

                case "Thursday":

                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 1000 && G[i, j] < 1200)
                        {
                            EndTime[i, j] = EndTime[i, j] + 54 - j * 1.6;
                        }
                    }
                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 300 && G[i, j] < 800)
                        {
                            EndTime[i, j] = EndTime[i, j] + j * 1.2 - 4 + 1;
                        }
                    }

                    break;

                case "Friday":

                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 1000 && G[i, j] < 1200)
                        {
                            EndTime[i, j] = EndTime[i, j] + 76 - j / 2;
                        }
                    }
                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 300 && G[i, j] < 800)
                        {
                            EndTime[i, j] = EndTime[i, j] + 3 + j * 1.32;
                        }
                    }

                    break;

                case "Saturday":

                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 1000 || G[i, j] < 1200)
                        {
                            EndTime[i, j] = EndTime[i, j] + 40 - j * 2.3;
                        }
                    }
                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 300 && G[i, j] < 800)
                        {
                            EndTime[i, j] = EndTime[i, j] + j * 0.2;
                        }
                    }

                    break;

                case "Sunday":

                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 1000 && G[i, j] < 1200)
                        {
                            EndTime[i, j] = EndTime[i, j] + 40 - j * 2.512;
                        }
                    }
                    for (j = 0; j < 30; j++)
                    {
                        if (i < 4 && G[i, j] > 300 && G[i, j] < 800)
                        {
                            EndTime[i, j] = EndTime[i, j] + j * 0.2;
                        }
                    }

                    break;
            }
            string min;
            string hour;
            string MarEnd;
            if (i < 5)
            {

                MarEnd = "Время прибытия\n";
                for (int k = 0; k < 30; k++)
                {
                    min = Convert.ToString(EndTime[i, k] % 60);
                    hour = Convert.ToString((EndTime[i, k] - Convert.ToDouble(min)) / 60);
                    min = Convert.ToString(Math.Round(EndTime[i, k] % 60, 0));
                    if (min.Length == 1)
                    {
                        min = "0" + min;
                    }
                    MarEnd = MarEnd + hour + ":" + min + "\n";
                }
            }
            else
            {
                MarEnd = "Время прибытия\n";
                for (int k = 0; k < 3; k++)
                {
                    min = Convert.ToString(EndTime[i, k] % 60);
                    hour = Convert.ToString((EndTime[i, k] - Convert.ToDouble(min)) / 60);
                    min = Convert.ToString(Math.Round(EndTime[i, k] % 60, 0));
                    if (min.Length == 1)
                    {
                        min = "0" + min;
                    }
                    MarEnd = MarEnd + hour + ":" + min + "\n";
                }
            }
            //StreamReader Durat = new StreamReader("Statisctics\\TripDuration.txt");
            return MarEnd;
        }
    }
}