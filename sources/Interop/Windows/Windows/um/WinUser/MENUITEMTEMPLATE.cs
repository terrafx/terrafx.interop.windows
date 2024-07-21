// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MENUITEMTEMPLATE.xml' path='doc/member[@name="MENUITEMTEMPLATE"]/*' />
public partial struct MENUITEMTEMPLATE
{
    /// <include file='MENUITEMTEMPLATE.xml' path='doc/member[@name="MENUITEMTEMPLATE.mtOption"]/*' />
    [NativeTypeName("WORD")]
    public ushort mtOption;

    /// <include file='MENUITEMTEMPLATE.xml' path='doc/member[@name="MENUITEMTEMPLATE.mtID"]/*' />
    [NativeTypeName("WORD")]
    public ushort mtID;

    /// <include file='MENUITEMTEMPLATE.xml' path='doc/member[@name="MENUITEMTEMPLATE.mtString"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _mtString_e__FixedBuffer mtString;

    /// <include file='_mtString_e__FixedBuffer.xml' path='doc/member[@name="_mtString_e__FixedBuffer"]/*' />
    public partial struct _mtString_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
