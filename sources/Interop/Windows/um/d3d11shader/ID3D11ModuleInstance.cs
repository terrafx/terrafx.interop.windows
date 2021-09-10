// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("469E07F7-045A-48D5-AA12-68A478CDF75D")]
    [NativeTypeName("struct ID3D11ModuleInstance : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11ModuleInstance
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint>)(lpVtbl[1]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint>)(lpVtbl[2]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int BindConstantBuffer([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint cbDstOffset)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[3]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, cbDstOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int BindConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint cbDstOffset)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[4]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, cbDstOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int BindResource([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[5]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int BindResourceByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[6]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int BindSampler([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[7]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int BindSamplerByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[8]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int BindUnorderedAccessView([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[9]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int BindUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[10]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int BindResourceAsUnorderedAccessView([NativeTypeName("UINT")] uint uSrcSrvSlot, [NativeTypeName("UINT")] uint uDstUavSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[11]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSrvSlot, uDstUavSlot, uCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int BindResourceAsUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pSrvName, [NativeTypeName("UINT")] uint uDstUavSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return ((delegate* unmanaged<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[12]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pSrvName, uDstUavSlot, uCount);
        }
    }
}
