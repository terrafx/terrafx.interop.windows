// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000032-0000-0000-C000-000000000046")]
    public unsafe partial struct ISynchronizeEvent
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISynchronizeEvent*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISynchronizeEvent*, uint>)(lpVtbl[1]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISynchronizeEvent*, uint>)(lpVtbl[2]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHandle([NativeTypeName("HANDLE *")] IntPtr* ph)
        {
            return ((delegate* stdcall<ISynchronizeEvent*, IntPtr*, int>)(lpVtbl[3]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this), ph);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventHandle([NativeTypeName("HANDLE *")] IntPtr* ph)
        {
            return ((delegate* stdcall<ISynchronizeEvent*, IntPtr*, int>)(lpVtbl[4]))((ISynchronizeEvent*)Unsafe.AsPointer(ref this), ph);
        }
    }
}
