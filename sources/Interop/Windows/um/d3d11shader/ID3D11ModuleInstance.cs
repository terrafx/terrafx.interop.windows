// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("469E07F7-045A-48D5-AA12-68A478CDF75D")]
    public unsafe partial struct ID3D11ModuleInstance
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BindConstantBuffer([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint cbDstOffset)
        {
            return lpVtbl->BindConstantBuffer((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, cbDstOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint cbDstOffset)
        {
            return lpVtbl->BindConstantBufferByName((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, cbDstOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindResource([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return lpVtbl->BindResource((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindResourceByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return lpVtbl->BindResourceByName((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindSampler([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return lpVtbl->BindSampler((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindSamplerByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return lpVtbl->BindSamplerByName((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindUnorderedAccessView([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return lpVtbl->BindUnorderedAccessView((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return lpVtbl->BindUnorderedAccessViewByName((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindResourceAsUnorderedAccessView([NativeTypeName("UINT")] uint uSrcSrvSlot, [NativeTypeName("UINT")] uint uDstUavSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return lpVtbl->BindResourceAsUnorderedAccessView((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSrvSlot, uDstUavSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindResourceAsUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pSrvName, [NativeTypeName("UINT")] uint uDstUavSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return lpVtbl->BindResourceAsUnorderedAccessViewByName((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pSrvName, uDstUavSlot, uCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, uint> Release;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, uint, uint, uint, int> BindConstantBuffer;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, sbyte*, uint, uint, int> BindConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, uint, uint, uint, int> BindResource;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, sbyte*, uint, uint, int> BindResourceByName;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, uint, uint, uint, int> BindSampler;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, sbyte*, uint, uint, int> BindSamplerByName;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, uint, uint, uint, int> BindUnorderedAccessView;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, sbyte*, uint, uint, int> BindUnorderedAccessViewByName;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, uint, uint, uint, int> BindResourceAsUnorderedAccessView;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11ModuleInstance*, sbyte*, uint, uint, int> BindResourceAsUnorderedAccessViewByName;
        }
    }
}
