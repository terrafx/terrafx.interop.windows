// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum ERole
{
    eConsole = 0,
    eMultimedia = (eConsole + 1),
    eCommunications = (eMultimedia + 1),
    ERole_enum_count = (eCommunications + 1),
}
