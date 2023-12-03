// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='OLEMENUGROUPWIDTHS.xml' path='doc/member[@name="OLEMENUGROUPWIDTHS"]/*' />
public partial struct OLEMENUGROUPWIDTHS
{
    /// <include file='OLEMENUGROUPWIDTHS.xml' path='doc/member[@name="OLEMENUGROUPWIDTHS.width"]/*' />
    [NativeTypeName("LONG[6]")]
    public _width_e__FixedBuffer width;

    /// <include file='_width_e__FixedBuffer.xml' path='doc/member[@name="_width_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _width_e__FixedBuffer
    {
        public int e0;
    }
}
