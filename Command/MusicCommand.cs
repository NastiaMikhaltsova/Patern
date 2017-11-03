﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class MusicCommand: ICommand
    {
		private Music _music;
		public MusicCommand(Music music)
		{
			_music = music;
		}

		public void Execute()
		{
			_music.TurnOn();
		}

		public void Undo()
		{
			_music.TurnOff();
		}

		public override string ToString()
		{
			return "Включить музыку";
		}
    }
}