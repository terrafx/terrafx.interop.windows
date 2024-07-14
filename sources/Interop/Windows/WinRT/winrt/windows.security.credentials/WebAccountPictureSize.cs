// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='WebAccountPictureSize.xml' path='doc/member[@name="WebAccountPictureSize"]/*' />
public enum WebAccountPictureSize
{
    /// <include file='WebAccountPictureSize.xml' path='doc/member[@name="WebAccountPictureSize.WebAccountPictureSize_Size64x64"]/*' />
    WebAccountPictureSize_Size64x64 = 64,

    /// <include file='WebAccountPictureSize.xml' path='doc/member[@name="WebAccountPictureSize.WebAccountPictureSize_Size208x208"]/*' />
    WebAccountPictureSize_Size208x208 = 208,

    /// <include file='WebAccountPictureSize.xml' path='doc/member[@name="WebAccountPictureSize.WebAccountPictureSize_Size424x424"]/*' />
    WebAccountPictureSize_Size424x424 = 424,

    /// <include file='WebAccountPictureSize.xml' path='doc/member[@name="WebAccountPictureSize.WebAccountPictureSize_Size1080x1080"]/*' />
    WebAccountPictureSize_Size1080x1080 = 1080,
}
