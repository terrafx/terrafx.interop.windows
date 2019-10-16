// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct GDIREGISTERDDRAWPACKET
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("DDRAWMARSHCALLBACKMARSHAL")]
        public IntPtr pfnDdMarshal;

        [NativeTypeName("DDRAWMARSHCALLBACKUNMARSHAL")]
        public IntPtr pfnDdUnmarshal;

        [NativeTypeName("DDRAWMARSHCALLBACKRELEASE")]
        public IntPtr pfnDdRelease;
    }
}
