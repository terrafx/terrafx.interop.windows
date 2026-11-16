// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STI_ERROR_INFOW.xml' path='doc/member[@name="STI_ERROR_INFOW"]/*' />
public partial struct STI_ERROR_INFOW
{
    /// <include file='STI_ERROR_INFOW.xml' path='doc/member[@name="STI_ERROR_INFOW.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='STI_ERROR_INFOW.xml' path='doc/member[@name="STI_ERROR_INFOW.dwGenericError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGenericError;

    /// <include file='STI_ERROR_INFOW.xml' path='doc/member[@name="STI_ERROR_INFOW.dwVendorError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVendorError;

    /// <include file='STI_ERROR_INFOW.xml' path='doc/member[@name="STI_ERROR_INFOW.szExtendedErrorText"]/*' />
    [NativeTypeName("WCHAR[255]")]
    public _szExtendedErrorText_e__FixedBuffer szExtendedErrorText;

    /// <include file='_szExtendedErrorText_e__FixedBuffer.xml' path='doc/member[@name="_szExtendedErrorText_e__FixedBuffer"]/*' />
    [InlineArray(255)]
    public partial struct _szExtendedErrorText_e__FixedBuffer
    {
        public char e0;
    }
}
