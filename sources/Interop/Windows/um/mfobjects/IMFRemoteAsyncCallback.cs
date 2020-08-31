// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A27003D0-2354-4F2A-8D6A-AB7CFF15437E")]
    [NativeTypeName("struct IMFRemoteAsyncCallback : IUnknown")]
    public unsafe partial struct IMFRemoteAsyncCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFRemoteAsyncCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFRemoteAsyncCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFRemoteAsyncCallback*, uint>)(lpVtbl[1]))((IMFRemoteAsyncCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFRemoteAsyncCallback*, uint>)(lpVtbl[2]))((IMFRemoteAsyncCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("HRESULT")] int hr, [NativeTypeName("IUnknown *")] IUnknown* pRemoteResult)
        {
            return ((delegate* stdcall<IMFRemoteAsyncCallback*, int, IUnknown*, int>)(lpVtbl[3]))((IMFRemoteAsyncCallback*)Unsafe.AsPointer(ref this), hr, pRemoteResult);
        }
    }
}
