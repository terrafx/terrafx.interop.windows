// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D666063F-1587-4E43-81F1-B948E807363F")]
    [NativeTypeName("struct IMMDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMMDevice : IMMDevice.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMMDevice*, Guid*, void**, int>)(lpVtbl[0]))((IMMDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMMDevice*, uint>)(lpVtbl[1]))((IMMDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMMDevice*, uint>)(lpVtbl[2]))((IMMDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Activate([NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("DWORD")] uint dwClsCtx, PROPVARIANT* pActivationParams, void** ppInterface)
        {
            return ((delegate* unmanaged<IMMDevice*, Guid*, uint, PROPVARIANT*, void**, int>)(lpVtbl[3]))((IMMDevice*)Unsafe.AsPointer(ref this), iid, dwClsCtx, pActivationParams, ppInterface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OpenPropertyStore([NativeTypeName("DWORD")] uint stgmAccess, IPropertyStore** ppProperties)
        {
            return ((delegate* unmanaged<IMMDevice*, uint, IPropertyStore**, int>)(lpVtbl[4]))((IMMDevice*)Unsafe.AsPointer(ref this), stgmAccess, ppProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppstrId)
        {
            return ((delegate* unmanaged<IMMDevice*, ushort**, int>)(lpVtbl[5]))((IMMDevice*)Unsafe.AsPointer(ref this), ppstrId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return ((delegate* unmanaged<IMMDevice*, uint*, int>)(lpVtbl[6]))((IMMDevice*)Unsafe.AsPointer(ref this), pdwState);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Activate([NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("DWORD")] uint dwClsCtx, PROPVARIANT* pActivationParams, void** ppInterface);

            [VtblIndex(4)]
            HRESULT OpenPropertyStore([NativeTypeName("DWORD")] uint stgmAccess, IPropertyStore** ppProperties);

            [VtblIndex(5)]
            HRESULT GetId([NativeTypeName("LPWSTR *")] ushort** ppstrId);

            [VtblIndex(6)]
            HRESULT GetState([NativeTypeName("DWORD *")] uint* pdwState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDevice*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDevice*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDevice*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, DWORD, PROPVARIANT *, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDevice*, Guid*, uint, PROPVARIANT*, void**, int> Activate;

            [NativeTypeName("HRESULT (DWORD, IPropertyStore **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDevice*, uint, IPropertyStore**, int> OpenPropertyStore;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDevice*, ushort**, int> GetId;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMMDevice*, uint*, int> GetState;
        }
    }
}
