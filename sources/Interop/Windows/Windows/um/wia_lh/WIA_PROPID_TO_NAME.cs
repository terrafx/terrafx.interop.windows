// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WIA_PROPID_TO_NAME.xml' path='doc/member[@name="WIA_PROPID_TO_NAME"]/*' />
public unsafe partial struct WIA_PROPID_TO_NAME
{
    /// <include file='WIA_PROPID_TO_NAME.xml' path='doc/member[@name="WIA_PROPID_TO_NAME.propid"]/*' />
    [NativeTypeName("PROPID")]
    public uint propid;

    /// <include file='WIA_PROPID_TO_NAME.xml' path='doc/member[@name="WIA_PROPID_TO_NAME.pszName"]/*' />
    [NativeTypeName("LPOLESTR")]
    public char* pszName;
}
