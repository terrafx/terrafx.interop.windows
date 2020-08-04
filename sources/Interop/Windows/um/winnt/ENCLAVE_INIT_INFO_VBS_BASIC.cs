// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ENCLAVE_INIT_INFO_VBS_BASIC
    {
        [NativeTypeName("BYTE [16]")]
        public fixed byte FamilyId[16];

        [NativeTypeName("BYTE [16]")]
        public fixed byte ImageId[16];

        [NativeTypeName("ULONGLONG")]
        public ulong EnclaveSize;

        [NativeTypeName("DWORD")]
        public uint EnclaveSvn;

        [NativeTypeName("DWORD")]
        public uint Reserved;

        [NativeTypeName("_ENCLAVE_INIT_INFO_VBS_BASIC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:13118:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref IntPtr SignatureInfoHandle => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.SignatureInfoHandle, 1));

        public ref ulong Unused => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Unused, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HANDLE")]
            public IntPtr SignatureInfoHandle;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Unused;
        }
    }
}
