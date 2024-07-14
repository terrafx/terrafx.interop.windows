// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserPictureSize.xml' path='doc/member[@name="UserPictureSize"]/*' />
public enum UserPictureSize
{
    /// <include file='UserPictureSize.xml' path='doc/member[@name="UserPictureSize.UserPictureSize_Size64x64"]/*' />
    UserPictureSize_Size64x64 = 0,

    /// <include file='UserPictureSize.xml' path='doc/member[@name="UserPictureSize.UserPictureSize_Size208x208"]/*' />
    UserPictureSize_Size208x208 = 1,

    /// <include file='UserPictureSize.xml' path='doc/member[@name="UserPictureSize.UserPictureSize_Size424x424"]/*' />
    UserPictureSize_Size424x424 = 2,

    /// <include file='UserPictureSize.xml' path='doc/member[@name="UserPictureSize.UserPictureSize_Size1080x1080"]/*' />
    UserPictureSize_Size1080x1080 = 3,
}
