﻿using ICities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BrokenNodeDetector
{
    public class BrokenNodeDetector : IUserMod {
        public static readonly string Version = "0.4";

        public string Name => "Broken Node Detector " + Version;

        public string Description => "Search for broken nodes when TM:PE vehicles despawn.";

        public void OnEnabled() {
            Debug.Log($"[BND] Broken Node Detector enabled. Version {Version}");
        }

        public void OnDisabled() {
            Debug.Log("[BND] Broken Node Detector disabled.");
        }
    }
}
