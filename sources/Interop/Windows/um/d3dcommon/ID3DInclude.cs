// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe struct ID3DInclude
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Open(
            [In] ID3DInclude* This,
            [In] D3D_INCLUDE_TYPE IncludeType,
            [In, NativeTypeName("LPCSTR")] sbyte* pFileName,
            [In, NativeTypeName("LPCVOID")] void* pParentData,
            [Out, NativeTypeName("LPCVOID")] void** ppData,
            [Out, NativeTypeName("UINT")] uint* pBytes
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(
            [In] ID3DInclude* This,
            [In, NativeTypeName("LPCVOID")] void* pData
        );

        [return: NativeTypeName("HRESULT")]
        public int Open(
            [In] D3D_INCLUDE_TYPE IncludeType,
            [In, NativeTypeName("LPCSTR")] sbyte* pFileName,
            [In, NativeTypeName("LPCVOID")] void* pParentData,
            [Out, NativeTypeName("LPCVOID")] void** ppData,
            [Out, NativeTypeName("UINT")] uint* pBytes
        )
        {
            fixed (ID3DInclude* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Open>(lpVtbl->Open)(
                    This,
                    IncludeType,
                    pFileName,
                    pParentData,
                    ppData,
                    pBytes
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Close(
            [In, NativeTypeName("LPCVOID")] void* pData
        )
        {
            fixed (ID3DInclude* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)(
                    This,
                    pData
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr Open;

            public IntPtr Close;
        }
    }
}
