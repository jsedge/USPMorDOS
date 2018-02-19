using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPMorDOS {
    class GameManager {
        private List<Cover> covers;
        private Cover cur;
        private int score, possible;
        private static Random rng;

        public GameManager() {
            rng = new Random();
            //TODO: Fill list of covers
        }

        public bool checkAnswer(bool answer) {
            possible++;
            if (cur.USPM) score++;
            return cur.USPM;
        }

        public string actualAnswer() {
            return String.Format("It's the {0} {1}", (cur.USPM ? "metal album" : "DOS game"), cur.name);
        }

        public Cover getNext() {
            int r = rng.Next(covers.Count);
            cur = covers.ElementAt(r);
            covers.RemoveAt(r);

            return cur;
        }
    }
}
