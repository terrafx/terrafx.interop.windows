// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WICHeifCompressionOption.xml' path='doc/member[@name="WICHeifCompressionOption"]/*' />
public enum WICHeifCompressionOption
{
    /// <include file='WICHeifCompressionOption.xml' path='doc/member[@name="WICHeifCompressionOption.WICHeifCompressionDontCare"]/*' />
    WICHeifCompressionDontCare = 0,

    /// <include file='WICHeifCompressionOption.xml' path='doc/member[@name="WICHeifCompressionOption.WICHeifCompressionNone"]/*' />
    WICHeifCompressionNone = 0x1,

    /// <include file='WICHeifCompressionOption.xml' path='doc/member[@name="WICHeifCompressionOption.WICHeifCompressionHEVC"]/*' />
    WICHeifCompressionHEVC = 0x2,

    /// <include file='WICHeifCompressionOption.xml' path='doc/member[@name="WICHeifCompressionOption.WICHeifCompressionAV1"]/*' />
    WICHeifCompressionAV1 = 0x3,

    /// <include file='WICHeifCompressionOption.xml' path='doc/member[@name="WICHeifCompressionOption.WICHEIFCOMPRESSIONOPTION_FORCE_DWORD"]/*' />
    WICHEIFCOMPRESSIONOPTION_FORCE_DWORD = 0x7fffffff,
}
