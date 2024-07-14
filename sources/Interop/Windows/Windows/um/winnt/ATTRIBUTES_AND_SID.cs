// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ATTRIBUTES_AND_SID.xml' path='doc/member[@name="ATTRIBUTES_AND_SID"]/*' />
public partial struct ATTRIBUTES_AND_SID
{
    /// <include file='ATTRIBUTES_AND_SID.xml' path='doc/member[@name="ATTRIBUTES_AND_SID.Attributes"]/*' />
    [NativeTypeName("UINT32")]
    public uint Attributes;

    /// <include file='ATTRIBUTES_AND_SID.xml' path='doc/member[@name="ATTRIBUTES_AND_SID.SidStart"]/*' />
    [NativeTypeName("DWORD")]
    public uint SidStart;
}
