// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum POWER_USER_PRESENCE_TYPE
{
    UserNotPresent = 0,
    UserPresent = 1,
    UserUnknown = 0xff,
}
