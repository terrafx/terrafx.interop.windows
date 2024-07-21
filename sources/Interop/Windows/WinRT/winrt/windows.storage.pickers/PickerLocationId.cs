// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId"]/*' />
public enum PickerLocationId
{
    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_DocumentsLibrary"]/*' />
    PickerLocationId_DocumentsLibrary = 0,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_ComputerFolder"]/*' />
    PickerLocationId_ComputerFolder = 1,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_Desktop"]/*' />
    PickerLocationId_Desktop = 2,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_Downloads"]/*' />
    PickerLocationId_Downloads = 3,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_HomeGroup"]/*' />
    PickerLocationId_HomeGroup = 4,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_MusicLibrary"]/*' />
    PickerLocationId_MusicLibrary = 5,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_PicturesLibrary"]/*' />
    PickerLocationId_PicturesLibrary = 6,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_VideosLibrary"]/*' />
    PickerLocationId_VideosLibrary = 7,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_Objects3D"]/*' />
    PickerLocationId_Objects3D = 8,

    /// <include file='PickerLocationId.xml' path='doc/member[@name="PickerLocationId.PickerLocationId_Unspecified"]/*' />
    PickerLocationId_Unspecified = 9,
}
