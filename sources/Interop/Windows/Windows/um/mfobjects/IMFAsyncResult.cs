// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("AC6B7889-0740-4D51-8619-905994A55CC6")]
    [NativeTypeName("struct IMFAsyncResult : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFAsyncResult : IMFAsyncResult.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFAsyncResult*, Guid*, void**, int>)(lpVtbl[0]))((IMFAsyncResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFAsyncResult*, uint>)(lpVtbl[1]))((IMFAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFAsyncResult*, uint>)(lpVtbl[2]))((IMFAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetState(IUnknown** ppunkState)
        {
            return ((delegate* unmanaged<IMFAsyncResult*, IUnknown**, int>)(lpVtbl[3]))((IMFAsyncResult*)Unsafe.AsPointer(ref this), ppunkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetStatus()
        {
            return ((delegate* unmanaged<IMFAsyncResult*, int>)(lpVtbl[4]))((IMFAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetStatus(HRESULT hrStatus)
        {
            return ((delegate* unmanaged<IMFAsyncResult*, HRESULT, int>)(lpVtbl[5]))((IMFAsyncResult*)Unsafe.AsPointer(ref this), hrStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetObject(IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFAsyncResult*, IUnknown**, int>)(lpVtbl[6]))((IMFAsyncResult*)Unsafe.AsPointer(ref this), ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public IUnknown* GetStateNoAddRef()
        {
            return ((delegate* unmanaged<IMFAsyncResult*, IUnknown*>)(lpVtbl[7]))((IMFAsyncResult*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetState(IUnknown** ppunkState);

            [VtblIndex(4)]
            HRESULT GetStatus();

            [VtblIndex(5)]
            HRESULT SetStatus(HRESULT hrStatus);

            [VtblIndex(6)]
            HRESULT GetObject(IUnknown** ppObject);

            [VtblIndex(7)]
            IUnknown* GetStateNoAddRef();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncResult*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncResult*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncResult*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncResult*, IUnknown**, int> GetState;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncResult*, int> GetStatus;

            [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncResult*, HRESULT, int> SetStatus;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncResult*, IUnknown**, int> GetObject;

            [NativeTypeName("IUnknown *() __attribute__((stdcall))")]
            public delegate* unmanaged<IMFAsyncResult*, IUnknown*> GetStateNoAddRef;
        }
    }
}
