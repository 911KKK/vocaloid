﻿using System.Collections.Generic;

namespace OpenUtau.Classic {
    public class Voicebank {
        public string File;
        public string OrigFile;
        public string Name;
        public string Image;
        public string Author;
        public string Web;
        public string OtherInfo;
        public List<OtoSet> OtoSets;
        public PrefixMap PrefixMap;

        public override string ToString() {
            return Name;
        }
    }

    public class OtoSet {
        public string File;
        public string OrigFile;
        public string Name;
        public List<Oto> Otos = new List<Oto>();

        public override string ToString() {
            return Name;
        }
    }

    public class Oto {
        public string Name;
        public string Wav;
        public string OrigWav;
        public double Offset;
        public double Consonant;
        public double Cutoff;
        public double Preutter;
        public double Overlap;

        public override string ToString() {
            return Name;
        }
    }

    public class PrefixMap {
        public string File;
        public string OrigFile;
        public Dictionary<string, string> Map = new Dictionary<string, string>();
    }
}
