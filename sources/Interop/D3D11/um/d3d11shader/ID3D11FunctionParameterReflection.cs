// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("42757488-334F-47FE-982E-1A65D08CC462")]
    public unsafe partial struct ID3D11FunctionParameterReflection
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D11FunctionParameterReflection* pThis, [NativeTypeName("D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pDesc);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D11FunctionParameterReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D11_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;
        }
    }
}
