﻿// Copyright (c) to owners found in https://github.com/arlm/WinApi/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

using System.Runtime.InteropServices;

namespace Sandbox
{
    public enum D3DKMDT_VIDEO_SIGNAL_STANDARD
    {
        // D3DKMDT_VSS_UNINITIALIZED -> 0
        D3DKMDT_VSS_UNINITIALIZED = 0,

        // D3DKMDT_VSS_VESA_DMT -> 1
        D3DKMDT_VSS_VESA_DMT = 1,

        // D3DKMDT_VSS_VESA_GTF -> 2
        D3DKMDT_VSS_VESA_GTF = 2,

        // D3DKMDT_VSS_VESA_CVT -> 3
        D3DKMDT_VSS_VESA_CVT = 3,

        // D3DKMDT_VSS_IBM -> 4
        D3DKMDT_VSS_IBM = 4,

        // D3DKMDT_VSS_APPLE -> 5
        D3DKMDT_VSS_APPLE = 5,

        // D3DKMDT_VSS_NTSC_M -> 6
        D3DKMDT_VSS_NTSC_M = 6,

        // D3DKMDT_VSS_NTSC_J -> 7
        D3DKMDT_VSS_NTSC_J = 7,

        // D3DKMDT_VSS_NTSC_443 -> 8
        D3DKMDT_VSS_NTSC_443 = 8,

        // D3DKMDT_VSS_PAL_B -> 9
        D3DKMDT_VSS_PAL_B = 9,

        // D3DKMDT_VSS_PAL_B1 -> 10
        D3DKMDT_VSS_PAL_B1 = 10,

        // D3DKMDT_VSS_PAL_G -> 11
        D3DKMDT_VSS_PAL_G = 11,

        // D3DKMDT_VSS_PAL_H -> 12
        D3DKMDT_VSS_PAL_H = 12,

        // D3DKMDT_VSS_PAL_I -> 13
        D3DKMDT_VSS_PAL_I = 13,

        // D3DKMDT_VSS_PAL_D -> 14
        D3DKMDT_VSS_PAL_D = 14,

        // D3DKMDT_VSS_PAL_N -> 15
        D3DKMDT_VSS_PAL_N = 15,

        // D3DKMDT_VSS_PAL_NC -> 16
        D3DKMDT_VSS_PAL_NC = 16,

        // D3DKMDT_VSS_SECAM_B -> 17
        D3DKMDT_VSS_SECAM_B = 17,

        // D3DKMDT_VSS_SECAM_D -> 18
        D3DKMDT_VSS_SECAM_D = 18,

        // D3DKMDT_VSS_SECAM_G -> 19
        D3DKMDT_VSS_SECAM_G = 19,

        // D3DKMDT_VSS_SECAM_H -> 20
        D3DKMDT_VSS_SECAM_H = 20,

        // D3DKMDT_VSS_SECAM_K -> 21
        D3DKMDT_VSS_SECAM_K = 21,

        // D3DKMDT_VSS_SECAM_K1 -> 22
        D3DKMDT_VSS_SECAM_K1 = 22,

        // D3DKMDT_VSS_SECAM_L -> 23
        D3DKMDT_VSS_SECAM_L = 23,

        // D3DKMDT_VSS_SECAM_L1 -> 24
        D3DKMDT_VSS_SECAM_L1 = 24,

        // D3DKMDT_VSS_EIA_861 -> 25
        D3DKMDT_VSS_EIA_861 = 25,

        // D3DKMDT_VSS_EIA_861A -> 26
        D3DKMDT_VSS_EIA_861A = 26,

        // D3DKMDT_VSS_EIA_861B -> 27
        D3DKMDT_VSS_EIA_861B = 27,

        // D3DKMDT_VSS_PAL_K -> 28
        D3DKMDT_VSS_PAL_K = 28,

        // D3DKMDT_VSS_PAL_K1 -> 29
        D3DKMDT_VSS_PAL_K1 = 29,

        // D3DKMDT_VSS_PAL_L -> 30
        D3DKMDT_VSS_PAL_L = 30,

        // D3DKMDT_VSS_PAL_M -> 31
        D3DKMDT_VSS_PAL_M = 31,

        // D3DKMDT_VSS_OTHER -> 255
        D3DKMDT_VSS_OTHER = 255,
    }   
       
}