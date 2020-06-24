// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D0F462F-4064-4862-BC7F-933E5058C10F")]
    public unsafe partial struct IDxDiagContainer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxDiagContainer*, Guid*, void**, int>)(lpVtbl[0]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxDiagContainer*, uint>)(lpVtbl[1]))((IDxDiagContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxDiagContainer*, uint>)(lpVtbl[2]))((IDxDiagContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfChildContainers([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* stdcall<IDxDiagContainer*, uint*, int>)(lpVtbl[3]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumChildContainerNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwszContainer, [NativeTypeName("DWORD")] uint cchContainer)
        {
            return ((delegate* stdcall<IDxDiagContainer*, uint, ushort*, uint, int>)(lpVtbl[4]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), dwIndex, pwszContainer, cchContainer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChildContainer([NativeTypeName("LPCWSTR")] ushort* pwszContainer, [NativeTypeName("IDxDiagContainer **")] IDxDiagContainer** ppInstance)
        {
            return ((delegate* stdcall<IDxDiagContainer*, ushort*, IDxDiagContainer**, int>)(lpVtbl[5]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pwszContainer, ppInstance);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfProps([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* stdcall<IDxDiagContainer*, uint*, int>)(lpVtbl[6]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumPropNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwszPropName, [NativeTypeName("DWORD")] uint cchPropName)
        {
            return ((delegate* stdcall<IDxDiagContainer*, uint, ushort*, uint, int>)(lpVtbl[7]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), dwIndex, pwszPropName, cchPropName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropA([NativeTypeName("LPCWSTR")] ushort* pwszPropName, [NativeTypeName("VARIANT *")] VARIANT* pvarProp)
        {
            return ((delegate* stdcall<IDxDiagContainer*, ushort*, VARIANT*, int>)(lpVtbl[8]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pwszPropName, pvarProp);
        }
    }
}