// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ARM64_NT_CONTEXT
    {
        [NativeTypeName("DWORD")]
        public uint ContextFlags;

        [NativeTypeName("DWORD")]
        public uint Cpsr;

        [NativeTypeName("_ARM64_NT_CONTEXT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:6685:18)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD64")]
        public ulong Sp;

        [NativeTypeName("DWORD64")]
        public ulong Pc;

        [NativeTypeName("ARM64_NT_NEON128 [32]")]
        public _V_e__FixedBuffer V;

        [NativeTypeName("DWORD")]
        public uint Fpcr;

        [NativeTypeName("DWORD")]
        public uint Fpsr;

        [NativeTypeName("DWORD [8]")]
        public fixed uint Bcr[8];

        [NativeTypeName("DWORD64 [8]")]
        public fixed ulong Bvr[8];

        [NativeTypeName("DWORD [2]")]
        public fixed uint Wcr[2];

        [NativeTypeName("DWORD64 [2]")]
        public fixed ulong Wvr[2];

        public ref ulong X0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X0, 1));
            }
        }

        public ref ulong X1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X1, 1));
            }
        }

        public ref ulong X2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X2, 1));
            }
        }

        public ref ulong X3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X3, 1));
            }
        }

        public ref ulong X4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X4, 1));
            }
        }

        public ref ulong X5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X5, 1));
            }
        }

        public ref ulong X6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X6, 1));
            }
        }

        public ref ulong X7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X7, 1));
            }
        }

        public ref ulong X8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X8, 1));
            }
        }

        public ref ulong X9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X9, 1));
            }
        }

        public ref ulong X10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X10, 1));
            }
        }

        public ref ulong X11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X11, 1));
            }
        }

        public ref ulong X12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X12, 1));
            }
        }

        public ref ulong X13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X13, 1));
            }
        }

        public ref ulong X14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X14, 1));
            }
        }

        public ref ulong X15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X15, 1));
            }
        }

        public ref ulong X16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X16, 1));
            }
        }

        public ref ulong X17
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X17, 1));
            }
        }

        public ref ulong X18
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X18, 1));
            }
        }

        public ref ulong X19
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X19, 1));
            }
        }

        public ref ulong X20
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X20, 1));
            }
        }

        public ref ulong X21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X21, 1));
            }
        }

        public ref ulong X22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X22, 1));
            }
        }

        public ref ulong X23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X23, 1));
            }
        }

        public ref ulong X24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X24, 1));
            }
        }

        public ref ulong X25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X25, 1));
            }
        }

        public ref ulong X26
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X26, 1));
            }
        }

        public ref ulong X27
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X27, 1));
            }
        }

        public ref ulong X28
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.X28, 1));
            }
        }

        public ref ulong Fp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Fp, 1));
            }
        }

        public ref ulong Lr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Lr, 1));
            }
        }

        public Span<ulong> X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.X[0], 31);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_ARM64_NT_CONTEXT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:6686:21)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("DWORD64 [31]")]
            public fixed ulong X[31];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("DWORD64")]
                public ulong X0;

                [NativeTypeName("DWORD64")]
                public ulong X1;

                [NativeTypeName("DWORD64")]
                public ulong X2;

                [NativeTypeName("DWORD64")]
                public ulong X3;

                [NativeTypeName("DWORD64")]
                public ulong X4;

                [NativeTypeName("DWORD64")]
                public ulong X5;

                [NativeTypeName("DWORD64")]
                public ulong X6;

                [NativeTypeName("DWORD64")]
                public ulong X7;

                [NativeTypeName("DWORD64")]
                public ulong X8;

                [NativeTypeName("DWORD64")]
                public ulong X9;

                [NativeTypeName("DWORD64")]
                public ulong X10;

                [NativeTypeName("DWORD64")]
                public ulong X11;

                [NativeTypeName("DWORD64")]
                public ulong X12;

                [NativeTypeName("DWORD64")]
                public ulong X13;

                [NativeTypeName("DWORD64")]
                public ulong X14;

                [NativeTypeName("DWORD64")]
                public ulong X15;

                [NativeTypeName("DWORD64")]
                public ulong X16;

                [NativeTypeName("DWORD64")]
                public ulong X17;

                [NativeTypeName("DWORD64")]
                public ulong X18;

                [NativeTypeName("DWORD64")]
                public ulong X19;

                [NativeTypeName("DWORD64")]
                public ulong X20;

                [NativeTypeName("DWORD64")]
                public ulong X21;

                [NativeTypeName("DWORD64")]
                public ulong X22;

                [NativeTypeName("DWORD64")]
                public ulong X23;

                [NativeTypeName("DWORD64")]
                public ulong X24;

                [NativeTypeName("DWORD64")]
                public ulong X25;

                [NativeTypeName("DWORD64")]
                public ulong X26;

                [NativeTypeName("DWORD64")]
                public ulong X27;

                [NativeTypeName("DWORD64")]
                public ulong X28;

                [NativeTypeName("DWORD64")]
                public ulong Fp;

                [NativeTypeName("DWORD64")]
                public ulong Lr;
            }
        }

        public partial struct _V_e__FixedBuffer
        {
            public ARM64_NT_NEON128 e0;
            public ARM64_NT_NEON128 e1;
            public ARM64_NT_NEON128 e2;
            public ARM64_NT_NEON128 e3;
            public ARM64_NT_NEON128 e4;
            public ARM64_NT_NEON128 e5;
            public ARM64_NT_NEON128 e6;
            public ARM64_NT_NEON128 e7;
            public ARM64_NT_NEON128 e8;
            public ARM64_NT_NEON128 e9;
            public ARM64_NT_NEON128 e10;
            public ARM64_NT_NEON128 e11;
            public ARM64_NT_NEON128 e12;
            public ARM64_NT_NEON128 e13;
            public ARM64_NT_NEON128 e14;
            public ARM64_NT_NEON128 e15;
            public ARM64_NT_NEON128 e16;
            public ARM64_NT_NEON128 e17;
            public ARM64_NT_NEON128 e18;
            public ARM64_NT_NEON128 e19;
            public ARM64_NT_NEON128 e20;
            public ARM64_NT_NEON128 e21;
            public ARM64_NT_NEON128 e22;
            public ARM64_NT_NEON128 e23;
            public ARM64_NT_NEON128 e24;
            public ARM64_NT_NEON128 e25;
            public ARM64_NT_NEON128 e26;
            public ARM64_NT_NEON128 e27;
            public ARM64_NT_NEON128 e28;
            public ARM64_NT_NEON128 e29;
            public ARM64_NT_NEON128 e30;
            public ARM64_NT_NEON128 e31;

            public ref ARM64_NT_NEON128 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<ARM64_NT_NEON128> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
        }
    }
}
