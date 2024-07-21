// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/comcat.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CATEGORYINFO.xml' path='doc/member[@name="CATEGORYINFO"]/*' />
public partial struct CATEGORYINFO
{
    /// <include file='CATEGORYINFO.xml' path='doc/member[@name="CATEGORYINFO.catid"]/*' />
    [NativeTypeName("CATID")]
    public Guid catid;

    /// <include file='CATEGORYINFO.xml' path='doc/member[@name="CATEGORYINFO.lcid"]/*' />
    [NativeTypeName("LCID")]
    public uint lcid;

    /// <include file='CATEGORYINFO.xml' path='doc/member[@name="CATEGORYINFO.szDescription"]/*' />
    [NativeTypeName("OLECHAR[128]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public char e0;
    }
}
