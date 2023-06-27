using NAudio.Lame;
using NAudio.Wave;
using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TTSfree.Utilities
{
    public class TextToSpeech
    {
        public string Text { get; set; }
        public string OutputFilePath { get; set; }
        public string TempWavFilePath { get; set; }
        public string Extension { get; set; }
        public int Volume { get; set; }
        public int Rate { get; set; }

        public TextToSpeech() { }
        public TextToSpeech(string text, string outputFilePath, string tempWavFilePath, int volume, int rate)
        {
            Text = text;
            OutputFilePath = outputFilePath;
            TempWavFilePath = tempWavFilePath;
            Volume = volume;
            Rate = rate;
            Extension = Path.GetExtension(outputFilePath);
        }

        public void CreateAudioFile()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            try
            {
                synthesizer.Volume = Volume;
                synthesizer.Rate = Rate;

                using (var outputStream = new MemoryStream())
                {
                    synthesizer.SetOutputToWaveStream(outputStream);
                    synthesizer.Speak(Text);

                    using (var fileStream = new FileStream(TempWavFilePath, FileMode.Create, FileAccess.Write))
                    {
                        outputStream.Seek(0, SeekOrigin.Begin);
                        outputStream.CopyTo(fileStream);
                    }
                }

                if (Extension == ".mp3")
                {
                    using (var reader = new AudioFileReader(TempWavFilePath))
                    using (var writer = new LameMP3FileWriter(OutputFilePath, reader.WaveFormat, LAMEPreset.STANDARD))
                    {
                        reader.CopyTo(writer);
                    }
                }
                else if (Extension == ".wav")
                {
                    File.Move(TempWavFilePath, OutputFilePath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка создания аудио", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                synthesizer.Dispose();
                File.Delete(TempWavFilePath);
            }
        }


    }
}
