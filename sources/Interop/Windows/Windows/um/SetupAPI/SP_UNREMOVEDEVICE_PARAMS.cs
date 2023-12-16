// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_UNREMOVEDEVICE_PARAMS.xml' path='doc/member[@name="SP_UNREMOVEDEVICE_PARAMS"]/*' />
public partial struct SP_UNREMOVEDEVICE_PARAMS
{
    /// <include file='SP_UNREMOVEDEVICE_PARAMS.xml' path='doc/member[@name="SP_UNREMOVEDEVICE_PARAMS.ClassInstallHeader"]/*' />
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    /// <include file='SP_UNREMOVEDEVICE_PARAMS.xml' path='doc/member[@name="SP_UNREMOVEDEVICE_PARAMS.Scope"]/*' />
    [NativeTypeName("DWORD")]
    public uint Scope;

    /// <include file='SP_UNREMOVEDEVICE_PARAMS.xml' path='doc/member[@name="SP_UNREMOVEDEVICE_PARAMS.HwProfile"]/*' />
    [NativeTypeName("DWORD")]
    public uint HwProfile;
}
