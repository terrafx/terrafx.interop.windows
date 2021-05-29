// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MULTI_QI
    {
        [NativeTypeName("const IID *")]
        public Guid* pIID;

        public IUnknown* pItf;

        [NativeTypeName("HRESULT")]
        public int hr;
    }
}
