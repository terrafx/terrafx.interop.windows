// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='AM_PROPERTY_SPPAL.xml' path='doc/member[@name="AM_PROPERTY_SPPAL"]/*' />
public partial struct AM_PROPERTY_SPPAL
{
    /// <include file='AM_PROPERTY_SPPAL.xml' path='doc/member[@name="AM_PROPERTY_SPPAL.sppal"]/*' />
    [NativeTypeName("AM_DVD_YUV[16]")]
    public _sppal_e__FixedBuffer sppal;

    /// <include file='_sppal_e__FixedBuffer.xml' path='doc/member[@name="_sppal_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _sppal_e__FixedBuffer
    {
        public AM_DVD_YUV e0;
    }
}
