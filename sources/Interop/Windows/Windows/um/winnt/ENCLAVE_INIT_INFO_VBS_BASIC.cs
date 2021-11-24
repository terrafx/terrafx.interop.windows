// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

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

    [NativeTypeName("_ENCLAVE_INIT_INFO_VBS_BASIC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:14295:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref HANDLE SignatureInfoHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.SignatureInfoHandle;
        }
    }

    public ref ulong Unused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Unused, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HANDLE SignatureInfoHandle;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Unused;
    }
}
