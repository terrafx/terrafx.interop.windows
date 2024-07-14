// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='POWER_LIMIT_VALUE.xml' path='doc/member[@name="POWER_LIMIT_VALUE"]/*' />
public partial struct POWER_LIMIT_VALUE
{
    /// <include file='POWER_LIMIT_VALUE.xml' path='doc/member[@name="POWER_LIMIT_VALUE.Type"]/*' />
    public POWER_LIMIT_TYPES Type;

    /// <include file='POWER_LIMIT_VALUE.xml' path='doc/member[@name="POWER_LIMIT_VALUE.DomainId"]/*' />
    [NativeTypeName("DWORD")]
    public uint DomainId;

    /// <include file='POWER_LIMIT_VALUE.xml' path='doc/member[@name="POWER_LIMIT_VALUE.TargetValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint TargetValue;

    /// <include file='POWER_LIMIT_VALUE.xml' path='doc/member[@name="POWER_LIMIT_VALUE.TimeParameter"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeParameter;
}
