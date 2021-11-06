// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_MODULE_LIST
    {
        [NativeTypeName("ULONG32")]
        public uint NumberOfModules;

        [NativeTypeName("MINIDUMP_MODULE [0]")]
        public _Modules_e__FixedBuffer Modules;

        public partial struct _Modules_e__FixedBuffer
        {
            public MINIDUMP_MODULE e0;

            public ref MINIDUMP_MODULE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<MINIDUMP_MODULE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 1);
        }
    }
}
