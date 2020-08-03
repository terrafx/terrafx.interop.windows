// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AMCOPPCommand
    {
        [NativeTypeName("GUID")]
        public Guid macKDI;

        [NativeTypeName("GUID")]
        public Guid guidCommandID;

        [NativeTypeName("DWORD")]
        public uint dwSequence;

        [NativeTypeName("DWORD")]
        public uint cbSizeData;

        [NativeTypeName("BYTE [4056]")]
        public fixed byte CommandData[4056];
    }
}
