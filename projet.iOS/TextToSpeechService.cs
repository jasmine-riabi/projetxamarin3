using System;
using System.Threading.Tasks;
using AVFoundation;
using projet.Interfaces;
using projet.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechService))]
namespace projet.iOS
{
    class TextToSpeechService : ITextToSpeechService
    {
        public Task SpeakAsync(string text)
        {
            return Task.Run(() =>
            {
                var speechSynthesizer = new AVSpeechSynthesizer();

                var speechUtterance = new AVSpeechUtterance(text)
                {
                    Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                    Voice = AVSpeechSynthesisVoice.FromLanguage("fr-FR"),
                    Volume = 0.5f,
                    PitchMultiplier = 1.0f
                };

                speechSynthesizer.SpeakUtterance(speechUtterance);
            });
        }

    }
}
