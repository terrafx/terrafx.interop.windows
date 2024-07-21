// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MSIFILEHASHINFO.xml' path='doc/member[@name="MSIFILEHASHINFO"]/*' />
public partial struct MSIFILEHASHINFO
{
    /// <include file='MSIFILEHASHINFO.xml' path='doc/member[@name="MSIFILEHASHINFO.dwFileHashInfoSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint dwFileHashInfoSize;

    /// <include file='MSIFILEHASHINFO.xml' path='doc/member[@name="MSIFILEHASHINFO.dwData"]/*' />
    [NativeTypeName("ULONG[4]")]
    public _dwData_e__FixedBuffer dwData;

    /// <include file='_dwData_e__FixedBuffer.xml' path='doc/member[@name="_dwData_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _dwData_e__FixedBuffer
    {
        public uint e0;
    }
}
