// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct EMRFORMAT
    {
        [NativeTypeName("DWORD")]
        public uint dSignature;

        [NativeTypeName("DWORD")]
        public uint nVersion;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("DWORD")]
        public uint offData;
    }
}
