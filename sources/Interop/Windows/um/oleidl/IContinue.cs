// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000012A-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IContinue : IUnknown")]
    public unsafe partial struct IContinue
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IContinue*, Guid*, void**, int>)(lpVtbl[0]))((IContinue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IContinue*, uint>)(lpVtbl[1]))((IContinue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IContinue*, uint>)(lpVtbl[2]))((IContinue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FContinue()
        {
            return ((delegate* stdcall<IContinue*, int>)(lpVtbl[3]))((IContinue*)Unsafe.AsPointer(ref this));
        }
    }
}
