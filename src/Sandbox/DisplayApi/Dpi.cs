﻿// Copyright (c) to owners found in https://github.com/arlm/WinApi/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace Sandbox
{
    public struct Dpi
    {
        #region Public Fields

        public static readonly Dpi Default = new Dpi(96, 96);

        #endregion Public Fields

        #region Public Constructors

        public Dpi(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        #endregion Public Constructors

        #region Public Properties

        public int X { get; set; }

        public int Y { get; set; }

        #endregion Public Properties

        #region Public Methods

        public static bool operator !=(Dpi dpi1, Dpi dpi2)
        {
            return !(dpi1 == dpi2);
        }

        public static bool operator ==(Dpi dpi1, Dpi dpi2)
        {
            return dpi1.X == dpi2.X && dpi1.Y == dpi2.Y;
        }

        public bool Equals(Dpi other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        public override bool Equals(object other)
        {
            if (ReferenceEquals(this, other))
            {
                return false;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            return other is Dpi && this.Equals((Dpi)other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int)this.X * 397) ^ (int)this.Y;
            }
        }

        public override string ToString()
        {
            return string.Format("[X={0},Y={1}]", this.X, this.Y);
        }

        #endregion Public Methods
    }
}