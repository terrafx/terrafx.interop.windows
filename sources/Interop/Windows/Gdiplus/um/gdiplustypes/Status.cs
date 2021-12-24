// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='Status.xml' path='doc/member[@name="Status"]/*' />
public enum Status
{
    /// <include file='Status.xml' path='doc/member[@name="Status.Ok"]/*' />
    Ok = 0,

    /// <include file='Status.xml' path='doc/member[@name="Status.GenericError"]/*' />
    GenericError = 1,

    /// <include file='Status.xml' path='doc/member[@name="Status.InvalidParameter"]/*' />
    InvalidParameter = 2,

    /// <include file='Status.xml' path='doc/member[@name="Status.OutOfMemory"]/*' />
    OutOfMemory = 3,

    /// <include file='Status.xml' path='doc/member[@name="Status.ObjectBusy"]/*' />
    ObjectBusy = 4,

    /// <include file='Status.xml' path='doc/member[@name="Status.InsufficientBuffer"]/*' />
    InsufficientBuffer = 5,

    /// <include file='Status.xml' path='doc/member[@name="Status.NotImplemented"]/*' />
    NotImplemented = 6,

    /// <include file='Status.xml' path='doc/member[@name="Status.Win32Error"]/*' />
    Win32Error = 7,

    /// <include file='Status.xml' path='doc/member[@name="Status.WrongState"]/*' />
    WrongState = 8,

    /// <include file='Status.xml' path='doc/member[@name="Status.Aborted"]/*' />
    Aborted = 9,

    /// <include file='Status.xml' path='doc/member[@name="Status.FileNotFound"]/*' />
    FileNotFound = 10,

    /// <include file='Status.xml' path='doc/member[@name="Status.ValueOverflow"]/*' />
    ValueOverflow = 11,

    /// <include file='Status.xml' path='doc/member[@name="Status.AccessDenied"]/*' />
    AccessDenied = 12,

    /// <include file='Status.xml' path='doc/member[@name="Status.UnknownImageFormat"]/*' />
    UnknownImageFormat = 13,

    /// <include file='Status.xml' path='doc/member[@name="Status.FontFamilyNotFound"]/*' />
    FontFamilyNotFound = 14,

    /// <include file='Status.xml' path='doc/member[@name="Status.FontStyleNotFound"]/*' />
    FontStyleNotFound = 15,

    /// <include file='Status.xml' path='doc/member[@name="Status.NotTrueTypeFont"]/*' />
    NotTrueTypeFont = 16,

    /// <include file='Status.xml' path='doc/member[@name="Status.UnsupportedGdiplusVersion"]/*' />
    UnsupportedGdiplusVersion = 17,

    /// <include file='Status.xml' path='doc/member[@name="Status.GdiplusNotInitialized"]/*' />
    GdiplusNotInitialized = 18,

    /// <include file='Status.xml' path='doc/member[@name="Status.PropertyNotFound"]/*' />
    PropertyNotFound = 19,

    /// <include file='Status.xml' path='doc/member[@name="Status.PropertyNotSupported"]/*' />
    PropertyNotSupported = 20,

    /// <include file='Status.xml' path='doc/member[@name="Status.ProfileNotFound"]/*' />
    ProfileNotFound = 21,
}
