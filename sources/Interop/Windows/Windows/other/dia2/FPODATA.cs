// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='FPODATA.xml' path='doc/member[@name="FPODATA"]/*' />
public partial struct FPODATA
{
    /// <include file='FPODATA.xml' path='doc/member[@name="FPODATA.ulOffStart"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulOffStart;

    /// <include file='FPODATA.xml' path='doc/member[@name="FPODATA.cbProcSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbProcSize;

    /// <include file='FPODATA.xml' path='doc/member[@name="FPODATA.cdwLocals"]/*' />
    [NativeTypeName("DWORD")]
    public uint cdwLocals;

    /// <include file='FPODATA.xml' path='doc/member[@name="FPODATA.cdwParams"]/*' />
    [NativeTypeName("WORD")]
    public ushort cdwParams;

    /// <include file='FPODATA.xml' path='doc/member[@name="FPODATA.cdwFlags"]/*' />
    [NativeTypeName("WORD")]
    public ushort cdwFlags;
}
