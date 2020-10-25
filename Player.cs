﻿// <copyright file="Player.cs" company="Mark-James McDougall">
// Licensed under the GNU GPL v3 License. See LICENSE in the project root for license information.
// </copyright>

namespace MusicSharp
{
    using System.Threading;
    using NAudio.Wave;

    /// <summary>
    /// The Player class handles audio playback.
    /// </summary>
    public static class Player
    {
        /// <summary>
        /// Method that implements audio playback from a file.
        /// </summary>
        public static void PlayAudioFile()
        {
            string file = @"C:\MusicSharp\example.mp3";
            using (var audioFile = new AudioFileReader(file))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
