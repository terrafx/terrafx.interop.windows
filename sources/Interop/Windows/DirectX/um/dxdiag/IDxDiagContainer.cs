// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [NativeTypeName("struct IDxDiagContainer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDxDiagContainer : IDxDiagContainer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, Guid*, void**, int>)(lpVtbl[0]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint>)(lpVtbl[1]))((IDxDiagContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint>)(lpVtbl[2]))((IDxDiagContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetNumberOfChildContainers([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint*, int>)(lpVtbl[3]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EnumChildContainerNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwszContainer, [NativeTypeName("DWORD")] uint cchContainer)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint, ushort*, uint, int>)(lpVtbl[4]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), dwIndex, pwszContainer, cchContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetChildContainer([NativeTypeName("LPCWSTR")] ushort* pwszContainer, IDxDiagContainer** ppInstance)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, ushort*, IDxDiagContainer**, int>)(lpVtbl[5]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pwszContainer, ppInstance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetNumberOfProps([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint*, int>)(lpVtbl[6]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EnumPropNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwszPropName, [NativeTypeName("DWORD")] uint cchPropName)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, uint, ushort*, uint, int>)(lpVtbl[7]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), dwIndex, pwszPropName, cchPropName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetProp([NativeTypeName("LPCWSTR")] ushort* pwszPropName, VARIANT* pvarProp)
        {
            return ((delegate* unmanaged<IDxDiagContainer*, ushort*, VARIANT*, int>)(lpVtbl[8]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pwszPropName, pvarProp);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetNumberOfChildContainers([NativeTypeName("DWORD *")] uint* pdwCount);

            [VtblIndex(4)]
            HRESULT EnumChildContainerNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwszContainer, [NativeTypeName("DWORD")] uint cchContainer);

            [VtblIndex(5)]
            HRESULT GetChildContainer([NativeTypeName("LPCWSTR")] ushort* pwszContainer, IDxDiagContainer** ppInstance);

            [VtblIndex(6)]
            HRESULT GetNumberOfProps([NativeTypeName("DWORD *")] uint* pdwCount);

            [VtblIndex(7)]
            HRESULT EnumPropNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwszPropName, [NativeTypeName("DWORD")] uint cchPropName);

            [VtblIndex(8)]
            HRESULT GetProp([NativeTypeName("LPCWSTR")] ushort* pwszPropName, VARIANT* pvarProp);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, uint*, int> GetNumberOfChildContainers;

            [NativeTypeName("HRESULT (DWORD, LPWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, uint, ushort*, uint, int> EnumChildContainerNames;

            [NativeTypeName("HRESULT (LPCWSTR, IDxDiagContainer **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, ushort*, IDxDiagContainer**, int> GetChildContainer;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, uint*, int> GetNumberOfProps;

            [NativeTypeName("HRESULT (DWORD, LPWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, uint, ushort*, uint, int> EnumPropNames;

            [NativeTypeName("HRESULT (LPCWSTR, VARIANT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxDiagContainer*, ushort*, VARIANT*, int> GetProp;
        }
    }
}
