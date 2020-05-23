// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct HIT_LOGGING_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwStructSize;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszLoggedUrlName;

        public SYSTEMTIME StartTime;

        public SYSTEMTIME EndTime;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszExtendedInfo;
    }
}
