// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GID
{
    /// <include file='GID.xml' path='doc/member[@name="GID.GID_BEGIN"]/*' />
    [NativeTypeName("#define GID_BEGIN 1")]
    public const int GID_BEGIN = 1;

    /// <include file='GID.xml' path='doc/member[@name="GID.GID_END"]/*' />
    [NativeTypeName("#define GID_END 2")]
    public const int GID_END = 2;

    /// <include file='GID.xml' path='doc/member[@name="GID.GID_ZOOM"]/*' />
    [NativeTypeName("#define GID_ZOOM 3")]
    public const int GID_ZOOM = 3;

    /// <include file='GID.xml' path='doc/member[@name="GID.GID_PAN"]/*' />
    [NativeTypeName("#define GID_PAN 4")]
    public const int GID_PAN = 4;

    /// <include file='GID.xml' path='doc/member[@name="GID.GID_ROTATE"]/*' />
    [NativeTypeName("#define GID_ROTATE 5")]
    public const int GID_ROTATE = 5;

    /// <include file='GID.xml' path='doc/member[@name="GID.GID_TWOFINGERTAP"]/*' />
    [NativeTypeName("#define GID_TWOFINGERTAP 6")]
    public const int GID_TWOFINGERTAP = 6;

    /// <include file='GID.xml' path='doc/member[@name="GID.GID_PRESSANDTAP"]/*' />
    [NativeTypeName("#define GID_PRESSANDTAP 7")]
    public const int GID_PRESSANDTAP = 7;

    /// <include file='GID.xml' path='doc/member[@name="GID.GID_ROLLOVER"]/*' />
    [NativeTypeName("#define GID_ROLLOVER GID_PRESSANDTAP")]
    public const int GID_ROLLOVER = 7;
}
