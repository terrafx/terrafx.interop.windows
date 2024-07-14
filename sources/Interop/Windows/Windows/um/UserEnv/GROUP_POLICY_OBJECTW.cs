// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW"]/*' />
public unsafe partial struct GROUP_POLICY_OBJECTW
{
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.dwOptions"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOptions;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpDSPath"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* lpDSPath;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpFileSysPath"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* lpFileSysPath;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpDisplayName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* lpDisplayName;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.szGPOName"]/*' />
    [NativeTypeName("WCHAR[50]")]
    public _szGPOName_e__FixedBuffer szGPOName;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.GPOLink"]/*' />
    public GPO_LINK GPOLink;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.pNext"]/*' />
    [NativeTypeName("struct _GROUP_POLICY_OBJECTW *")]
    public GROUP_POLICY_OBJECTW* pNext;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.pPrev"]/*' />
    [NativeTypeName("struct _GROUP_POLICY_OBJECTW *")]
    public GROUP_POLICY_OBJECTW* pPrev;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpExtensions"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* lpExtensions;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lParam2"]/*' />
    public LPARAM lParam2;

    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpLink"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* lpLink;

    /// <include file='_szGPOName_e__FixedBuffer.xml' path='doc/member[@name="_szGPOName_e__FixedBuffer"]/*' />
    [InlineArray(50)]
    public partial struct _szGPOName_e__FixedBuffer
    {
        public char e0;
    }
}
