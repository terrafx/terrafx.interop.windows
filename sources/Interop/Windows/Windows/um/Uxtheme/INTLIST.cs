// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='INTLIST.xml' path='doc/member[@name="INTLIST"]/*' />
public partial struct INTLIST
{
    /// <include file='INTLIST.xml' path='doc/member[@name="INTLIST.iValueCount"]/*' />
    public int iValueCount;

    /// <include file='INTLIST.xml' path='doc/member[@name="INTLIST.iValues"]/*' />
    [NativeTypeName("int[402]")]
    public _iValues_e__FixedBuffer iValues;

    /// <include file='_iValues_e__FixedBuffer.xml' path='doc/member[@name="_iValues_e__FixedBuffer"]/*' />
    [InlineArray(402)]
    public partial struct _iValues_e__FixedBuffer
    {
        public int e0;
    }
}
