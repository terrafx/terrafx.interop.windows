// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct DISPATCHER_CONTEXT_NONVOLREG_ARM64
    {
        [FieldOffset(0)]
        [NativeTypeName("BYTE [152]")]
        public fixed byte Buffer[152];

        [FieldOffset(0)]
        [NativeTypeName("_DISPATCHER_CONTEXT_NONVOLREG_ARM64::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:7238:5)")]
        public _Anonymous_e__Struct Anonymous;

        public Span<ulong> GpNvRegs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.GpNvRegs[0], 11);
            }
        }

        public Span<double> FpNvRegs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.FpNvRegs[0], 8);
            }
        }

        public unsafe partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("DWORD64 [11]")]
            public fixed ulong GpNvRegs[11];

            [NativeTypeName("double [8]")]
            public fixed double FpNvRegs[8];
        }
    }
}
