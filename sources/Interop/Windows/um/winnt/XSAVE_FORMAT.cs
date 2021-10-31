// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct XSAVE_FORMAT
    {
        [NativeTypeName("WORD")]
        public ushort ControlWord;

        [NativeTypeName("WORD")]
        public ushort StatusWord;

        public byte TagWord;

        public byte Reserved1;

        [NativeTypeName("WORD")]
        public ushort ErrorOpcode;

        [NativeTypeName("DWORD")]
        public uint ErrorOffset;

        [NativeTypeName("WORD")]
        public ushort ErrorSelector;

        [NativeTypeName("WORD")]
        public ushort Reserved2;

        [NativeTypeName("DWORD")]
        public uint DataOffset;

        [NativeTypeName("WORD")]
        public ushort DataSelector;

        [NativeTypeName("WORD")]
        public ushort Reserved3;

        [NativeTypeName("DWORD")]
        public uint MxCsr;

        [NativeTypeName("DWORD")]
        public uint MxCsr_Mask;

        [NativeTypeName("M128A [8]")]
        public _FloatRegisters_e__FixedBuffer FloatRegisters;

        [NativeTypeName("M128A [16]")]
        public _XmmRegisters_e__FixedBuffer XmmRegisters;

        [NativeTypeName("BYTE [96]")]
        public fixed byte Reserved4[96];

        public partial struct _FloatRegisters_e__FixedBuffer
        {
            public M128A e0;
            public M128A e1;
            public M128A e2;
            public M128A e3;
            public M128A e4;
            public M128A e5;
            public M128A e6;
            public M128A e7;

            public ref M128A this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }

        public partial struct _XmmRegisters_e__FixedBuffer
        {
            public M128A e0;
            public M128A e1;
            public M128A e2;
            public M128A e3;
            public M128A e4;
            public M128A e5;
            public M128A e6;
            public M128A e7;
            public M128A e8;
            public M128A e9;
            public M128A e10;
            public M128A e11;
            public M128A e12;
            public M128A e13;
            public M128A e14;
            public M128A e15;

            public ref M128A this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
