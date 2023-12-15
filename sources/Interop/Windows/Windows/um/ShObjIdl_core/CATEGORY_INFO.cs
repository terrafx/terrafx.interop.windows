// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CATEGORY_INFO.xml' path='doc/member[@name="CATEGORY_INFO"]/*' />
public partial struct CATEGORY_INFO
{
    /// <include file='CATEGORY_INFO.xml' path='doc/member[@name="CATEGORY_INFO.cif"]/*' />
    public CATEGORYINFO_FLAGS cif;

    /// <include file='CATEGORY_INFO.xml' path='doc/member[@name="CATEGORY_INFO.wszName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _wszName_e__FixedBuffer wszName;

    /// <include file='_wszName_e__FixedBuffer.xml' path='doc/member[@name="_wszName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _wszName_e__FixedBuffer
    {
        public char e0;
    }
}
