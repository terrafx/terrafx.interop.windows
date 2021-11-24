// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum WS_SECURITY_TIMESTAMP_USAGE
{
    WS_SECURITY_TIMESTAMP_USAGE_ALWAYS = 1,
    WS_SECURITY_TIMESTAMP_USAGE_NEVER = 2,
    WS_SECURITY_TIMESTAMP_USAGE_REQUESTS_ONLY = 3,
}
