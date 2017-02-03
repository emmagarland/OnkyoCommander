using eg.Onkyo.API.Properties;

namespace eg.Onkyo.API.Models
{
    public static class OnkyoCommands
    {
        /// <summary>
        /// Powers off the Onkyo
        /// </summary>
        public static string Poweroff => Settings.Default.Poweroff;

        /// <summary>
        /// Powers the Onkyo On
        /// </summary>
        public static string Poweron => Settings.Default.Poweron;

        /// <summary>
        /// Switches the Onkyo to Stereo mode
        /// </summary>
        public static string Stereo => Settings.Default.Stereo;

        /// <summary>
        /// Switches the Onkyo to Direct mode
        /// </summary>
        public static string Direct => Settings.Default.Direct;

        /// <summary>
        /// Switches the Onkyo to Surround mode
        /// </summary>
        public static string Surround => Settings.Default.Surround;

        /// <summary>
        /// Switches the Onkyo to Film mode
        /// </summary>
        public static string Film => Settings.Default.Film;

        /// <summary>
        /// Switches the Onkyo to THX mode
        /// </summary>
        public static string THX => Settings.Default.THX;

        /// <summary>
        /// Switches the Onkyo to Action mode
        /// </summary>
        public static string Action => Settings.Default.Action;

        /// <summary>
        /// Switches the Onkyo to Musical mode
        /// </summary>
        public static string Musical => Settings.Default.Musical;

        /// <summary>
        /// Switches the Onkyo to Orchestra mode
        /// </summary>
        public static string Orchestra => Settings.Default.Orchestra;

        /// <summary>
        /// Switches the Onkyo to Unplugged mode
        /// </summary>
        public static string Unplugged => Settings.Default.Unplugged;

        /// <summary>
        /// Switches the Onkyo to Mono mode
        /// </summary>
        public static string Mono => Settings.Default.Mono;

        /// <summary>
        /// Switches the Onkyo to Multiplex mode
        /// </summary>
        public static string Multiplex => Settings.Default.Multiplex;

        /// <summary>
        /// Switches the Onkyo to Music mode
        /// </summary>
        public static string MusicMode => Settings.Default.MusicMode;

        /// <summary>
        /// Unmute the Onkyo
        /// </summary>
        public static string AudioMutingOff => Settings.Default.AudioMutingOff;

        /// <summary>
        /// Mute the Onkyo
        /// </summary>
        public static string AudioMutingOn => Settings.Default.AudioMutingOn;

        /// <summary>
        /// Switch Speaker A off
        /// </summary>
        public static string SpeakerAOff => Settings.Default.SpeakerAOff;

        /// <summary>
        /// Switch Speaker A on
        /// </summary>
        public static string SpeakerAOn => Settings.Default.SpeakerAOn;

        /// <summary>
        /// Switch Speaker B off
        /// </summary>
        public static string SpeakerBOff => Settings.Default.SpeakerBOff;

