// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IXAPO = typeof(IXAPO).GUID;

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IXAPOParameters = typeof(IXAPOParameters).GUID;
    }
}
