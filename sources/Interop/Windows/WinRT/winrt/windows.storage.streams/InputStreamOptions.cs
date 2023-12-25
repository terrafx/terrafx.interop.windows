// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='InputStreamOptions.xml' path='doc/member[@name="InputStreamOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum InputStreamOptions : uint
{
    /// <include file='InputStreamOptions.xml' path='doc/member[@name="InputStreamOptions.InputStreamOptions_None"]/*' />
    InputStreamOptions_None = 0,

    /// <include file='InputStreamOptions.xml' path='doc/member[@name="InputStreamOptions.InputStreamOptions_Partial"]/*' />
    InputStreamOptions_Partial = 0x1,

    /// <include file='InputStreamOptions.xml' path='doc/member[@name="InputStreamOptions.InputStreamOptions_ReadAhead"]/*' />
    InputStreamOptions_ReadAhead = 0x2,
}
