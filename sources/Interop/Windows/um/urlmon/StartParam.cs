// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct StartParam
    {
        [NativeTypeName("IID")]
        public Guid iid;

        [NativeTypeName("IBindCtx *")]
        public IBindCtx* pIBindCtx;

        [NativeTypeName("IUnknown *")]
        public IUnknown* pItf;
    }
}
