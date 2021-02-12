// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_RUNTIME_FUNCTION_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint BeginAddress;

        [NativeTypeName("DWORD")]
        public uint EndAddress;

        [NativeTypeName("_IMAGE_RUNTIME_FUNCTION_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18859:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint UnwindInfoAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UnwindInfoAddress, 1));
            }
        }

        public ref uint UnwindData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.UnwindData, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint UnwindInfoAddress;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint UnwindData;
        }
    }
}
