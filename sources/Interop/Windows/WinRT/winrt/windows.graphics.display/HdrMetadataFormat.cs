// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HdrMetadataFormat.xml' path='doc/member[@name="HdrMetadataFormat"]/*' />
public enum HdrMetadataFormat
{
    /// <include file='HdrMetadataFormat.xml' path='doc/member[@name="HdrMetadataFormat.HdrMetadataFormat_Hdr10"]/*' />
    HdrMetadataFormat_Hdr10 = 0,

    /// <include file='HdrMetadataFormat.xml' path='doc/member[@name="HdrMetadataFormat.HdrMetadataFormat_Hdr10Plus"]/*' />
    HdrMetadataFormat_Hdr10Plus = 1,
}
