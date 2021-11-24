// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum PlatformId
{
    PlatformX86 = 0,
    PlatformPowerPC = 1,
    PlatformMac = 2,
    PlatformEFI = 0xef,
}
