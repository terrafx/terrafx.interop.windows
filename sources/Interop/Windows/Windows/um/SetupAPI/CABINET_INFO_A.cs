// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CABINET_INFO_A.xml' path='doc/member[@name="CABINET_INFO_A"]/*' />
public unsafe partial struct CABINET_INFO_A
{
    /// <include file='CABINET_INFO_A.xml' path='doc/member[@name="CABINET_INFO_A.CabinetPath"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* CabinetPath;

    /// <include file='CABINET_INFO_A.xml' path='doc/member[@name="CABINET_INFO_A.CabinetFile"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* CabinetFile;

    /// <include file='CABINET_INFO_A.xml' path='doc/member[@name="CABINET_INFO_A.DiskName"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* DiskName;

    /// <include file='CABINET_INFO_A.xml' path='doc/member[@name="CABINET_INFO_A.SetId"]/*' />
    public ushort SetId;

    /// <include file='CABINET_INFO_A.xml' path='doc/member[@name="CABINET_INFO_A.CabinetNumber"]/*' />
    public ushort CabinetNumber;
}
