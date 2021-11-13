// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct VMRMONITORINFO
    {
        public VMRGUID guid;

        public RECT rcMonitor;

        public HMONITOR hMon;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("wchar_t [32]")]
        public fixed ushort szDevice[32];

        [NativeTypeName("wchar_t [256]")]
        public fixed ushort szDescription[256];

        public LARGE_INTEGER liDriverVersion;

        [NativeTypeName("DWORD")]
        public uint dwVendorId;

        [NativeTypeName("DWORD")]
        public uint dwDeviceId;

        [NativeTypeName("DWORD")]
        public uint dwSubSysId;

        [NativeTypeName("DWORD")]
        public uint dwRevision;
    }
}
