// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_INFO.xml' path='doc/member[@name="HTTP_REQUEST_INFO"]/*' />
public unsafe partial struct HTTP_REQUEST_INFO
{
    /// <include file='HTTP_REQUEST_INFO.xml' path='doc/member[@name="HTTP_REQUEST_INFO.InfoType"]/*' />
    public HTTP_REQUEST_INFO_TYPE InfoType;

    /// <include file='HTTP_REQUEST_INFO.xml' path='doc/member[@name="HTTP_REQUEST_INFO.InfoLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint InfoLength;

    /// <include file='HTTP_REQUEST_INFO.xml' path='doc/member[@name="HTTP_REQUEST_INFO.pInfo"]/*' />
    [NativeTypeName("PVOID")]
    public void* pInfo;
}
