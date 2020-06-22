// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A27003CF-2354-4F2A-8D6A-AB7CFF15437E")]
    public unsafe partial struct IMFAsyncCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFAsyncCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFAsyncCallback*, uint>)(lpVtbl[1]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFAsyncCallback*, uint>)(lpVtbl[2]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwQueue)
        {
            return ((delegate* stdcall<IMFAsyncCallback*, uint*, uint*, int>)(lpVtbl[3]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), pdwFlags, pdwQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pAsyncResult)
        {
            return ((delegate* stdcall<IMFAsyncCallback*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), pAsyncResult);
        }
    }
}
