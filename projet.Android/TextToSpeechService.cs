using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using Android.Speech.Tts;
using projet.Interfaces;

[assembly: Dependency(typeof(projet.Droid.TextToSpeechService))]
namespace projet.Droid
{
    class TextToSpeechService : Java.Lang.Object, ITextToSpeechService, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public Task SpeakAsync(string text)
        {
            return Task.Run(() =>
            {
                var ctx = Forms.Context; //  useful for many Android SDK features
                toSpeak = text;
                if (speaker == null)
                {
                    speaker = new TextToSpeech(ctx, this);
                }
                else
                {
                    speaker.Speak(toSpeak, QueueMode.Flush, null, null);
                }
            });
        }

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

    }
}
