// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1911C771-1587-413E-A7E0-FB26C3DE0268")]
    [NativeTypeName("struct ID3D11TracingDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11TracingDevice : ID3D11TracingDevice.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11TracingDevice*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11TracingDevice*, uint>)(lpVtbl[1]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11TracingDevice*, uint>)(lpVtbl[2]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetShaderTrackingOptionsByType(uint ResourceTypeFlags, uint Options)
        {
            return ((delegate* unmanaged<ID3D11TracingDevice*, uint, uint, int>)(lpVtbl[3]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), ResourceTypeFlags, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetShaderTrackingOptions(IUnknown* pShader, uint Options)
        {
            return ((delegate* unmanaged<ID3D11TracingDevice*, IUnknown*, uint, int>)(lpVtbl[4]))((ID3D11TracingDevice*)Unsafe.AsPointer(ref this), pShader, Options);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetShaderTrackingOptionsByType(uint ResourceTypeFlags, uint Options);

            [VtblIndex(4)]
            HRESULT SetShaderTrackingOptions(IUnknown* pShader, uint Options);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11TracingDevice*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11TracingDevice*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11TracingDevice*, uint> Release;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11TracingDevice*, uint, uint, int> SetShaderTrackingOptionsByType;

            [NativeTypeName("HRESULT (IUnknown *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11TracingDevice*, IUnknown*, uint, int> SetShaderTrackingOptions;
        }
    }
}
