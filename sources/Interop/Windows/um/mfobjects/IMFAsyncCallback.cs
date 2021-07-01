// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A27003CF-2354-4F2A-8D6A-AB7CFF15437E")]
    [NativeTypeName("struct IMFAsyncCallback : IUnknown")]
    public unsafe partial struct IMFAsyncCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFAsyncCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFAsyncCallback*, uint>)(lpVtbl[1]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFAsyncCallback*, uint>)(lpVtbl[2]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParameters([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwQueue)
        {
            return ((delegate* unmanaged<IMFAsyncCallback*, uint*, uint*, int>)(lpVtbl[3]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), pdwFlags, pdwQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke(IMFAsyncResult* pAsyncResult)
        {
            return ((delegate* unmanaged<IMFAsyncCallback*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), pAsyncResult);
        }
    }
}
