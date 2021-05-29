// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RemFORMATETC
    {
        [NativeTypeName("DWORD")]
        public uint cfFormat;

        [NativeTypeName("DWORD")]
        public uint ptd;

        [NativeTypeName("DWORD")]
        public uint dwAspect;

        [NativeTypeName("LONG")]
        public int lindex;

        [NativeTypeName("DWORD")]
        public uint tymed;
    }
}
