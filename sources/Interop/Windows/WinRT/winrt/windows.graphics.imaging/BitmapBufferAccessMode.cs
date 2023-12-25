// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BitmapBufferAccessMode.xml' path='doc/member[@name="BitmapBufferAccessMode"]/*' />
public enum BitmapBufferAccessMode
{
    /// <include file='BitmapBufferAccessMode.xml' path='doc/member[@name="BitmapBufferAccessMode.BitmapBufferAccessMode_Read"]/*' />
    BitmapBufferAccessMode_Read = 0,

    /// <include file='BitmapBufferAccessMode.xml' path='doc/member[@name="BitmapBufferAccessMode.BitmapBufferAccessMode_ReadWrite"]/*' />
    BitmapBufferAccessMode_ReadWrite = 1,

    /// <include file='BitmapBufferAccessMode.xml' path='doc/member[@name="BitmapBufferAccessMode.BitmapBufferAccessMode_Write"]/*' />
    BitmapBufferAccessMode_Write = 2,
}
