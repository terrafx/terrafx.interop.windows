// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MS_ADDINFO_CATALOGMEMBER.xml' path='doc/member[@name="MS_ADDINFO_CATALOGMEMBER"]/*' />
public unsafe partial struct MS_ADDINFO_CATALOGMEMBER
{
    /// <include file='MS_ADDINFO_CATALOGMEMBER.xml' path='doc/member[@name="MS_ADDINFO_CATALOGMEMBER.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MS_ADDINFO_CATALOGMEMBER.xml' path='doc/member[@name="MS_ADDINFO_CATALOGMEMBER.pStore"]/*' />
    [NativeTypeName("struct CRYPTCATSTORE_ *")]
    public void* pStore;

    /// <include file='MS_ADDINFO_CATALOGMEMBER.xml' path='doc/member[@name="MS_ADDINFO_CATALOGMEMBER.pMember"]/*' />
    [NativeTypeName("struct CRYPTCATMEMBER_ *")]
    public void* pMember;
}
