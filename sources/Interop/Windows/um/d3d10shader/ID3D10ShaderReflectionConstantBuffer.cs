// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("66C66A94-DDDD-4B62-A66A-F0DA33C2B4D0")]
    public unsafe partial struct ID3D10ShaderReflectionConstantBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D10_SHADER_BUFFER_DESC *")] D3D10_SHADER_BUFFER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*, D3D10_SHADER_BUFFER_DESC*, int>)(lpVtbl[0]))((ID3D10ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D10ShaderReflectionVariable *")]
        public ID3D10ShaderReflectionVariable* GetVariableByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*, uint, ID3D10ShaderReflectionVariable*>)(lpVtbl[1]))((ID3D10ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D10ShaderReflectionVariable *")]
        public ID3D10ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*, sbyte*, ID3D10ShaderReflectionVariable*>)(lpVtbl[2]))((ID3D10ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
        }
    }
}
