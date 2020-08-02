// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AC6B7889-0740-4D51-8619-905994A55CC6")]
    public unsafe partial struct IMFAsyncResult
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFAsyncResult*, Guid*, void**, int>)(lpVtbl[0]))((IMFAsyncResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFAsyncResult*, uint>)(lpVtbl[1]))((IMFAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFAsyncResult*, uint>)(lpVtbl[2]))((IMFAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("IUnknown **")] IUnknown** ppunkState)
        {
            return ((delegate* stdcall<IMFAsyncResult*, IUnknown**, int>)(lpVtbl[3]))((IMFAsyncResult*)Unsafe.AsPointer(ref this), ppunkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatus()
        {
            return ((delegate* stdcall<IMFAsyncResult*, int>)(lpVtbl[4]))((IMFAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStatus([NativeTypeName("HRESULT")] int hrStatus)
        {
            return ((delegate* stdcall<IMFAsyncResult*, int, int>)(lpVtbl[5]))((IMFAsyncResult*)Unsafe.AsPointer(ref this), hrStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObject([NativeTypeName("IUnknown **")] IUnknown** ppObject)
        {
            return ((delegate* stdcall<IMFAsyncResult*, IUnknown**, int>)(lpVtbl[6]))((IMFAsyncResult*)Unsafe.AsPointer(ref this), ppObject);
        }

        [return: NativeTypeName("IUnknown *")]
        public IUnknown* GetStateNoAddRef()
        {
            return ((delegate* stdcall<IMFAsyncResult*, IUnknown*>)(lpVtbl[7]))((IMFAsyncResult*)Unsafe.AsPointer(ref this));
        }
    }
}
