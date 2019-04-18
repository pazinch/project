using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using UnityEngine;
using System.Collections;
namespace Assets.Code
{
    public class Rank
    {
        public Rank()
        {

        }

        public List<int> scores;
        public List<string> names;
        public int currentScore;
        public void addToRank(string name, int score)
        {
            readRankFromXML();
            scores.Add(score);
            names.Add(name);
            writeRankToXML();
        }
        public void addCurrent(int score)
        {
            readRankFromXML();
            currentScore = score;
            writeRankToXML();
        }
        public List<string>returnNames()
        {
            readRankFromXML();
            return names;
        }
        public List<int>returnScores()
        {
            readRankFromXML();
            return scores;
        }

        public int returnCurrent()
        {
            readRankFromXML();
            return currentScore;
        }

        public void writeRankToXML()
        {

            var serializer = new XmlSerializer(typeof(Assets.Scripts.Rank));
            using (var stream = new FileStream(@"Rank.xml", FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }

        }
        public void checkIfExists()
        {
    
        }
        public void readRankFromXML()
        {
            try
            {
                Assets.Scripts.Rank x = new Assets.Scripts.Rank();
                var serializer = new XmlSerializer(typeof(Assets.Scripts.Rank));
                using (var stream = new FileStream(@"Rank.xml", FileMode.Open))
                {
                    x = serializer.Deserialize(stream) as Assets.Scripts.Rank;
                    this.scores = x.scores;
                    this.names = x.names;
                    this.currentScore = x.currentScore;
                }
            }
            catch(Exception){
                writeRankToXML();
                readRankFromXML();
            }
        }
    }
}
