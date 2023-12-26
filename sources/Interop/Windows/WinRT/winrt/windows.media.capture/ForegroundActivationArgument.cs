// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ForegroundActivationArgument.xml' path='doc/member[@name="ForegroundActivationArgument"]/*' />
public enum ForegroundActivationArgument
{
    /// <include file='ForegroundActivationArgument.xml' path='doc/member[@name="ForegroundActivationArgument.ForegroundActivationArgument_SignInRequired"]/*' />
    ForegroundActivationArgument_SignInRequired = 0,

    /// <include file='ForegroundActivationArgument.xml' path='doc/member[@name="ForegroundActivationArgument.ForegroundActivationArgument_MoreSettings"]/*' />
    ForegroundActivationArgument_MoreSettings = 1,
}
