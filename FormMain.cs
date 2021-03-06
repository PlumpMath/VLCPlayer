﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VLCPlayer
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			//
			InitializeComponent();

			//
			this.VLCMain1.SetMedia("rtsp://192.168.70.107:554/ch0_0.h264");
			//
			this.VLCMain1.Audio.Volume = this.TrackBarMain1Vol.Value;
			//
			this.VLCMain1.Play();
			//
			this.VLCMain2.SetMedia("rtsp://192.168.70.110:554/ch0_0.h264");
			//
			this.VLCMain2.Audio.Volume = this.TrackBarMain2Vol.Value;
			//
			this.VLCMain2.Play();
		}

		private void VLCMain_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
		{
			//
			e.VlcLibDirectory = new DirectoryInfo(@".\vlc");
		}

		private void TrackBarMain1Vol_ValueChanged(object sender, EventArgs e)
		{
			//
			this.VLCMain1.Audio.Volume = this.TrackBarMain1Vol.Value;
		}

		private void TrackBarMain2Vol_ValueChanged(object sender, EventArgs e)
		{
			//
			this.VLCMain2.Audio.Volume = this.TrackBarMain2Vol.Value;

		}
	}
}
