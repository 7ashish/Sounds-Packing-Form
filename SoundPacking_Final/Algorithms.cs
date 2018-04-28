using System;
using System.Collections;
using System.Collections.Generic;

static class Algorithms
{
    static public int Max_Folder_Length;
    
    static public void First_Fit_Decreasing_Algorithm(Pair<string, TimeSpan>[] Line) //O(n*m)
    {

        List<Pair<string, TimeSpan>> Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length,20000)); //O(1)
        Array.Sort(Line);       //O(nlogn) where n = Line.Count
        List<List<Pair<string, TimeSpan>>> FolderList = new List<List<Pair<string, TimeSpan>>>(Math.Min(Line.Length,20000)); //O(1)
        int counter = 0; //O(1) 
        List<double> Seconds = new List<double>(Math.Min(Line.Length,20000)); //O(1) //storing the seconds remaining in each folder.
        //n = FileCount, m = FolderCount
        for (int i = 0; i < Line.Length; i++) // O(n * m) "maximum"
        {
            if (FolderList.Count == 0)  //O(1) //creating new folder if I have no folders.
            {
                Temp.Add(Line[i]); //O(1)
                FolderList.Add(Temp); //O(1)
                Seconds.Add(Line[i].Second.TotalSeconds); //O(1)
                continue;
            }
            if (Max_Folder_Length == Seconds[counter]) //O(1)  //checkes if the folder is full or not 
            {
                if (counter + 1 == FolderList.Count) //O(1) //if the folder is the only folder then we create new folder and put the file on it.
                {
                    counter++; //O(1)
                    Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length,20000)); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1)
                    Seconds.Add(Line[i].Second.TotalSeconds); //O(1)
                    continue;
                }
            }
            if ((Seconds[counter] + Line[i].Second.TotalSeconds) <= Max_Folder_Length) //O(1)
            {
                FolderList[counter].Add(Line[i]); //O(1)
                Seconds[counter] += Line[i].Second.TotalSeconds; //O(1)
                continue;
            }
            if ((Seconds[counter] + Line[i].Second.TotalSeconds) > Max_Folder_Length) //O(m)
            {
                if (counter + 1 == FolderList.Count)//O(1)
                {
                    Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length,20000)); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1)
                    Seconds.Add(Line[i].Second.TotalSeconds); //O(1)
                    continue;
                }
                bool entered = false; //O(1)
                for (int k = 0; k < FolderList.Count; k++) //O(m)
                {
                    if ((Seconds[k] + Line[i].Second.TotalSeconds) <= Max_Folder_Length) //O(1)
                    {
                        FolderList[k].Add(Line[i]); //O(1)
                        Seconds[k] += Line[i].Second.TotalSeconds; //O(1)
                        entered = true; //O(1)
                        break;
                    }
                }
                if (!entered) //O(1)
                {
                    counter++; //O(1)
                    Temp = new List<Pair<string, TimeSpan>>(); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1)
                    Seconds.Add(Line[i].Second.TotalSeconds); //O(1)
                    continue;
                }

            }
        }
        //shrinking lists to the exact count of elements
        foreach (List<Pair<string, TimeSpan>> lp in FolderList) //O(N) while N is the size of Files
        {
            lp.TrimExcess();
        }
        //shrinking folder list
        FolderList.TrimExcess();
        //clearing seconds list because it was never nessecary........
        Seconds.Clear();
       // FileOperations.FinializeDirectory(FolderList);
    }
    static public void Best_Fit_Algorithm(Pair<string, TimeSpan>[] Line) 
    {
        List<Pair<string, TimeSpan>> Temp = new List<Pair<string, TimeSpan>>(Line.Length); //O(1)
        List<List<Pair<string, TimeSpan>>> FolderList = new List<List<Pair<string, TimeSpan>>>(Line.Length); //O(1)
        int counter = 0; //O(1)
        List<double> Seconds = new List<double>(Line.Length); //O(1)
        //n = FileCount, m = FolderCount
        for (int i = 0; i < Line.Length; i++) // O(n * m)
        {
            if (FolderList.Count == 0)  //O(1)
            {
                Temp.Add(Line[i]); //O(1)
                FolderList.Add(Temp); //O(1)
                Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                continue;
            }
            if (FolderList.Count == 1) //O(1)
            {
                if (Line[i].Second.TotalSeconds <= Seconds[counter]) //O(1)
                {
                    FolderList[counter].Add(Line[i]); //O(1)
                    Seconds[counter] -= Line[i].Second.TotalSeconds; //O(1)
                    if (Max_Folder_Length + Seconds[counter] == 0) //O(1)
                    {
                        Temp = new List<Pair<string, TimeSpan>>(Line.Length); //O(1)
                        Temp.Add(Line[i]); //O(1)
                        FolderList.Add(Temp); //O(1)
                        Seconds.Add(100); //O(1)
                        counter++; //O(1)
                    }
                    continue;
                }
                else
                {
                    Temp = new List<Pair<string, TimeSpan>>(Line.Length); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1)
                    Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                    continue;
                }
            }
            bool Done = false; //O(1)
            double min = Max_Folder_Length;  //O(1)
            int index = 0; //O(1)
            for (int k = 0; k < FolderList.Count; k++) //O(N) while N is the number of Folders
            {
                if (Seconds[k] < Line[i].Second.TotalSeconds) //O(1)
                {
                    continue;
                }
                if (Seconds[k] - Line[i].Second.TotalSeconds == Max_Folder_Length) //O(1)
                {
                    FolderList[k].Add(Line[i]); //O(1)
                    Seconds[k] = 0; //O(1)
                    Done = true; //O(1)  
                    if (k == counter) //O(1)
                    {
                        Temp = new List<Pair<string, TimeSpan>>(Line.Length); //O(1)
                        Temp.Add(Line[i]); //O(1)
                        FolderList.Add(Temp); //O(1)
                        Seconds.Add(100); //O(1) 
                        counter++; //O(1)
                    }
                    break;
                }
                if (Seconds[k] - Line[i].Second.TotalSeconds < min) //O(1) 
                {
                    min = Seconds[k] - Line[i].Second.TotalSeconds; //O(1)
                    index = k; //O(1)
                }

            }
            if (!Done) //O(1)
            {
                if (min == Max_Folder_Length) //O(1)
                {
                    Temp = new List<Pair<string, TimeSpan>>(); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1) 
                    Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                    counter++; //O(1)
                }
                else
                {
                    FolderList[index].Add(Line[i]); //O(1)
                    Seconds[index] -= Line[i].Second.TotalSeconds; //O(1)
                    if (Max_Folder_Length + Seconds[counter] == 0) //O(1)
                    {
                        Temp = new List<Pair<string, TimeSpan>>(Line.Length); //O(1)
                        Temp.Add(Line[i]); //O(1)
                        FolderList.Add(Temp); //O(1)
                        Seconds.Add(100); //O(1)
                        counter++; //O(1)
                    }
                }
            }
        }
        //shrinking lists to the exact count of elements
        foreach (List<Pair<string, TimeSpan>> lp in FolderList) //O(N) while N is the number of files
        {
            lp.TrimExcess();
        }
        //shrinking folder list
        FolderList.TrimExcess();
        //clearing seconds list because it was never nessecary........
        Seconds.Clear();
        //FileOperations.FinializeDirectory(FolderList);
    }
    static public void Best_Fit_Decreasing_Algorithm(Pair<string, TimeSpan>[] Line)
    {
        Array.Sort(Line);
        List<Pair<string, TimeSpan>> Temp = new List<Pair<string, TimeSpan>>(Line.Length);
        List<List<Pair<string, TimeSpan>>> FolderList = new List<List<Pair<string, TimeSpan>>>(Line.Length);
        int counter = 0;
        List<double> Seconds = new List<double>(Line.Length);
        //n = FileCount, m = FolderCount
        for (int i = 0; i < Line.Length; i++) // O(n * m)
        {
            if (FolderList.Count == 0)  //O(1)
            {
                Temp.Add(Line[i]);
                FolderList.Add(Temp);
                Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds);
                continue;
            }
            if (FolderList.Count == 1)
            {
                if (Line[i].Second.TotalSeconds <= Seconds[counter])
                {
                    FolderList[counter].Add(Line[i]);
                    Seconds[counter] -= Line[i].Second.TotalSeconds;
                    if (Max_Folder_Length + Seconds[counter] == 0)
                    {
                        Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length,20000));
                        Temp.Add(Line[i]);
                        FolderList.Add(Temp);
                        Seconds.Add(100);
                        counter++;
                    }
                    continue;
                }
                else
                {
                    Temp = new List<Pair<string, TimeSpan>>(Line.Length);
                    Temp.Add(Line[i]);
                    FolderList.Add(Temp);
                    Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds);
                    continue;
                }
            }
            bool Done = false;
            double min = Max_Folder_Length;
            int index = 0;
            for (int k = 0; k < FolderList.Count; k++)
            {
                if (Seconds[k] < Line[i].Second.TotalSeconds)
                {
                    continue;
                }
                if (Seconds[k] - Line[i].Second.TotalSeconds == Max_Folder_Length)
                {
                    FolderList[k].Add(Line[i]);
                    Seconds[k] = 0;
                    Done = true;
                    if (k == counter)
                    {
                        Temp = new List<Pair<string, TimeSpan>>(Line.Length);
                        Temp.Add(Line[i]);
                        FolderList.Add(Temp);
                        Seconds.Add(100);
                        counter++;
                    }
                    break;
                }
                if (Seconds[k] - Line[i].Second.TotalSeconds < min)
                {
                    min = Seconds[k] - Line[i].Second.TotalSeconds;
                    index = k;
                }

            }
            if (!Done)
            {
                if (min == Max_Folder_Length)
                {
                    Temp = new List<Pair<string, TimeSpan>>();
                    Temp.Add(Line[i]);
                    FolderList.Add(Temp);
                    Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds);
                    counter++;
                }
                else
                {
                    FolderList[index].Add(Line[i]);
                    Seconds[index] -= Line[i].Second.TotalSeconds;
                    if (Max_Folder_Length + Seconds[counter] == 0)
                    {
                        Temp = new List<Pair<string, TimeSpan>>(Line.Length);
                        Temp.Add(Line[i]);
                        FolderList.Add(Temp);
                        Seconds.Add(100);
                        counter++;
                    }
                }
            }
        }
        //shrinking lists to the exact count of elements
        foreach (List<Pair<string, TimeSpan>> lp in FolderList)
        {
            lp.TrimExcess();
        }
        //shrinking folder list
        FolderList.TrimExcess();
        //clearing seconds list because it was never nessecary........
        Seconds.Clear();
        //FileOperations.FinializeDirectory(FolderList);
    }
    static public void Worst_Fit_Algorithm(Pair<string, TimeSpan>[] Line)
    {
        List<Pair<string, TimeSpan>> Temp = new List<Pair<string, TimeSpan>>(Line.Length); //O(1)
        List<List<Pair<string, TimeSpan>>> FolderList = new List<List<Pair<string, TimeSpan>>>(Line.Length); //O(1)
        int counter = 0; //O(1) 
        List<double> Seconds = new List<double>(Line.Length); //O(1)
        //n = FileCount, m = FolderCount 
        for (int i = 0; i < Line.Length; i++) // O(n * m)
        {
            if (FolderList.Count == 0)  //O(1)
            {
                Temp.Add(Line[i]); //O(1)
                FolderList.Add(Temp); //O(1)
                Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                continue;
            }
            if (FolderList.Count == 1) //O(1)
            {
                if (Seconds[counter] > Line[i].Second.TotalSeconds) //O(1)
                {
                    FolderList[counter].Add(Line[i]); //O(1)
                    Seconds[counter] -= Line[i].Second.TotalSeconds; //O(1)
                    continue;
                }
                else
                {
                    Temp = new List<Pair<string, TimeSpan>>(); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1)
                    Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                    continue; 
                }
            }
            if (Seconds[counter] == Max_Folder_Length) //O(1)
            {
                if (counter + 1 == FolderList.Count) //O(1)
                {
                    Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length,20000)); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1)
                    Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                    continue;
                }
                counter++; //O(1)
                continue; 
            }
            int index = 0; //O(1)
            double max = 0; //O(1)
            for (int k = 0; k < Seconds.Count; k++) //O(1)
            {
                if (Seconds[k] < Line[i].Second.TotalSeconds) //O(1)
                {
                    continue;
                }
                if (Seconds[k] > max) //O(1)
                {
                    max = Seconds[k]; //O(1)
                    index = k; //O(1)
                }
            }
            if (max != 0) //O(1)
            {  
                FolderList[index].Add(Line[i]); //O(1)
                Seconds[index] -= Line[i].Second.TotalSeconds;  //O(1) 
                continue;
            }
            else
            {
                Temp = new List<Pair<string, TimeSpan>>(Line.Length); //O(1)
                Temp.Add(Line[i]); //O(1)
                FolderList.Add(Temp); //O(1)
                Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                continue;
            }
        }
        //shrinking lists to the exact count of elements
        foreach (List<Pair<string, TimeSpan>> lp in FolderList) //O(N) while N is the number of Files
        {
            lp.TrimExcess();
        }
        //shrinking folder list
        FolderList.TrimExcess();
        //clearing seconds list because it was never nessecary........
        Seconds.Clear();
        //FileOperations.FinializeDirectory(FolderList);
    }
    static public void Worst_Fit_Deacreasing_Algorithm(Pair<string, TimeSpan>[] Line)
    {
        Array.Sort(Line);
        List<Pair<string, TimeSpan>> Temp = new List<Pair<string, TimeSpan>>(Line.Length); //O(1)
        List<List<Pair<string, TimeSpan>>> FolderList = new List<List<Pair<string, TimeSpan>>>(Line.Length); //O(1)
        int counter = 0; //O(1) 
        List<double> Seconds = new List<double>(Line.Length); //O(1)
        //n = FileCount, m = FolderCount 
        for (int i = 0; i < Line.Length; i++) // O(n * m)
        {
            if (FolderList.Count == 0)  //O(1)
            {
                Temp.Add(Line[i]); //O(1)
                FolderList.Add(Temp); //O(1)
                Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                continue;
            }
            if (FolderList.Count == 1) //O(1)
            {
                if (Seconds[counter] > Line[i].Second.TotalSeconds) //O(1)
                {
                    FolderList[counter].Add(Line[i]); //O(1)
                    Seconds[counter] -= Line[i].Second.TotalSeconds; //O(1)
                    continue;
                }
                else
                {
                    Temp = new List<Pair<string, TimeSpan>>(); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1)
                    Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                    continue;
                }
            }
            if (Seconds[counter] == Max_Folder_Length) //O(1)
            {
                if (counter + 1 == FolderList.Count) //O(1)
                {
                    Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length,20000)); //O(1)
                    Temp.Add(Line[i]); //O(1)
                    FolderList.Add(Temp); //O(1)
                    Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                    continue;
                }
                counter++; //O(1)
                continue;
            }
            int index = 0; //O(1)
            double max = 0; //O(1)
            for (int k = 0; k < Seconds.Count; k++) //O(1)
            {
                if (Seconds[k] < Line[i].Second.TotalSeconds) //O(1)
                {
                    continue;
                }
                if (Seconds[k] > max) //O(1)
                {
                    max = Seconds[k]; //O(1)
                    index = k; //O(1)
                }
            }
            if (max != 0) //O(1)
            {
                FolderList[index].Add(Line[i]); //O(1)
                Seconds[index] -= Line[i].Second.TotalSeconds;  //O(1) 
                continue;
            }
            else
            {
                Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length, 20000)); //O(1)
                Temp.Add(Line[i]); //O(1)
                FolderList.Add(Temp); //O(1)
                Seconds.Add(Max_Folder_Length - Line[i].Second.TotalSeconds); //O(1)
                continue;
            }
        }
        //shrinking lists to the exact count of elements
        foreach (List<Pair<string, TimeSpan>> lp in FolderList) //O(N) while N is the number of Files
        {
            lp.TrimExcess();
        }
        //shrinking folder list
        FolderList.TrimExcess();
        //clearing seconds list because it was never nessecary........
        Seconds.Clear();
        //FileOperations.FinializeDirectory(FolderList);
    }
    static public void Worst_Fit_Algorithm_Priority_Queue(Pair<string, TimeSpan>[] Line)
    {
        PriorityQueue<Pair<int, double>> PQueue = new PriorityQueue<Pair<int, double>>(); //O(1)
        List<Pair<string, TimeSpan>> Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length,20000)); //O(1)
        List<List<Pair<string, TimeSpan>>> FolderList = new List<List<Pair<string, TimeSpan>>>(Math.Min(Line.Length,20000)); //O(1)
        Pair<int, double> Tempo = new Pair<int, double>(); //O(1)
        for (int i = 0; i < Line.Length; i++) // O(n * m)
        {
            if (FolderList.Count == 0) // O(1)
            {
                Temp.Add(Line[i]); // O(1) 
                FolderList.Add(Temp); // O(1)
                Tempo.First = 0; // O(1)
                Tempo.Second = Max_Folder_Length - Line[i].Second.TotalSeconds; // O(1)
                PQueue.Enqueue(Tempo); // O(1)
                continue;
            }
            if (PQueue.Count != 0) // O(1)
            {
                if (PQueue.Peek().Second >= Line[i].Second.TotalSeconds) // O(1)
                {
                    FolderList[PQueue.Peek().First].Add(Line[i]); // O(1)
                    if (PQueue.Peek().Second == Line[i].Second.TotalSeconds) // O(1)
                    {
                        PQueue.Dequeue(); // O(1)
                        continue;
                    }
                    var P = PQueue.Peek(); // O(1)
                    Tempo = new Pair<int, double> // O(1)
                    {
                        First = P.First,
                        Second = P.Second
                    };
                    Tempo.Second -= Line[i].Second.TotalSeconds; // O(1)
                    PQueue.Dequeue(); // O(1) 
                    PQueue.Enqueue(Tempo); // O(1)
                    continue;
                }
                else
                {
                    Temp = new List<Pair<string, TimeSpan>>(); // O(1)
                    Tempo = new Pair<int, double>(); // O(1)
                    Temp.Add(Line[i]); // O(1)
                    FolderList.Add(Temp); // O(1)
                    Tempo.First = FolderList.Count - 1; // O(1)
                    Tempo.Second = Max_Folder_Length - Line[i].Second.TotalSeconds; // O(1) 
                    PQueue.Enqueue(Tempo); // O(1)
                    continue;
                }
            }
            else
            {
                Temp = new List<Pair<string, TimeSpan>>(); // O(1)
                Tempo = new Pair<int, double>(); // O(1)
                Temp.Add(Line[i]); // O(1)
                FolderList.Add(Temp); // O(1)
                Tempo.First = FolderList.Count - 1; // O(1)
                Tempo.Second = Max_Folder_Length - Line[i].Second.TotalSeconds; // O(1) 
                PQueue.Enqueue(Tempo); // O(1)
                continue;
            }
        }
        //shrinking lists to the exact count of elements
        foreach (List<Pair<string, TimeSpan>> lp in FolderList) //O(N) while N is the number of Files
        {
            lp.TrimExcess();
        }
        //shrinking folder list
        FolderList.TrimExcess();
        //FileOperations.FinializeDirectory(FolderList);
    }
    static public void Worst_Fit_Decreasing_Algorithm_Priority_Queue(Pair<string, TimeSpan>[] Line)
    {
        Array.Sort(Line);
        PriorityQueue<Pair<int, double>> PQueue = new PriorityQueue<Pair<int, double>>(); //O(1)
        List<Pair<string, TimeSpan>> Temp = new List<Pair<string, TimeSpan>>(Math.Min(Line.Length,20000)); //O(1)
        List<List<Pair<string, TimeSpan>>> FolderList = new List<List<Pair<string, TimeSpan>>>(Math.Min(Line.Length,20000)); //O(1)
        Pair<int, double> Tempo = new Pair<int, double>(); //O(1)
        for (int i = 0; i < Line.Length; i++) // O(n * m)
        {
            if (FolderList.Count == 0) // O(1)
            {
                Temp.Add(Line[i]); // O(1) 
                FolderList.Add(Temp); // O(1)
                Tempo.First = 0; // O(1)
                Tempo.Second = Max_Folder_Length - Line[i].Second.TotalSeconds; // O(1)
                PQueue.Enqueue(Tempo); // O(1)
                continue;
            }
            if (PQueue.Count != 0) // O(1)
            {
                if (PQueue.Peek().Second >= Line[i].Second.TotalSeconds) // O(1)
                {
                    FolderList[PQueue.Peek().First].Add(Line[i]); // O(1)
                    if (PQueue.Peek().Second == Line[i].Second.TotalSeconds) // O(1)
                    {
                        PQueue.Dequeue(); // O(1)
                        continue;
                    }
                    var P = PQueue.Peek(); // O(1)
                    Tempo = new Pair<int, double> // O(1)
                    {
                        First = P.First,
                        Second = P.Second
                    };
                    Tempo.Second -= Line[i].Second.TotalSeconds; // O(1)
                    PQueue.Dequeue(); // O(1) 
                    PQueue.Enqueue(Tempo); // O(1)
                    continue;
                }
                else
                {
                    Temp = new List<Pair<string, TimeSpan>>(); // O(1)
                    Tempo = new Pair<int, double>(); // O(1)
                    Temp.Add(Line[i]); // O(1)
                    FolderList.Add(Temp); // O(1)
                    Tempo.First = FolderList.Count - 1; // O(1)
                    Tempo.Second = Max_Folder_Length - Line[i].Second.TotalSeconds; // O(1) 
                    PQueue.Enqueue(Tempo); // O(1)
                    continue;
                }
            }
            else
            {
                Temp = new List<Pair<string, TimeSpan>>(); // O(1)
                Tempo = new Pair<int, double>(); // O(1)
                Temp.Add(Line[i]); // O(1)
                FolderList.Add(Temp); // O(1)
                Tempo.First = FolderList.Count - 1; // O(1)
                Tempo.Second = Max_Folder_Length - Line[i].Second.TotalSeconds; // O(1) 
                PQueue.Enqueue(Tempo); // O(1)
                continue;
            }
        }
        //shrinking lists to the exact count of elements
        foreach (List<Pair<string, TimeSpan>> lp in FolderList) //O(N) while N is the number of Files
        {
            lp.TrimExcess();
        }
        //shrinking folder list
        FolderList.TrimExcess();
        //FileOperations.FinializeDirectory(FolderList);
    }
    static public void Folder_Filling_Algorithm(Pair<string, TimeSpan>[] Line) //O(N^2*D)
    {
        int Count = Line.Length;
        bool[] Selected = new bool[Line.Length + 5]; //To flag the files already selected inorder not to take them again.
        int[,] dp = new int[Line.Length + 5, Max_Folder_Length + 5]; //Memoization
        for (int i = 0; i < Line.Length; i++) //O(n) where n is the number of files.
        {
            Selected[i] = false; //O(1)
        }
        void IterativeKnapsack() //O(N*D)
        {
            for (int i = Line.Length; i >= 0; i--)
            {
                for (int w = Max_Folder_Length; w >= 0; w--)
                {
                    if (i == Line.Length) //Finished all files.
                        dp[i, w] = 0;
                    else if (Selected[i]) //File Already selected.
                        dp[i, w] = dp[i + 1, w];
                    else
                    {
                        int ans = 0, time = (int)Line[i].Second.TotalSeconds;
                        if (w + time <= Max_Folder_Length)
                            ans = dp[i + 1, w + time] + time;
                        dp[i, w] = Math.Max(ans, dp[i + 1, w]);
                    }
                }
            }
        }
        List<Pair<string, TimeSpan>> Traversal()
        {
            List<Pair<string, TimeSpan>> ans = new List<Pair<string, TimeSpan>>();
            int w = 0;
            for (int i = 0; i < Line.Length; i++)
            {
                int time = (int)Line[i].Second.TotalSeconds;
                //If the file hasn't been selected in a previous folder
                //and the length of the file is less than the remaining space in the folder
                //and the table that was just built by the knapsack shows that choosing this file will yield the best possible results
                //Then we will select this file
                if (!Selected[i] && w + time <= Max_Folder_Length && dp[i + 1, w + time] + time >= dp[i + 1, w])
                {
                    Selected[i] = true;
                    Count--;
                    ans.Add(Line[i]);
                    w += time;
                }
            }
            return ans;
        }
        List<List<Pair<string, TimeSpan>>> Folders = new List<List<Pair<string, TimeSpan>>>();
        while (Count > 0) //O(N^2 * D) 
        {
            IterativeKnapsack(); //O(N*D)
            Folders.Add(Traversal()); //O(N)
        }
        //FileOperations.FinializeDirectory(Folders);
    }
}