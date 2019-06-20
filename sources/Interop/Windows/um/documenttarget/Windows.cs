// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\documenttarget.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        #region IID_* Constants
        public static readonly Guid IID_IPrintDocumentPackageTarget = new Guid(0x1B8EFEC4, 0x3019, 0x4C27, 0x96, 0x4E, 0x36, 0x72, 0x02, 0x15, 0x69, 0x06);
        #endregion
    }
}
