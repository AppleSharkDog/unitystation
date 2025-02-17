﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UI.Core.NetUI;
using Items.Botany;

namespace UI.Objects.Botany
{
	public class SeedExtractorItemTypeEntry : DynamicEntry
	{
		[SerializeField]
		private Color regularColor = Color.gray;
		[SerializeField]
		private GUI_SeedExtractor seedExtractorWindow;
		[SerializeField]
		private NetText_label itemName = null;
		[SerializeField]
		private NetText_label itemCount = null;
		[SerializeField]
		private NetPrefabImage itemIcon = null;
		[SerializeField]
		private NetColorChanger itemBackground = null;

		private List<SeedPacket> seedPackets;

		public void SetItem(List<SeedPacket> item, GUI_SeedExtractor correspondingWindow)
		{
			seedPackets = item;
			seedExtractorWindow = correspondingWindow;
			itemName.MasterSetValue(seedPackets.First().name);
			itemIcon.MasterSetValue(seedPackets.First().name);
			itemCount.MasterSetValue($"({seedPackets.Count})");
			itemBackground.MasterSetValue(regularColor);
		}

		public void Show()
		{
			seedExtractorWindow.SelectSeedType(seedPackets.First().name);
		}
	}
}
