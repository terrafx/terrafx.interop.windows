// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000030-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ISynchronize : IUnknown")]
    public unsafe partial struct ISynchronize
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISynchronize*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronize*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISynchronize*, uint>)(lpVtbl[1]))((ISynchronize*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISynchronize*, uint>)(lpVtbl[2]))((ISynchronize*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Wait([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* stdcall<ISynchronize*, uint, uint, int>)(lpVtbl[3]))((ISynchronize*)Unsafe.AsPointer(ref this), dwFlags, dwMilliseconds);
        }

        [return: NativeTypeName("HRESULT")]
        public int Signal()
        {
            return ((delegate* stdcall<ISynchronize*, int>)(lpVtbl[4]))((ISynchronize*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<ISynchronize*, int>)(lpVtbl[5]))((ISynchronize*)Unsafe.AsPointer(ref this));
        }
    }
}
