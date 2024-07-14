// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.directx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DirectXAlphaMode.xml' path='doc/member[@name="DirectXAlphaMode"]/*' />
public enum DirectXAlphaMode
{
    /// <include file='DirectXAlphaMode.xml' path='doc/member[@name="DirectXAlphaMode.DirectXAlphaMode_Unspecified"]/*' />
    DirectXAlphaMode_Unspecified = 0,

    /// <include file='DirectXAlphaMode.xml' path='doc/member[@name="DirectXAlphaMode.DirectXAlphaMode_Premultiplied"]/*' />
    DirectXAlphaMode_Premultiplied = 1,

    /// <include file='DirectXAlphaMode.xml' path='doc/member[@name="DirectXAlphaMode.DirectXAlphaMode_Straight"]/*' />
    DirectXAlphaMode_Straight = 2,

    /// <include file='DirectXAlphaMode.xml' path='doc/member[@name="DirectXAlphaMode.DirectXAlphaMode_Ignore"]/*' />
    DirectXAlphaMode_Ignore = 3,
}
