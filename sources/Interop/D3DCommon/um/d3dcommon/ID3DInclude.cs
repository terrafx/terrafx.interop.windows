// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3DInclude
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Open(ID3DInclude* pThis, D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, [NativeTypeName("UINT *")] uint* pBytes);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(ID3DInclude* pThis, [NativeTypeName("LPCVOID")] void* pData);

        [return: NativeTypeName("HRESULT")]
        public int Open(D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, [NativeTypeName("UINT *")] uint* pBytes)
        {
            return Marshal.GetDelegateForFunctionPointer<_Open>(lpVtbl->Open)((ID3DInclude*)Unsafe.AsPointer(ref this), IncludeType, pFileName, pParentData, ppData, pBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("LPCVOID")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)((ID3DInclude*)Unsafe.AsPointer(ref this), pData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D_INCLUDE_TYPE, LPCSTR, LPCVOID, LPCVOID *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Open;

            [NativeTypeName("HRESULT (LPCVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Close;
        }
    }
}
