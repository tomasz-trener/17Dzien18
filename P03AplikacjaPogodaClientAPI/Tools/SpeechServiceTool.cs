using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P03AplikacjaPogodaClientAPI.Tools
{
    internal class SpeechServiceTool
    {
        string apiKey;
        public SpeechServiceTool()
        {
            var builder = new ConfigurationBuilder()
               .AddUserSecrets<App>();
             var configuration = builder.Build();
            apiKey = configuration["speech_api_key"];
        }
        public async Task<string> RecognizeAsync()
        {
            var conf = SpeechConfig.FromSubscription(apiKey, "eastus");
            return await RecognizeFromMic(conf);
        }


        //Microsoft.CognitiveServices.Speech
        // dotnet add package Microsoft.CognitiveServices.Speech
        // dotnet restore - aktualizacja wszystkich paczek
        private async Task<string> RecognizeFromMic(SpeechConfig speechConfig)
        {
            using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            using var recognizer = new SpeechRecognizer(speechConfig,"pl-PL", audioConfig);

            var result = await recognizer.RecognizeOnceAsync();
            return result.Text;
        }

    }
}
