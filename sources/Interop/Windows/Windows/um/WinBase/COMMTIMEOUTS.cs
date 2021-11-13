// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct COMMTIMEOUTS
    {
        [NativeTypeName("DWORD")]
        public uint ReadIntervalTimeout;

        [NativeTypeName("DWORD")]
        public uint ReadTotalTimeoutMultiplier;

        [NativeTypeName("DWORD")]
        public uint ReadTotalTimeoutConstant;

        [NativeTypeName("DWORD")]
        public uint WriteTotalTimeoutMultiplier;

        [NativeTypeName("DWORD")]
        public uint WriteTotalTimeoutConstant;
    }
}
