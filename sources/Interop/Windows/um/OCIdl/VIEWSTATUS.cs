// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum VIEWSTATUS
    {
        VIEWSTATUS_OPAQUE = 1,
        VIEWSTATUS_SOLIDBKGND = 2,
        VIEWSTATUS_DVASPECTOPAQUE = 4,
        VIEWSTATUS_DVASPECTTRANSPARENT = 8,
        VIEWSTATUS_SURFACE = 16,
        VIEWSTATUS_3DSURFACE = 32,
    }
}
