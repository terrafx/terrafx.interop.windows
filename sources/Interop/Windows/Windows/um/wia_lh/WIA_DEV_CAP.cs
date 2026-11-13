// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='WIA_DEV_CAP.xml' path='doc/member[@name="WIA_DEV_CAP"]/*' />
public unsafe partial struct WIA_DEV_CAP
{
    /// <include file='WIA_DEV_CAP.xml' path='doc/member[@name="WIA_DEV_CAP.guid"]/*' />
    public Guid guid;

    /// <include file='WIA_DEV_CAP.xml' path='doc/member[@name="WIA_DEV_CAP.ulFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulFlags;

    /// <include file='WIA_DEV_CAP.xml' path='doc/member[@name="WIA_DEV_CAP.bstrName"]/*' />
    [NativeTypeName("BSTR")]
    public char* bstrName;

    /// <include file='WIA_DEV_CAP.xml' path='doc/member[@name="WIA_DEV_CAP.bstrDescription"]/*' />
    [NativeTypeName("BSTR")]
    public char* bstrDescription;

    /// <include file='WIA_DEV_CAP.xml' path='doc/member[@name="WIA_DEV_CAP.bstrIcon"]/*' />
    [NativeTypeName("BSTR")]
    public char* bstrIcon;

    /// <include file='WIA_DEV_CAP.xml' path='doc/member[@name="WIA_DEV_CAP.bstrCommandline"]/*' />
    [NativeTypeName("BSTR")]
    public char* bstrCommandline;
}
