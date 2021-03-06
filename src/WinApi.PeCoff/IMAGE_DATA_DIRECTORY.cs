﻿// Copyright (c) to owners found in https://github.com/arlm/WinApi/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

using System;

namespace WinApi.PeCoff
{
    public struct IMAGE_DATA_DIRECTORY : IEquatable<IMAGE_DATA_DIRECTORY>
    {
        public uint Size;
        public uint VirtualAddress;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            var x = obj as IMAGE_DATA_DIRECTORY?;

            if (!x.HasValue)
            {
                return false;
            }

            return Equals(x);
        }

        public bool Equals(IMAGE_DATA_DIRECTORY other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (Size != other.Size)
            {
                return false;
            }           

            return VirtualAddress == other.VirtualAddress;
        }

        public override int GetHashCode()
        {
            // From The Online Encyclopedia of Integer Sequences: https://oeis.org/A000668
            // Mersenne primes (of form 2^p - 1 where p is a prime).
            const int mersenePrime = 131071;
            int hash = 8191;

            unchecked
            {
                hash = (hash * mersenePrime) + this.Size.GetHashCode();
                hash = (hash * mersenePrime) + this.VirtualAddress.GetHashCode();
            }

            return hash;
        }

        public static bool operator ==(IMAGE_DATA_DIRECTORY x, IMAGE_DATA_DIRECTORY y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(IMAGE_DATA_DIRECTORY x, IMAGE_DATA_DIRECTORY y)
        {
            return !x.Equals(y);
        }
    }
}