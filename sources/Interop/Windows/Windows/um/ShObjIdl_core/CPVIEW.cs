// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum CPVIEW
{
    CPVIEW_CLASSIC = 0,
    CPVIEW_ALLITEMS = CPVIEW_CLASSIC,
    CPVIEW_CATEGORY = 1,
    CPVIEW_HOME = CPVIEW_CATEGORY,
}
