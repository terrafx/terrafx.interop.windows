// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct KNONVOLATILE_CONTEXT_POINTERS_AMD64
    {
        [NativeTypeName("_KNONVOLATILE_CONTEXT_POINTERS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:4397:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_KNONVOLATILE_CONTEXT_POINTERS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:4419:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public ref M128A* Xmm0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm0;
                }
            }
        }

        public ref M128A* Xmm1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm1;
                }
            }
        }

        public ref M128A* Xmm2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm2;
                }
            }
        }

        public ref M128A* Xmm3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm3;
                }
            }
        }

        public ref M128A* Xmm4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm4;
                }
            }
        }

        public ref M128A* Xmm5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm5;
                }
            }
        }

        public ref M128A* Xmm6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm6;
                }
            }
        }

        public ref M128A* Xmm7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm7;
                }
            }
        }

        public ref M128A* Xmm8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm8;
                }
            }
        }

        public ref M128A* Xmm9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm9;
                }
            }
        }

        public ref M128A* Xmm10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm10;
                }
            }
        }

        public ref M128A* Xmm11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm11;
                }
            }
        }

        public ref M128A* Xmm12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm12;
                }
            }
        }

        public ref M128A* Xmm13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm13;
                }
            }
        }

        public ref M128A* Xmm14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm14;
                }
            }
        }

        public ref M128A* Xmm15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union._Anonymous_e__Struct* pField = &Anonymous1.Anonymous)
                {
                    return ref pField->Xmm15;
                }
            }
        }

        public ref ulong* Rax
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->Rax;
                }
            }
        }

        public ref ulong* Rcx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->Rcx;
                }
            }
        }

        public ref ulong* Rdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->Rdx;
                }
            }
        }

        public ref ulong* Rbx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->Rbx;
                }
            }
        }

        public ref ulong* Rsp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->Rsp;
                }
            }
        }

        public ref ulong* Rbp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->Rbp;
                }
            }
        }

        public ref ulong* Rsi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->Rsi;
                }
            }
        }

        public ref ulong* Rdi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->Rdi;
                }
            }
        }

        public ref ulong* R8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->R8;
                }
            }
        }

        public ref ulong* R9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->R9;
                }
            }
        }

        public ref ulong* R10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->R10;
                }
            }
        }

        public ref ulong* R11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->R11;
                }
            }
        }

        public ref ulong* R12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->R12;
                }
            }
        }

        public ref ulong* R13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->R13;
                }
            }
        }

        public ref ulong* R14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->R14;
                }
            }
        }

        public ref ulong* R15
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union._Anonymous_e__Struct* pField = &Anonymous2.Anonymous)
                {
                    return ref pField->R15;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PM128A [16]")]
            public _FloatingContext_e__FixedBuffer FloatingContext;

            [FieldOffset(0)]
            [NativeTypeName("_KNONVOLATILE_CONTEXT_POINTERS::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:4399:9)")]
            public _Anonymous_e__Struct Anonymous;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("PM128A")]
                public M128A* Xmm0;

                [NativeTypeName("PM128A")]
                public M128A* Xmm1;

                [NativeTypeName("PM128A")]
                public M128A* Xmm2;

                [NativeTypeName("PM128A")]
                public M128A* Xmm3;

                [NativeTypeName("PM128A")]
                public M128A* Xmm4;

                [NativeTypeName("PM128A")]
                public M128A* Xmm5;

                [NativeTypeName("PM128A")]
                public M128A* Xmm6;

                [NativeTypeName("PM128A")]
                public M128A* Xmm7;

                [NativeTypeName("PM128A")]
                public M128A* Xmm8;

                [NativeTypeName("PM128A")]
                public M128A* Xmm9;

                [NativeTypeName("PM128A")]
                public M128A* Xmm10;

                [NativeTypeName("PM128A")]
                public M128A* Xmm11;

                [NativeTypeName("PM128A")]
                public M128A* Xmm12;

                [NativeTypeName("PM128A")]
                public M128A* Xmm13;

                [NativeTypeName("PM128A")]
                public M128A* Xmm14;

                [NativeTypeName("PM128A")]
                public M128A* Xmm15;
            }

            public unsafe partial struct _FloatingContext_e__FixedBuffer
            {
                public M128A* e0;
                public M128A* e1;
                public M128A* e2;
                public M128A* e3;
                public M128A* e4;
                public M128A* e5;
                public M128A* e6;
                public M128A* e7;
                public M128A* e8;
                public M128A* e9;
                public M128A* e10;
                public M128A* e11;
                public M128A* e12;
                public M128A* e13;
                public M128A* e14;
                public M128A* e15;

                public ref M128A* this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        fixed (M128A** pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PDWORD64 [16]")]
            public _IntegerContext_e__FixedBuffer IntegerContext;

            [FieldOffset(0)]
            [NativeTypeName("_KNONVOLATILE_CONTEXT_POINTERS::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:4421:9)")]
            public _Anonymous_e__Struct Anonymous;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("PDWORD64")]
                public ulong* Rax;

                [NativeTypeName("PDWORD64")]
                public ulong* Rcx;

                [NativeTypeName("PDWORD64")]
                public ulong* Rdx;

                [NativeTypeName("PDWORD64")]
                public ulong* Rbx;

                [NativeTypeName("PDWORD64")]
                public ulong* Rsp;

                [NativeTypeName("PDWORD64")]
                public ulong* Rbp;

                [NativeTypeName("PDWORD64")]
                public ulong* Rsi;

                [NativeTypeName("PDWORD64")]
                public ulong* Rdi;

                [NativeTypeName("PDWORD64")]
                public ulong* R8;

                [NativeTypeName("PDWORD64")]
                public ulong* R9;

                [NativeTypeName("PDWORD64")]
                public ulong* R10;

                [NativeTypeName("PDWORD64")]
                public ulong* R11;

                [NativeTypeName("PDWORD64")]
                public ulong* R12;

                [NativeTypeName("PDWORD64")]
                public ulong* R13;

                [NativeTypeName("PDWORD64")]
                public ulong* R14;

                [NativeTypeName("PDWORD64")]
                public ulong* R15;
            }

            public unsafe partial struct _IntegerContext_e__FixedBuffer
            {
                public ulong* e0;
                public ulong* e1;
                public ulong* e2;
                public ulong* e3;
                public ulong* e4;
                public ulong* e5;
                public ulong* e6;
                public ulong* e7;
                public ulong* e8;
                public ulong* e9;
                public ulong* e10;
                public ulong* e11;
                public ulong* e12;
                public ulong* e13;
                public ulong* e14;
                public ulong* e15;

                public ref ulong* this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        fixed (ulong** pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }
}
