using System;
using System.Threading.Tasks;

namespace projet.Interfaces
{

    public interface ITextToSpeechService
    {
        Task SpeakAsync(string text);
    }

}
