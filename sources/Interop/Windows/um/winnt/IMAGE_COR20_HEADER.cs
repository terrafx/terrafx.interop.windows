// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_COR20_HEADER
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("WORD")]
        public ushort MajorRuntimeVersion;

        [NativeTypeName("WORD")]
        public ushort MinorRuntimeVersion;

        public IMAGE_DATA_DIRECTORY MetaData;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("IMAGE_COR20_HEADER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:19208:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint EntryPointToken => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.EntryPointToken, 1));

        public ref uint EntryPointRVA => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.EntryPointRVA, 1));

        public IMAGE_DATA_DIRECTORY Resources;

        public IMAGE_DATA_DIRECTORY StrongNameSignature;

        public IMAGE_DATA_DIRECTORY CodeManagerTable;

        public IMAGE_DATA_DIRECTORY VTableFixups;

        public IMAGE_DATA_DIRECTORY ExportAddressTableJumps;

        public IMAGE_DATA_DIRECTORY ManagedNativeHeader;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint EntryPointToken;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint EntryPointRVA;
        }
    }
}
