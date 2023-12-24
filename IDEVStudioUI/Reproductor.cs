using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using IDEVStudioUI.Properties;

namespace IDEVStudioUI
{
    public enum TypeSound
    {
        Information = 1,
        Question = 2,
        Warning = 3,
        Error = 4,
        Enter = 5,
        Click = 6
    }
    public static class Reproductor
    {
        static SoundPlayer player;
        public static void Play(TypeSound type)
        {
            switch (type)
            {
                case TypeSound.Information:
                    player = new SoundPlayer(Resources.SFX_Information);
                    player.Play();
                    break;
                case TypeSound.Question:
                    player = new SoundPlayer(Resources.SFX_Question);
                    player.Play();
                    break;
                case TypeSound.Warning:
                    player = new SoundPlayer(Resources.SFX_Warning);
                    player.Play();
                    break;
                case TypeSound.Error:
                    player = new SoundPlayer(Resources.SFX_Error);
                    player.Play();
                    break;
                case TypeSound.Enter:
                    player = new SoundPlayer(Resources.SFX_MouseEnter);
                    player.Play();
                    break;
                case TypeSound.Click:
                    player = new SoundPlayer(Resources.SFX_MouseClick);
                    player.Play();
                    break;
            }
        }
    }
}
