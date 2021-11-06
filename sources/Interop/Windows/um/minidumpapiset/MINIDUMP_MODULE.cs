// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_MODULE
    {
        [NativeTypeName("ULONG64")]
        public ulong BaseOfImage;

        [NativeTypeName("ULONG32")]
        public uint SizeOfImage;

        [NativeTypeName("ULONG32")]
        public uint CheckSum;

        [NativeTypeName("ULONG32")]
        public uint TimeDateStamp;

        [NativeTypeName("RVA")]
        public uint ModuleNameRva;

        public VS_FIXEDFILEINFO VersionInfo;

        public MINIDUMP_LOCATION_DESCRIPTOR CvRecord;

        public MINIDUMP_LOCATION_DESCRIPTOR MiscRecord;

        [NativeTypeName("ULONG64")]
        public ulong Reserved0;

        [NativeTypeName("ULONG64")]
        public ulong Reserved1;
    }
}
