// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CABINET_INFO_W.xml' path='doc/member[@name="CABINET_INFO_W"]/*' />
public unsafe partial struct CABINET_INFO_W
{
    /// <include file='CABINET_INFO_W.xml' path='doc/member[@name="CABINET_INFO_W.CabinetPath"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* CabinetPath;

    /// <include file='CABINET_INFO_W.xml' path='doc/member[@name="CABINET_INFO_W.CabinetFile"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* CabinetFile;

    /// <include file='CABINET_INFO_W.xml' path='doc/member[@name="CABINET_INFO_W.DiskName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* DiskName;

    /// <include file='CABINET_INFO_W.xml' path='doc/member[@name="CABINET_INFO_W.SetId"]/*' />
    public ushort SetId;

    /// <include file='CABINET_INFO_W.xml' path='doc/member[@name="CABINET_INFO_W.CabinetNumber"]/*' />
    public ushort CabinetNumber;
}
