﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Management_System
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;
        public double WeightMg { get; private set; }
        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }
        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}