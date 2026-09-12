using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektronikAletler
{
    internal class Televizyon : ElektronikAlet
    {
        public string Model { get; set; }
        public double Ekran { get; set; }
        public int MaxChannel { get; set; }
        public int MaxVoice { get; set; }
        public int nowChanel { get; set; }
        public int nowVoice { get; set; }

        public Televizyon(string marka, double power, IsletimSistemi isletimSistemi, string model, double ekran, int maxChannel, int maxVoice)
            : base(marka, power, isletimSistemi)
        {
            Model = model;
            Ekran = ekran;
            MaxChannel = maxChannel;
            MaxVoice = maxVoice;
            nowChanel = 1;
            nowVoice = 20;
        }

        public void changeChannel(int channel)
        {
            if (IsRun)
            {

            
            if (channel > 0 && channel < MaxChannel)
            {
                nowChanel = channel;
            }
            else
            {
                Console.WriteLine("Öyle bir kanal yok");
            }
            }
            else
            {
                Console.WriteLine("Kapalı cihazda kanal değişimi yoktur. en azından bende yok...");
            }
        }

        public void changeChannel(bool isPlus)
        {
            if (IsRun)
            {
                if (isPlus)
            {
                if (nowChanel < MaxChannel)
                {
                    nowChanel++;
                }
                else
                {
                    nowChanel = 1;
                }
            }
            else
            {
                if (nowChanel >1)
                {
                    nowChanel--;
                }
                else
                {
                    nowChanel = MaxChannel;
                }
            }
            }
            else
            {
                Console.WriteLine("Kapalı cihazda kanal değişimi yoktur. en azından bende yok...");
            }

        }


        public void info()
        {
            string durum = IsRun ? "Çalışıyor" : "Kapalı";
            Console.WriteLine($"{Marka}, {Model}, {nowChanel}, {nowVoice}, {durum}");
        }

    }
}
