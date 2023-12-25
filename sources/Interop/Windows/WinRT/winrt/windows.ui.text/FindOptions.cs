// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FindOptions.xml' path='doc/member[@name="FindOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum FindOptions : uint
{
    /// <include file='FindOptions.xml' path='doc/member[@name="FindOptions.FindOptions_None"]/*' />
    FindOptions_None = 0,

    /// <include file='FindOptions.xml' path='doc/member[@name="FindOptions.FindOptions_Word"]/*' />
    FindOptions_Word = 0x2,

    /// <include file='FindOptions.xml' path='doc/member[@name="FindOptions.FindOptions_Case"]/*' />
    FindOptions_Case = 0x4,
}
