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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11ModuleInstance* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11ModuleInstance* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11ModuleInstance* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindConstantBuffer(ID3D11ModuleInstance* pThis, [NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint cbDstOffset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindConstantBufferByName(ID3D11ModuleInstance* pThis, [NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint cbDstOffset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindResource(ID3D11ModuleInstance* pThis, [NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindResourceByName(ID3D11ModuleInstance* pThis, [NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindSampler(ID3D11ModuleInstance* pThis, [NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindSamplerByName(ID3D11ModuleInstance* pThis, [NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindUnorderedAccessView(ID3D11ModuleInstance* pThis, [NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindUnorderedAccessViewByName(ID3D11ModuleInstance* pThis, [NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindResourceAsUnorderedAccessView(ID3D11ModuleInstance* pThis, [NativeTypeName("UINT")] uint uSrcSrvSlot, [NativeTypeName("UINT")] uint uDstUavSlot, [NativeTypeName("UINT")] uint uCount);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindResourceAsUnorderedAccessViewByName(ID3D11ModuleInstance* pThis, [NativeTypeName("LPCSTR")] sbyte* pSrvName, [NativeTypeName("UINT")] uint uDstUavSlot, [NativeTypeName("UINT")] uint uCount);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BindConstantBuffer([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint cbDstOffset)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindConstantBuffer>(lpVtbl->BindConstantBuffer)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, cbDstOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint cbDstOffset)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindConstantBufferByName>(lpVtbl->BindConstantBufferByName)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, cbDstOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindResource([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindResource>(lpVtbl->BindResource)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindResourceByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindResourceByName>(lpVtbl->BindResourceByName)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindSampler([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindSampler>(lpVtbl->BindSampler)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindSamplerByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindSamplerByName>(lpVtbl->BindSamplerByName)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindUnorderedAccessView([NativeTypeName("UINT")] uint uSrcSlot, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindUnorderedAccessView>(lpVtbl->BindUnorderedAccessView)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pName, [NativeTypeName("UINT")] uint uDstSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindUnorderedAccessViewByName>(lpVtbl->BindUnorderedAccessViewByName)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindResourceAsUnorderedAccessView([NativeTypeName("UINT")] uint uSrcSrvSlot, [NativeTypeName("UINT")] uint uDstUavSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindResourceAsUnorderedAccessView>(lpVtbl->BindResourceAsUnorderedAccessView)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSrvSlot, uDstUavSlot, uCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindResourceAsUnorderedAccessViewByName([NativeTypeName("LPCSTR")] sbyte* pSrvName, [NativeTypeName("UINT")] uint uDstUavSlot, [NativeTypeName("UINT")] uint uCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindResourceAsUnorderedAccessViewByName>(lpVtbl->BindResourceAsUnorderedAccessViewByName)((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pSrvName, uDstUavSlot, uCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindConstantBuffer;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindResource;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindResourceByName;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindSampler;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindSamplerByName;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindUnorderedAccessView;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindUnorderedAccessViewByName;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindResourceAsUnorderedAccessView;

            [NativeTypeName("HRESULT (LPCSTR, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr BindResourceAsUnorderedAccessViewByName;
        }
    }
}
