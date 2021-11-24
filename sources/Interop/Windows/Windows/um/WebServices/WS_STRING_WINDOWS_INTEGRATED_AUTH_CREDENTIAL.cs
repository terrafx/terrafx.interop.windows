// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL
{
    public WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL credential;

    public WS_STRING username;

    public WS_STRING password;

    public WS_STRING domain;
}
