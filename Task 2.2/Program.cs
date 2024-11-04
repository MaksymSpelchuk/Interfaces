using System;


    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    public interface IRecordable
    {
        void Record();
    }

    public class MusicTrack : IPlayable, IRecordable
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; } 

        private bool isPlaying;
        private bool isRecording;

        public MusicTrack(string title, string artist, double duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            isPlaying = false;
            isRecording = false;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine($"Відтворення треку: {Title} від {Artist}");
            }
            else
            {
                Console.WriteLine($"Трек {Title} вже відтворюється.");
            }
        }

        public void Pause()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Трек {Title} призупинено.");
            }
            else
            {
                Console.WriteLine($"Трек {Title} не відтворюється, тому його не можна призупинити.");
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Трек {Title} зупинено.");
            }
            else
            {
                Console.WriteLine($"Трек {Title} вже зупинений.");
            }
        }

        public void Record()
        {
            if (!isRecording)
            {
                isRecording = true;
                Console.WriteLine($"Розпочато запис треку: {Title} від {Artist}");
            }
            else
            {
                Console.WriteLine($"Трек {Title} вже записується.");
            }
        }
    }

    public class MusicPlayerTest
    {
        public static void Main()
        {
            MusicTrack track1 = new MusicTrack("Пісня 1", "Виконавець A", 3.5);
            MusicTrack track2 = new MusicTrack("Пісня 2", "Виконавець B", 4.2);
            MusicTrack track3 = new MusicTrack("Пісня 3", "Виконавець C", 5.0);

            track1.Play();
            track1.Pause();
            track1.Record();
            track1.Stop();

            Console.WriteLine();

            track2.Play();
            track2.Record();
            track2.Stop();
            track2.Record();

            Console.WriteLine();

            track3.Play();
            track3.Stop();
            track3.Pause();  
        }
    }


