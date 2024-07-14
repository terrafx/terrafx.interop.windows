// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SOFTKBDDATA.xml' path='doc/member[@name="SOFTKBDDATA"]/*' />
public partial struct SOFTKBDDATA
{
    /// <include file='SOFTKBDDATA.xml' path='doc/member[@name="SOFTKBDDATA.uCount"]/*' />
    public uint uCount;

    /// <include file='SOFTKBDDATA.xml' path='doc/member[@name="SOFTKBDDATA.wCode"]/*' />
    [NativeTypeName("WORD[1][256]")]
    public _wCode_e__FixedBuffer wCode;

    /// <include file='_wCode_e__FixedBuffer.xml' path='doc/member[@name="_wCode_e__FixedBuffer"]/*' />
    [InlineArray(1 * 256)]
    public partial struct _wCode_e__FixedBuffer
    {
        public ushort e0_0;
    }
}
