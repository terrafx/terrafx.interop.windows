// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHChangeProductKeyAsIDList.xml' path='doc/member[@name="SHChangeProductKeyAsIDList"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHChangeProductKeyAsIDList
{
    /// <include file='SHChangeProductKeyAsIDList.xml' path='doc/member[@name="SHChangeProductKeyAsIDList.cb"]/*' />
    public ushort cb;

    /// <include file='SHChangeProductKeyAsIDList.xml' path='doc/member[@name="SHChangeProductKeyAsIDList.wszProductKey"]/*' />
    [NativeTypeName("WCHAR[39]")]
    public _wszProductKey_e__FixedBuffer wszProductKey;

    /// <include file='SHChangeProductKeyAsIDList.xml' path='doc/member[@name="SHChangeProductKeyAsIDList.cbZero"]/*' />
    public ushort cbZero;

    /// <include file='_wszProductKey_e__FixedBuffer.xml' path='doc/member[@name="_wszProductKey_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(39)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _wszProductKey_e__FixedBuffer
    {
        public char e0;
    }
}
