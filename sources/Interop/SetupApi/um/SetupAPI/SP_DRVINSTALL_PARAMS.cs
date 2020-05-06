// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct SP_DRVINSTALL_PARAMS
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint Rank;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD_PTR")]
        public UIntPtr PrivateData;

        [NativeTypeName("DWORD")]
        public uint Reserved;
    }
}
