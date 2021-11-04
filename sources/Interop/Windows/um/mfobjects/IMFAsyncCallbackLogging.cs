// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C7A4DCA1-F5F0-47B6-B92B-BF0106D25791")]
    [NativeTypeName("struct IMFAsyncCallbackLogging : IMFAsyncCallback")]
    [NativeInheritance("IMFAsyncCallback")]
    public unsafe partial struct IMFAsyncCallbackLogging
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFAsyncCallbackLogging*, Guid*, void**, int>)(lpVtbl[0]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFAsyncCallbackLogging*, uint>)(lpVtbl[1]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFAsyncCallbackLogging*, uint>)(lpVtbl[2]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetParameters([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwQueue)
        {
            return ((delegate* unmanaged<IMFAsyncCallbackLogging*, uint*, uint*, int>)(lpVtbl[3]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), pdwFlags, pdwQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Invoke(IMFAsyncResult* pAsyncResult)
        {
            return ((delegate* unmanaged<IMFAsyncCallbackLogging*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), pAsyncResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void* GetObjectPointer()
        {
            return ((delegate* unmanaged<IMFAsyncCallbackLogging*, void*>)(lpVtbl[5]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("DWORD")]
        public uint GetObjectTag()
        {
            return ((delegate* unmanaged<IMFAsyncCallbackLogging*, uint>)(lpVtbl[6]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncCallbackLogging*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncCallbackLogging*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncCallbackLogging*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncCallbackLogging*, uint*, uint*, int> GetParameters;

            [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncCallbackLogging*, IMFAsyncResult*, int> Invoke;

            [NativeTypeName("void *() __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncCallbackLogging*, void*> GetObjectPointer;

            [NativeTypeName("DWORD () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncCallbackLogging*, uint> GetObjectTag;
        }
    }
}
