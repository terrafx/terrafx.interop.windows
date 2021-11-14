// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [NativeTypeName("struct IDxDiagProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDxDiagProvider : IDxDiagProvider.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxDiagProvider*, Guid*, void**, int>)(lpVtbl[0]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxDiagProvider*, uint>)(lpVtbl[1]))((IDxDiagProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxDiagProvider*, uint>)(lpVtbl[2]))((IDxDiagProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize(DXDIAG_INIT_PARAMS* pParams)
        {
            return ((delegate* unmanaged<IDxDiagProvider*, DXDIAG_INIT_PARAMS*, int>)(lpVtbl[3]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), pParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRootContainer(IDxDiagContainer** ppInstance)
        {
            return ((delegate* unmanaged<IDxDiagProvider*, IDxDiagContainer**, int>)(lpVtbl[4]))((IDxDiagProvider*)Unsafe.AsPointer(ref this), ppInstance);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Initialize(DXDIAG_INIT_PARAMS* pParams);

            [VtblIndex(4)]
            HRESULT GetRootContainer(IDxDiagContainer** ppInstance);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagProvider*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagProvider*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagProvider*, uint> Release;

            [NativeTypeName("HRESULT (DXDIAG_INIT_PARAMS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagProvider*, DXDIAG_INIT_PARAMS*, int> Initialize;

            [NativeTypeName("HRESULT (IDxDiagContainer **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagProvider*, IDxDiagContainer**, int> GetRootContainer;
        }
    }
}
