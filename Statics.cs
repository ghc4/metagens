using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public static class Statics {
        public static ConcurrentDictionary<int, char> WaveDistance = new ConcurrentDictionary<int, char>();
        public static ConcurrentDictionary<string, string> WaveMap = new ConcurrentDictionary<string, string>();

        public static class Controls {
            public static Form FormMain = null;
            public static PanelDataExplorer FormDataExplorer = null;
            public static PanelQC FormQualityControl = null;
            public static PanelDatabaseFilter FormDatabaseFilter = null;
            public static PanelQuery FormQuery = null;
            public static Button ButtonMain = null;
            public static Button ButtonDataExplorer = null;
            public static Button ButtonQualityControl = null;
            public static Button ButtonFilter = null;
            public static Button ButtonQuery = null;
            public static Button ButtonReports = null;
        }

        public static void Start() {
            for (int i = 0; i < 5000; i++) {
                if (i >= 0 && i <= 2) WaveDistance[i] = '1';
                if (i >= 3 && i <= 4) WaveDistance[i] = '2';
                if (i >= 5 && i <= 6) WaveDistance[i] = '3';
                if (i >= 7 && i <= 8) WaveDistance[i] = '4';
                if (i >= 9 && i <= 10) WaveDistance[i] = '5';
                if (i >= 11 && i <= 12) WaveDistance[i] = '6';
                if (i >= 13 && i <= 14) WaveDistance[i] = '7';
                if (i >= 15 && i <= 16) WaveDistance[i] = '8';
                if (i >= 17 && i <= 18) WaveDistance[i] = '9';
                if (i >= 19 && i <= 20) WaveDistance[i] = 'A';
                if (i >= 21 && i <= 22) WaveDistance[i] = 'B';
                if (i >= 23 && i <= 24) WaveDistance[i] = 'C';
                if (i >= 25 && i <= 26) WaveDistance[i] = 'D';
                if (i >= 27 && i <= 28) WaveDistance[i] = 'E';
                if (i >= 29 && i <= 30) WaveDistance[i] = 'F';
                if (i >= 31 && i <= 32) WaveDistance[i] = 'G';
                if (i >= 33 && i <= 34) WaveDistance[i] = 'H';
                if (i >= 35 && i <= 36) WaveDistance[i] = 'I';
                if (i >= 37 && i <= 38) WaveDistance[i] = 'J';
                if (i >= 39 && i <= 5000) WaveDistance[i] = 'Z';
            }

            WaveMap["1111111111"] = "a";
            WaveMap["111111111"] = "b";
            WaveMap["11111111"] = "c";
            WaveMap["1111111"] = "d";
            WaveMap["111111"] = "e";
            WaveMap["11111"] = "f";
            WaveMap["1111"] = "g";
            WaveMap["111"] = "h";
            WaveMap["11"] = "i";
            WaveMap["2222222222"] = "j";
            WaveMap["222222222"] = "k";
            WaveMap["22222222"] = "l";
            WaveMap["2222222"] = "m";
            WaveMap["222222"] = "n";
            WaveMap["22222"] = "o";
            WaveMap["2222"] = "p";
            WaveMap["222"] = "q";
            WaveMap["22"] = "r";
            
            WaveMap["12"] = "s";
            WaveMap["21"] = "t";

        }

        public static class Paths {
            public static string Base = AppDomain.CurrentDomain.BaseDirectory;
            public static string Data = Path.Combine(Base, "Data");
            public static string Bin = Path.Combine(Data, "Bin");
            public static string Refs = Path.Combine(Data, "Refs");
            public static string Projects = Path.Combine(Data, "Projects");
            public static string RefsSummary = Path.Combine(Refs, "assembly_summary_refseq.txt");
            public static string CurrentProjectPath = "";
            public static string CurrentProjectName = "";
            public static string CurrentSamplePath = "";
            public static string CurrentSampleName = "";
        }


        public static void Clear() {
            Paths.CurrentProjectPath = "";
            Paths.CurrentProjectName = "";
            Paths.CurrentSamplePath = "";
            Paths.CurrentSampleName = "";
        }


        public class DownloadRefSeqData {
            public string urlfile = "";
            public string urlmd5 = "";
            public string urlbase = "";
            public string accession = "";
            public string asm = "";
            public string name = "";
            public string md5file = "";
            public string pathname = "";
        }

        public static class Data {
            public static DataTable DatabaseFilterData = new DataTable();
            public static DataTable DatabaseFilterSelection = new DataTable();
            public static ConcurrentDictionary<string, string> reads = new ConcurrentDictionary<string, string>();
            public static ConcurrentDictionary<string, string> reads5 = new ConcurrentDictionary<string, string>();

            public static void Clear() {
                DatabaseFilterData.Clear();
                DatabaseFilterSelection.Clear();
                reads.Clear();
                reads5.Clear();
            }
        }

        public static int LevenshteinDistance(string a, string b) {
            if (String.IsNullOrEmpty(a) && String.IsNullOrEmpty(b)) {
                return 0;
            }
            if (String.IsNullOrEmpty(a)) {
                return b.Length;
            }
            if (String.IsNullOrEmpty(b)) {
                return a.Length;
            }
            int lengthA = a.Length;
            int lengthB = b.Length;
            var distances = new int[lengthA + 1, lengthB + 1];
            for (int i = 0; i <= lengthA; distances[i, 0] = i++) ;
            for (int j = 0; j <= lengthB; distances[0, j] = j++) ;

            for (int i = 1; i <= lengthA; i++)
                for (int j = 1; j <= lengthB; j++) {
                    int cost = b[j - 1] == a[i - 1] ? 0 : 1;
                    distances[i, j] = Math.Min(
                        Math.Min(distances[i - 1, j] + 1, distances[i, j - 1] + 1),
                        distances[i - 1, j - 1] + cost
                    );
                }
            return distances[lengthA, lengthB];
        }

        public static string GhcIndex(string a, string nucleotide) {
            try {
                var sc = String.Join("", a.Split(new string[] { nucleotide }, StringSplitOptions.None).Select(x => WaveDistance[x.Length]).ToArray());
                WaveMap.Keys.ToList().ForEach(x => sc = sc.Replace(x, WaveMap[x]));
                return sc.Length > 2 ? sc.Substring(1, sc.Length - 2) : "";
            } catch (Exception) {
                return "";
            }
        }

        public static string GhcIndex5(string a) {
            var sc = String.Join("", a.Split('2').Select(x => WaveDistance[x.Length]).ToArray());
            WaveMap.Keys.ToList().ForEach(x => sc = sc.Replace(x, WaveMap[x]));
            return sc.Length > 2 ? sc.Substring(1, sc.Length - 2) : "";
        }
    }
}
