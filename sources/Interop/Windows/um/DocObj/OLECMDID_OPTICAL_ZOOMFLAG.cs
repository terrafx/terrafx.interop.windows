// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum OLECMDID_OPTICAL_ZOOMFLAG
    {
        OLECMDIDF_OPTICAL_ZOOM_NOPERSIST = 0x00000001,
        OLECMDIDF_OPTICAL_ZOOM_NOLAYOUT = 0x00000010,
        OLECMDIDF_OPTICAL_ZOOM_NOTRANSIENT = 0x00000020,
        OLECMDIDF_OPTICAL_ZOOM_RELOADFORNEWTAB = 0x00000040,
    }
}
