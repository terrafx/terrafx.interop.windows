// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum OLECMDID_BROWSERSTATEFLAG
    {
        OLECMDIDF_BROWSERSTATE_EXTENSIONSOFF = 0x00000001,
        OLECMDIDF_BROWSERSTATE_IESECURITY = 0x00000002,
        OLECMDIDF_BROWSERSTATE_PROTECTEDMODE_OFF = 0x00000004,
        OLECMDIDF_BROWSERSTATE_RESET = 0x00000008,
        OLECMDIDF_BROWSERSTATE_REQUIRESACTIVEX = 0x00000010,
        OLECMDIDF_BROWSERSTATE_DESKTOPHTMLDIALOG = 0x00000020,
        OLECMDIDF_BROWSERSTATE_BLOCKEDVERSION = 0x00000040,
    }
}
