// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='SP_ENABLECLASS_PARAMS.xml' path='doc/member[@name="SP_ENABLECLASS_PARAMS"]/*' />
public partial struct SP_ENABLECLASS_PARAMS
{
    /// <include file='SP_ENABLECLASS_PARAMS.xml' path='doc/member[@name="SP_ENABLECLASS_PARAMS.ClassInstallHeader"]/*' />
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    /// <include file='SP_ENABLECLASS_PARAMS.xml' path='doc/member[@name="SP_ENABLECLASS_PARAMS.ClassGuid"]/*' />
    public Guid ClassGuid;

    /// <include file='SP_ENABLECLASS_PARAMS.xml' path='doc/member[@name="SP_ENABLECLASS_PARAMS.EnableMessage"]/*' />
    [NativeTypeName("DWORD")]
    public uint EnableMessage;
}
