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

    public class Options
    {

        public int speed = 1;

      
        public bool ifSnakeCanGoThroughWalls = true;

        public Options()
        {

        }

        public Options(string str) { }

        public void changeSomethingInOptions(int speed, bool ifSnakeCanGoThorughW)
        {
            this.speed = speed;
            ifSnakeCanGoThroughWalls = ifSnakeCanGoThorughW;
            writeScoreToXML();
        }

        public void readOptions()
        {
           
                readScoreFromXML();
          
        }
        public void writeScoreToXML()
        {
            
            var serializer = new XmlSerializer(typeof(Options));
            using (var stream = new FileStream(@"Options.xml", FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
           
        }

        public void readScoreFromXML()
        {
            Options x = new Options();
            var serializer = new XmlSerializer(typeof(Options));
            using (var stream = new FileStream(@"Options.xml", FileMode.Open))
            {
                x = serializer.Deserialize(stream) as Options;
                this.speed = x.speed;
                this.ifSnakeCanGoThroughWalls = x.ifSnakeCanGoThroughWalls;
            }            
        }
    }
}
