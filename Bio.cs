using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaGens {
    class Bio {
    }

    public class SmithWaterman {
        char[] mSeqA;
        char[] mSeqB;
        int[,] mD;
        int mScore;
        String mAlignmentSeqA = "";
        String mAlignmentSeqB = "";

        public void init(char[] seqA, char[] seqB) {
            mSeqA = seqA;
            mSeqB = seqB;
            mD = new int[mSeqA.Length + 1, mSeqB.Length + 1];
            for (int i = 0; i <= mSeqA.Length; i++) {
                mD[i, 0] = 0;
            }
            for (int j = 0; j <= mSeqB.Length; j++) {
                mD[0, j] = 0;
            }
        }

        public void process() {
            for (int i = 1; i <= mSeqA.Length; i++) {
                for (int j = 1; j <= mSeqB.Length; j++) {
                    int scoreDiag = mD[i - 1, j - 1] + weight(i, j);
                    int scoreLeft = mD[i, j - 1] - 1;
                    int scoreUp = mD[i - 1, j] - 1;
                    mD[i, j] = Math.Max(Math.Max(Math.Max(scoreDiag, scoreLeft), scoreUp), 0);
                }
            }
        }

        public void backtrack() {
            int i = 1;
            int j = 1;
            int k = 0;
            int l = 0;
            int max = mD[i, j];

            for (k = 1; k <= mSeqA.Length; k++) {
                for (l = 1; l <= mSeqB.Length; l++) {
                    if (mD[k, l] > max) {
                        i = k;
                        j = l;
                        max = mD[k, l];
                    }
                }
            }

            mScore = mD[i, j];

            k = mSeqA.Length;
            l = mSeqB.Length;

            while (k > i) {
                mAlignmentSeqB += "-";
                mAlignmentSeqA += mSeqA[k - 1];
                k--;
            }
            while (l > j) {
                mAlignmentSeqA += "-";
                mAlignmentSeqB += mSeqB[l - 1];
                l--;
            }

            while (mD[i, j] != 0) {
                if (mD[i, j] == mD[i - 1, j - 1] + weight(i, j)) {
                    mAlignmentSeqA += mSeqA[i - 1];
                    mAlignmentSeqB += mSeqB[j - 1];
                    i--;
                    j--;
                    continue;
                } else if (mD[i, j] == mD[i, j - 1] - 1) {
                    mAlignmentSeqA += "-";
                    mAlignmentSeqB += mSeqB[j - 1];
                    j--;
                    continue;
                } else {
                    mAlignmentSeqA += mSeqA[i - 1];
                    mAlignmentSeqB += "-";
                    i--;
                    continue;
                }
            }

            while (i > 0) {
                mAlignmentSeqB += "-";
                mAlignmentSeqA += mSeqA[i - 1];
                i--;
            }
            while (j > 0) {
                mAlignmentSeqA += "-";
                mAlignmentSeqB += mSeqB[j - 1];
                j--;
            }

            mAlignmentSeqA = String.Join("", mAlignmentSeqA.Reverse());
            mAlignmentSeqB = String.Join("", mAlignmentSeqB.Reverse());
        }

        private int weight(int i, int j) {
            if (mSeqA[i - 1] == mSeqB[j - 1]) {
                return 2;
            } else {
                return -1;
            }
        }

        public void printMatrix() {
            Console.WriteLine("D =       ");
            for (int i = 0; i < mSeqB.Length; i++) {
                Console.Write(mSeqB[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < mSeqA.Length + 1; i++) {
                if (i > 0) {
                    Console.Write(mSeqA[i - 1]);
                } else {
                    Console.Write("     ");
                }
                for (int j = 0; j < mSeqB.Length + 1; j++) {
                    Console.Write(mD[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void printScoreAndAlignments() {
            Console.WriteLine("Score: " + mScore);
            Console.WriteLine("Sequence A: " + mAlignmentSeqA);
            Console.WriteLine("Sequence B: " + mAlignmentSeqB);
            Console.WriteLine();
        }


        public class Result {
            public int Score;
            public string AlignA;
            public string AlignB;
        }

        public Result Align(string a, string b) {
            var res = new Result();

            SmithWaterman sw = new SmithWaterman();
            sw.init(a.ToCharArray(), b.ToCharArray());
            sw.process();
            sw.backtrack();

            //sw.printMatrix();
            //sw.printScoreAndAlignments();

            res.Score = sw.mScore;
            res.AlignA = sw.mAlignmentSeqA;
            res.AlignB = sw.mAlignmentSeqB;
            return res;
        }


        
    }
}
