// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionGetValueStatus.xml' path='doc/member[@name="CompositionGetValueStatus"]/*' />
public enum CompositionGetValueStatus
{
    /// <include file='CompositionGetValueStatus.xml' path='doc/member[@name="CompositionGetValueStatus.CompositionGetValueStatus_Succeeded"]/*' />
    CompositionGetValueStatus_Succeeded = 0,

    /// <include file='CompositionGetValueStatus.xml' path='doc/member[@name="CompositionGetValueStatus.CompositionGetValueStatus_TypeMismatch"]/*' />
    CompositionGetValueStatus_TypeMismatch = 1,

    /// <include file='CompositionGetValueStatus.xml' path='doc/member[@name="CompositionGetValueStatus.CompositionGetValueStatus_NotFound"]/*' />
    CompositionGetValueStatus_NotFound = 2,
}
