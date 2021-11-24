// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILEGROUPDESCRIPTORW
{
    public uint cItems;

    [NativeTypeName("FILEDESCRIPTORW [1]")]
    public _fgd_e__FixedBuffer fgd;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _fgd_e__FixedBuffer
    {
        public FILEDESCRIPTORW e0;

        public ref FILEDESCRIPTORW this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<FILEDESCRIPTORW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
