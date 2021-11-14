// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    [Flags]
    public enum EXTCONN
    {
        EXTCONN_STRONG = 0x1,
        EXTCONN_WEAK = 0x2,
        EXTCONN_CALLABLE = 0x4,
    }
}
