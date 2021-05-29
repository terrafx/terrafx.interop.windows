// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RESOURCEMANAGER_BASIC_INFORMATION
    {
        [NativeTypeName("GUID")]
        public Guid ResourceManagerId;

        [NativeTypeName("DWORD")]
        public uint DescriptionLength;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort Description[1];
    }
}
