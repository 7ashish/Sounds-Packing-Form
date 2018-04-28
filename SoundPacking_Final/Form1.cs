using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SoundPacking_Final
{
    public partial class Form1 : Form
    {
        Pair<string, TimeSpan>[] Line;
        public Form1()
        {
            InitializeComponent();


        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Stopwatch[] watches = new Stopwatch[8];
        private async void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Algorithms.Max_Folder_Length = int.Parse(MaxTime.Text);
            for (int i = 0; i < watches.Length; i++)
            {
                watches[i] = new Stopwatch();
            }
            timer1.Start();
            switch (Type.SelectedIndex)
            {
                case 0:
                    watches[0].Restart();
                    await Task.Run(() => { Algorithms.First_Fit_Decreasing_Algorithm((Pair<string, TimeSpan>[])Line.Clone()); });
                    watches[0].Stop();
                    timer1.Stop();
                    break;
                case 1:
                    watches[1].Restart();
                    await Task.Run(() =>
                    {
                        Algorithms.Best_Fit_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                    });
                    watches[1].Stop();
                    timer1.Stop();
                    break;
                case 2:
                    watches[2].Restart();
                    await Task.Run(() =>
                    {
                        Algorithms.Best_Fit_Decreasing_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                    });
                    watches[2].Stop();
                    timer1.Stop();
                    break;
                case 3:
                    watches[3].Restart();
                    await Task.Run(() =>
                    {
                        Algorithms.Worst_Fit_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                    });
                    watches[3].Stop();
                    timer1.Stop();
                    break;
                case 4:
                    watches[4].Restart();
                    await Task.Run(() =>
                    {
                        Algorithms.Worst_Fit_Deacreasing_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                    });
                    watches[4].Stop();
                    timer1.Stop();
                    break;
                case 5:
                    watches[5].Restart();
                    await Task.Run(() =>
                    {
                        Algorithms.Worst_Fit_Algorithm_Priority_Queue((Pair<string, TimeSpan>[])Line.Clone());
                    });
                    watches[5].Stop();
                    timer1.Stop();
                    break;
                case 6:
                    watches[6].Restart();
                    await Task.Run(() =>
                    {
                        Algorithms.Worst_Fit_Decreasing_Algorithm_Priority_Queue((Pair<string, TimeSpan>[])Line.Clone());
                    });
                    watches[6].Stop();
                    timer1.Stop();
                    break;
                case 7:
                    watches[7].Restart();
                    timer1.Start();
                    await Task.Run(() =>
                    {
                        Algorithms.Folder_Filling_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                    });
                    watches[7].Stop();
                    timer1.Stop();
                    break;
                case 8:
                    List<Task> Tasks = new List<Task>();
                    Tasks.Add(Task.Run(() =>
                    {
                        watches[0].Restart();
                        Algorithms.First_Fit_Decreasing_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                        watches[0].Stop();
                    }));
                    Tasks.Add(Task.Run(() =>
                    {
                        watches[1].Restart();
                        Algorithms.Best_Fit_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                        watches[1].Stop();
                    }));
                    Tasks.Add(Task.Run(() =>
                    {
                        watches[2].Restart();
                        Algorithms.Best_Fit_Decreasing_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                        watches[2].Stop();
                    }));
                    Tasks.Add(Task.Run(() =>
                    {
                        watches[3].Restart();
                        Algorithms.Worst_Fit_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                        watches[3].Stop();
                    }));
                    Tasks.Add(Task.Run(() =>
                    {
                        watches[4].Restart();
                        Algorithms.Worst_Fit_Deacreasing_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                        watches[4].Stop();
                    }));
                    Tasks.Add(Task.Run(() =>
                    {
                        watches[5].Restart();
                        Algorithms.Worst_Fit_Algorithm_Priority_Queue((Pair<string, TimeSpan>[])Line.Clone());
                        watches[5].Stop();
                    }));
                    Tasks.Add(Task.Run(() =>
                    {
                        watches[6].Restart();
                        Algorithms.Worst_Fit_Decreasing_Algorithm_Priority_Queue((Pair<string, TimeSpan>[])Line.Clone());
                        watches[6].Stop();
                    }));
                    Tasks.Add(Task.Run(() =>
                    {
                        watches[7].Restart();
                        Algorithms.Folder_Filling_Algorithm((Pair<string, TimeSpan>[])Line.Clone());
                        watches[7].Stop();
                    }));
                    await Task.WhenAll(Tasks.ToArray());
                    timer1.Stop();
                    break;
            }
            Start.Enabled = true;
        }

        private void SourceBrowse_Click(object sender, EventArgs e)
        {
            string input;//output;
            Sourcee.ShowDialog();
            SourceTxt.Text = Sourcee.SelectedPath;
            input = Sourcee.SelectedPath;
            FileOperations.DefaultPath = input + @"\Audios\";
            {
                FileStream file = new FileStream(input + @"\AudiosInfo.txt", FileMode.Open, FileAccess.Read); //Reading the information of Files.
                StreamReader reader = new StreamReader(file); //O(1)
                int n = int.Parse(reader.ReadLine()); //O(1)
                Line = new Pair<string, TimeSpan>[n]; //used to read the MetaData of the AudiosInfo.
                for (int i = 0; i < n; i++)  //O(n) //Filling the List of AudiosInfo.
                {
                    string[] fields = reader.ReadLine().Split(' '); //O(1)
                    Line[i] = new Pair<string, TimeSpan>()  //O(1)
                    {
                        First = fields[0],
                        Second = TimeSpan.Parse(fields[1])
                    };
                }
                reader.Close(); //O(1)
            }
            FileOperations.CleanUp();
        }
        private void ChooseType_Click(object sender, EventArgs e)
        {

        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FirstFitTime.Text = watches[0].Elapsed.ToString();
            BestFitTime.Text = watches[1].Elapsed.ToString();
            BestFitDecreasingTime.Text = watches[2].Elapsed.ToString();
            WorstFitLinearTime.Text = watches[3].Elapsed.ToString();
            WorstFitDecTime.Text = watches[4].Elapsed.ToString();
            WorstFitPQTime.Text = watches[5].Elapsed.ToString();
            WorstFitDecPQ.Text = watches[6].Elapsed.ToString();
            FolderFillingTime.Text = watches[7].Elapsed.ToString();
        }
    }
}
