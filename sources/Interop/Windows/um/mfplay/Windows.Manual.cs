// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_IMFPMediaPlayer = new Guid(0xA714590A, 0x58AF, 0x430A, 0x85, 0xBF, 0x44, 0xF5, 0xEC, 0x83, 0x8D, 0x85);

        public static readonly Guid MFP_POSITIONTYPE_100NS = new Guid(0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0);

        public static readonly Guid IID_IMFPMediaItem = new Guid(0x90EB3E6B, 0xECBF, 0x45CC, 0xB1, 0xDA, 0xC6, 0xFE, 0x3E, 0xA7, 0x0D, 0x57);

        public static readonly PROPERTYKEY MFP_PKEY_StreamIndex = new PROPERTYKEY { fmtid = new Guid(0xA7CF9740, 0xE8D9, 0x4A87, 0xBD, 0x8E, 0x29, 0x67, 0x0, 0x1F, 0xD3, 0xAD), pid = 0x00 };

        public static readonly PROPERTYKEY MFP_PKEY_StreamRenderingResults = new PROPERTYKEY { fmtid = new Guid(0xA7CF9740, 0xE8D9, 0x4A87, 0xBD, 0x8E, 0x29, 0x67, 0x0, 0x1F, 0xD3, 0xAD), pid = 0x01 };

        public static readonly Guid IID_IMFPMediaPlayerCallback = new Guid(0x766C8FFB, 0x5FDB, 0x4FEA, 0xA2, 0x8D, 0xB9, 0x12, 0x99, 0x6F, 0x51, 0xBD);
    }
}
