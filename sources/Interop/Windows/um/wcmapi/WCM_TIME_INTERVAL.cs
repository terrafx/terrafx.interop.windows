// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WCM_TIME_INTERVAL
    {
        [NativeTypeName("WORD")]
        public ushort wYear;

        [NativeTypeName("WORD")]
        public ushort wMonth;

        [NativeTypeName("WORD")]
        public ushort wDay;

        [NativeTypeName("WORD")]
        public ushort wHour;

        [NativeTypeName("WORD")]
        public ushort wMinute;

        [NativeTypeName("WORD")]
        public ushort wSecond;

        [NativeTypeName("WORD")]
        public ushort wMilliseconds;
    }
}
