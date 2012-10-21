﻿// OsmSharp - OpenStreetMap tools & library.
// Copyright (C) 2012 Abelshausen Ben
// 
// This file is part of OsmSharp.
// 
// Foobar is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// Foobar is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with OsmSharp. If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools.Math.Units.Time;
using Tools.Math.Units.Speed;

namespace Tools.Math.Units.Distance
{
    /// <summary>
    /// Represents a distance in kilometers.
    /// </summary>
    public class Kilometer : Unit
    {
        public Kilometer()
            : base(0.0d)
        {

        }

        private Kilometer(double value)
            : base(value)
        {

        }

        #region Conversions

        public static implicit operator Kilometer(double value)
        {
            return new Kilometer(value);
        }

        public static implicit operator Kilometer(Meter meter)
        {
            return meter.Value / 1000d;
        }

        #endregion
        
        #region Division

        public static KilometerPerHour operator /(Kilometer kilometer, Hour hour)
        {
            return kilometer.Value / hour.Value;
        }

        public static Hour operator /(Kilometer distance, KilometerPerHour speed)
        {
            return distance.Value / speed.Value;
        }

        #endregion

        public override string ToString()
        {
            return this.Value.ToString() + "Km";
        }
    }
}