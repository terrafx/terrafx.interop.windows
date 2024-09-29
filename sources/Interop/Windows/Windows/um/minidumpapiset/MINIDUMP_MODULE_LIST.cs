// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_MODULE_LIST.xml' path='doc/member[@name="MINIDUMP_MODULE_LIST"]/*' />
public partial struct MINIDUMP_MODULE_LIST
{
    /// <include file='MINIDUMP_MODULE_LIST.xml' path='doc/member[@name="MINIDUMP_MODULE_LIST.NumberOfModules"]/*' />
    [NativeTypeName("ULONG32")]
    public uint NumberOfModules;

    /// <include file='MINIDUMP_MODULE_LIST.xml' path='doc/member[@name="MINIDUMP_MODULE_LIST.Modules"]/*' />
    [NativeTypeName("MINIDUMP_MODULE[0]")]
    public _Modules_e__FixedBuffer Modules;

    /// <include file='_Modules_e__FixedBuffer.xml' path='doc/member[@name="_Modules_e__FixedBuffer"]/*' />
    public partial struct _Modules_e__FixedBuffer
    {
        public MINIDUMP_MODULE e0;

        [UnscopedRef]
        public ref MINIDUMP_MODULE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MINIDUMP_MODULE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
