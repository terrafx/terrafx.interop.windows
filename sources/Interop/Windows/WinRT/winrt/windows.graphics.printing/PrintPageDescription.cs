// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PrintPageDescription.xml' path='doc/member[@name="PrintPageDescription"]/*' />
public partial struct PrintPageDescription
{
    /// <include file='PrintPageDescription.xml' path='doc/member[@name="PrintPageDescription.PageSize"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Size")]
    public Size PageSize;

    /// <include file='PrintPageDescription.xml' path='doc/member[@name="PrintPageDescription.ImageableRect"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Rect")]
    public Rect ImageableRect;

    /// <include file='PrintPageDescription.xml' path='doc/member[@name="PrintPageDescription.DpiX"]/*' />
    [NativeTypeName("UINT32")]
    public uint DpiX;

    /// <include file='PrintPageDescription.xml' path='doc/member[@name="PrintPageDescription.DpiY"]/*' />
    [NativeTypeName("UINT32")]
    public uint DpiY;
}
