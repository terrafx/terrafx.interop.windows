// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum INSTALLMODE
{
    INSTALLMODE_NODETECTION_ANY = -4,
    INSTALLMODE_NOSOURCERESOLUTION = -3,
    INSTALLMODE_NODETECTION = -2,
    INSTALLMODE_EXISTING = -1,
    INSTALLMODE_DEFAULT = 0,
}
