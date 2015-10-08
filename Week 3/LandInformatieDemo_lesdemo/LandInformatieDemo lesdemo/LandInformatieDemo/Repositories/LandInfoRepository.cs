﻿using LandInformatieDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandInformatieDemo.Repositories
{
    public class LandInfoRepository
    {
        private static List<LandInfo> _landen;
        public static List<LandInfo> Landen
        {
            get
            {
                if (_landen == null) VerzamelLanden();
                return _landen;
            }
        }

        public static List<LandInfo> EuropeseLanden
        {
            get
            {
                return (from l in Landen where l.IsEuropees select l).ToList<LandInfo>();
            }
        }
        public static List<LandInfo> NietEuropeseLanden
        {
            get
            {
                return (from l in Landen where !l.IsEuropees select l).ToList<LandInfo>();
            }
        }

        private static void VerzamelLanden()
        {
            _landen = new List<LandInfo>();
            _landen.Add(new LandInfo() { LandNaam = "Afhanistan", VlagURL = "http://www.flagchart.net/f/p/land/afghanis.gif" });
            _landen.Add(new LandInfo() { LandNaam = "Albanië", VlagURL = "http://www.flagchart.net/f/p/land/albanie.gif" });
            _landen.Add(new LandInfo() { LandNaam = "Algerije", VlagURL = "http://www.flagchart.net/f/p/land/algerije.gif" });
            _landen.Add(new LandInfo() { LandNaam = "België", IsEuropees = true, VlagURL = "http://www.flagchart.net/f/p/land/belgie.gif" });
            _landen.Add(new LandInfo() { LandNaam = "Bhutan", VlagURL = "http://www.flagchart.net/f/p/land/bhutan.gif" });
            _landen.Add(new LandInfo() { LandNaam = "Canada", VlagURL = "http://www.flagchart.net/f/p/land/canada.gif" });
            _landen.Add(new LandInfo() { LandNaam = "Uganda", VlagURL = "http://www.flagchart.net/f/p/land/oeganda.gif" });
            _landen.Add(new LandInfo() { LandNaam = "Verenigd Koninkrijk", IsEuropees = true, VlagURL = "http://www.flagchart.net/f/p/land/uk.gif" });
            _landen.Add(new LandInfo() { LandNaam = "Verenigde Staten", VlagURL = "http://www.flagchart.net/f/p/land/usa.gif" });
        }
    }
}
