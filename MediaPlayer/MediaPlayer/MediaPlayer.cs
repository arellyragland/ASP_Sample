﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
    class MediaPlayer
    {
        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}
