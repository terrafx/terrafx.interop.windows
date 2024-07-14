// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DESIGNVECTOR.xml' path='doc/member[@name="DESIGNVECTOR"]/*' />
public partial struct DESIGNVECTOR
{
    /// <include file='DESIGNVECTOR.xml' path='doc/member[@name="DESIGNVECTOR.dvReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dvReserved;

    /// <include file='DESIGNVECTOR.xml' path='doc/member[@name="DESIGNVECTOR.dvNumAxes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dvNumAxes;

    /// <include file='DESIGNVECTOR.xml' path='doc/member[@name="DESIGNVECTOR.dvValues"]/*' />
    [NativeTypeName("LONG[16]")]
    public _dvValues_e__FixedBuffer dvValues;

    /// <include file='_dvValues_e__FixedBuffer.xml' path='doc/member[@name="_dvValues_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _dvValues_e__FixedBuffer
    {
        public int e0;
    }
}
