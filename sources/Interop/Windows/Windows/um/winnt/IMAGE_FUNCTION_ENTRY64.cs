// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct IMAGE_FUNCTION_ENTRY64
{
    [NativeTypeName("ULONGLONG")]
    public ulong StartingAddress;

    [NativeTypeName("ULONGLONG")]
    public ulong EndingAddress;

    [NativeTypeName("_IMAGE_FUNCTION_ENTRY64::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:20344:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref ulong EndOfPrologue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.EndOfPrologue, 1));
        }
    }

    public ref ulong UnwindInfoAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UnwindInfoAddress, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong EndOfPrologue;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong UnwindInfoAddress;
    }
}
