// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CONFIG_CI_PROV_INFO_RESULT2.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT2"]/*' />
public unsafe partial struct CONFIG_CI_PROV_INFO_RESULT2
{
    /// <include file='CONFIG_CI_PROV_INFO_RESULT2.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT2.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CONFIG_CI_PROV_INFO_RESULT2.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT2.hr"]/*' />
    public HRESULT hr;

    /// <include file='CONFIG_CI_PROV_INFO_RESULT2.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT2.dwResult"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwResult;

    /// <include file='CONFIG_CI_PROV_INFO_RESULT2.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT2.dwPolicyIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPolicyIndex;

    /// <include file='CONFIG_CI_PROV_INFO_RESULT2.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT2.fIsExplicitDeny"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte fIsExplicitDeny;

    /// <include file='CONFIG_CI_PROV_INFO_RESULT2.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT2.cbCalculatedFileHash"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbCalculatedFileHash;

    /// <include file='CONFIG_CI_PROV_INFO_RESULT2.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT2.pbCalculatedFileHash"]/*' />
    public byte* pbCalculatedFileHash;
}