        /// <summary>
        /// Switch Speaker B on
        /// </summary>
        public static string SpeakerBOn => Settings.Default.SpeakerBOn;
        public static string MonoMovie => Settings.Default.MonoMovie;
        public static string StudioMix => Settings.Default.StudioMix;
        public static string TVLogic => Settings.Default.TVLogic;
        public static string AllCHStereo => Settings.Default.AllCHStereo;
        public static string TheaterDimensional => Settings.Default.TheaterDimensional;
        public static string Enhanced7Enhance => Settings.Default.Enhanced7Enhance;
        public static string PureAudio => Settings.Default.PureAudio;
        public static string FullMono => Settings.Default.FullMono;
        public static string DolbyVirtual => Settings.Default.DolbyVirtual;
        public static string StraightDecode1 => Settings.Default.StraightDecode1;
        public static string DolbyEXDTSES => Settings.Default.DolbyEXDTSES;
        public static string DolbyEX2 => Settings.Default.DolbyEX2;
        public static string THXCinema => Settings.Default.THXCinema;
        public static string THXSurroundEX => Settings.Default.THXSurroundEX;
        public static string U2S2CinemaCinema2 => Settings.Default.U2S2CinemaCinema2;
        public static string GamesMode => Settings.Default.GamesMode;
        public static string PLIIPLIIxMovie => Settings.Default.PLIIPLIIxMovie;
        public static string PLIIPLIIxMusic => Settings.Default.PLIIPLIIxMusic;
        public static string Neo6Cinema => Settings.Default.Neo6Cinema;
        public static string Neo6Music => Settings.Default.Neo6Music;
        public static string PLIIPLIIxTHXCinema => Settings.Default.PLIIPLIIxTHXCinema;
        public static string Neo6THXCinema => Settings.Default.Neo6THXCinema;
        public static string PLIIPLIIxGame => Settings.Default.PLIIPLIIxGame;
        public static string NeuralSurr3 => Settings.Default.NeuralSurr3;
        public static string NeuralTHX => Settings.Default.NeuralTHX;
        public static string PLIITHXGames => Settings.Default.PLIITHXGames;
        public static string Neo6THXGames => Settings.Default.Neo6THXGames;
        public static string ListeningModeWrapAroundUp => Settings.Default.ListeningModeWrapAroundUp;
        public static string ListeningModeWrapAroundDown => Settings.Default.ListeningModeWrapAroundDown;
        public static string SurroundBack => Settings.Default.SurroundBack;
        public static string FrontHigh => Settings.Default.FrontHigh;
        public static string FrontWide => Settings.Default.FrontWide;
        public static string MasterVolumeUp => Settings.Default.MasterVolumeUp;
        public static string MasterVolumeDown => Settings.Default.MasterVolumeDown;
        public static string MasterVolumeUp1dB => Settings.Default.MasterVolumeUp1dB;
        public static string MasterVolumeDown1dB => Settings.Default.MasterVolumeDown1dB;
        public static string MasterVolumeCustom => Settings.Default.MasterVolumeCustom;
        public static string Video1VCRDVRInput => Settings.Default.Video1VCRDVRInput;
        public static string Video2CblSatInput => Settings.Default.Video2CblSatInput;
        public static string Video3GameTVInput => Settings.Default.Video3GameTVInput;
        public static string Video4AUX1AUXInput => Settings.Default.Video4AUX1AUXInput;
        public static string Video5AUX2Input => Settings.Default.Video5AUX2Input;
        public static string Tape1TVTapeInput => Settings.Default.Tape1TVTapeInput;
        public static string MusicServerInput => Settings.Default.MusicServerInput;
        public static string InternetRadioInput => Settings.Default.InternetRadioInput;
        public static string USBRearInput => Settings.Default.USBRearInput;
        public static string UniversalPortInput => Settings.Default.UniversalPortInput;
        public static string MultiChInput => Settings.Default.MultiChInput;
        public static string XM1Input => Settings.Default.XM1Input;
        public static string Sirius1Input => Settings.Default.Sirius1Input;
        public static string Video6Input => Settings.Default.Video6Input;
        public static string Video7Input => Settings.Default.Video7Input;

        /// <summary>
        /// Switch the Onkyo to CD input
        /// </summary>
        public static string CDInput => Settings.Default.CDInput;

        /// <summary>
        /// Switch the Onkyo to DVD input
        /// </summary>
        public static string DVDInput => Settings.Default.DVDInput;

        /// <summary>
        /// Switch the Onkyo to Tape input
        /// </summary>
        public static string Tape2Input => Settings.Default.Tape2Input;

        /// <summary>
        /// Switch the Onkyo to Phono input
        /// </summary>
        public static string PhonoInput => Settings.Default.PhonoInput;

        /// <summary>
        /// Switch the Onkyo to FM input
        /// </summary>
        public static string FMInput => Settings.Default.FMInput;

        /// <summary>
        /// Switch the Onkyo to AM input
        /// </summary>
        public static string AMInput => Settings.Default.AMInput;

        /// <summary>
        /// Switch the Onkyo to Tuner input
        /// </summary>
        public static string TunerInput => Settings.Default.TunerInput;

        /// <summary>
        /// Switch the Onkyo to USB input
        /// </summary>
        public static string USBInput => Settings.Default.USBInput;
    }
}