// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000145-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IForegroundTransfer : IUnknown")]
    public unsafe partial struct IForegroundTransfer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IForegroundTransfer*, Guid*, void**, int>)(lpVtbl[0]))((IForegroundTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IForegroundTransfer*, uint>)(lpVtbl[1]))((IForegroundTransfer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IForegroundTransfer*, uint>)(lpVtbl[2]))((IForegroundTransfer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AllowForegroundTransfer([NativeTypeName("void *")] void* lpvReserved)
        {
            return ((delegate* stdcall<IForegroundTransfer*, void*, int>)(lpVtbl[3]))((IForegroundTransfer*)Unsafe.AsPointer(ref this), lpvReserved);
        }
    }
}
