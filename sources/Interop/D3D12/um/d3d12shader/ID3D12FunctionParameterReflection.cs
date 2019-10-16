// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC25F42D-7006-4F2B-B33E-02CC3375733F")]
    public unsafe partial struct ID3D12FunctionParameterReflection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesc(ID3D12FunctionParameterReflection* pThis, [NativeTypeName("D3D12_PARAMETER_DESC *")] D3D12_PARAMETER_DESC* pDesc);

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_PARAMETER_DESC *")] D3D12_PARAMETER_DESC* pDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)((ID3D12FunctionParameterReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D12_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDesc;
        }
    }
}
