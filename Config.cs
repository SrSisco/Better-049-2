namespace Better049_2
{
    
    using Exiled.API.Interfaces;
    using System.ComponentModel;

    public class Config : IConfig
    {
        public bool Debug { get; set; } = false;
        [Description("Enable or disable the plugin.")]
        public bool IsEnabled { get; set; }

        [Description("Sets the probability for the player to get infected.")]
        public int InfectionProbability { get; set; }
    }
}