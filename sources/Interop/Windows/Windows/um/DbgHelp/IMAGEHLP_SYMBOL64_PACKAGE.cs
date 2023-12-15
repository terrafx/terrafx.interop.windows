// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_SYMBOL64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOL64_PACKAGE"]/*' />
public partial struct IMAGEHLP_SYMBOL64_PACKAGE
{
    /// <include file='IMAGEHLP_SYMBOL64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOL64_PACKAGE.sym"]/*' />
    public IMAGEHLP_SYMBOL64 sym;

    /// <include file='IMAGEHLP_SYMBOL64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOL64_PACKAGE.name"]/*' />
    [NativeTypeName("CHAR[2001]")]
    public _name_e__FixedBuffer name;

    /// <include file='_name_e__FixedBuffer.xml' path='doc/member[@name="_name_e__FixedBuffer"]/*' />
    [InlineArray(2001)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _name_e__FixedBuffer
    {
        public sbyte e0;
    }
}
