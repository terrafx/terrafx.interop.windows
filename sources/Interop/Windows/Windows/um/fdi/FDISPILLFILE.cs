// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FDISPILLFILE.xml' path='doc/member[@name="FDISPILLFILE"]/*' />
public partial struct FDISPILLFILE
{
    /// <include file='FDISPILLFILE.xml' path='doc/member[@name="FDISPILLFILE.ach"]/*' />
    [NativeTypeName("char[2]")]
    public _ach_e__FixedBuffer ach;

    /// <include file='FDISPILLFILE.xml' path='doc/member[@name="FDISPILLFILE.cbFile"]/*' />
    [NativeTypeName("long")]
    public int cbFile;

    /// <include file='_ach_e__FixedBuffer.xml' path='doc/member[@name="_ach_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _ach_e__FixedBuffer
    {
        public sbyte e0;
    }
}
