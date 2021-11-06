// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe partial struct MINIDUMP_MODULE_CALLBACK
    {
        [NativeTypeName("PWCHAR")]
        public ushort* FullPath;

        [NativeTypeName("ULONG64")]
        public ulong BaseOfImage;

        [NativeTypeName("ULONG")]
        public uint SizeOfImage;

        [NativeTypeName("ULONG")]
        public uint CheckSum;

        [NativeTypeName("ULONG")]
        public uint TimeDateStamp;

        public VS_FIXEDFILEINFO VersionInfo;

        [NativeTypeName("PVOID")]
        public void* CvRecord;

        [NativeTypeName("ULONG")]
        public uint SizeOfCvRecord;

        [NativeTypeName("PVOID")]
        public void* MiscRecord;

        [NativeTypeName("ULONG")]
        public uint SizeOfMiscRecord;
    }
}
