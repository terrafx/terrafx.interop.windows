// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler repository (https://github.com/microsoft/DirectXShaderCompiler/) at commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("58346CDA-DDE7-4497-9461-6F87AF5E0659")]
    public unsafe partial struct IDxcResult
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDxcResult* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDxcResult* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDxcResult* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStatus(IDxcResult* pThis, [NativeTypeName("HRESULT *")] int* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResult(IDxcResult* pThis, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetErrorBuffer(IDxcResult* pThis, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppErrors);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _HasOutput(IDxcResult* pThis, DXC_OUT_KIND dxcOutKind);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetOutput(IDxcResult* pThis, DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvObject, [NativeTypeName("IDxcBlobUtf16 **")] IDxcBlobUtf16** ppOutputName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetNumOutputs(IDxcResult* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DXC_OUT_KIND _GetOutputByIndex(IDxcResult* pThis, [NativeTypeName("UINT32")] uint Index);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DXC_OUT_KIND _PrimaryOutput(IDxcResult* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDxcResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("HRESULT *")] int* pStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStatus>(lpVtbl->GetStatus)((IDxcResult*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResult([NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResult>(lpVtbl->GetResult)((IDxcResult*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetErrorBuffer([NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppErrors)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetErrorBuffer>(lpVtbl->GetErrorBuffer)((IDxcResult*)Unsafe.AsPointer(ref this), ppErrors);
        }

        [return: NativeTypeName("BOOL")]
        public int HasOutput(DXC_OUT_KIND dxcOutKind)
        {
            return Marshal.GetDelegateForFunctionPointer<_HasOutput>(lpVtbl->HasOutput)((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvObject, [NativeTypeName("IDxcBlobUtf16 **")] IDxcBlobUtf16** ppOutputName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOutput>(lpVtbl->GetOutput)((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind, iid, ppvObject, ppOutputName);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetNumOutputs()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumOutputs>(lpVtbl->GetNumOutputs)((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOutputByIndex>(lpVtbl->GetOutputByIndex)((IDxcResult*)Unsafe.AsPointer(ref this), Index);
        }

        public DXC_OUT_KIND PrimaryOutput()
        {
            return Marshal.GetDelegateForFunctionPointer<_PrimaryOutput>(lpVtbl->PrimaryOutput)((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
            public IntPtr GetStatus;

            [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
            public IntPtr GetResult;

            [NativeTypeName("HRESULT (IDxcBlobEncoding **) __attribute__((stdcall))")]
            public IntPtr GetErrorBuffer;

            [NativeTypeName("BOOL (DXC_OUT_KIND) __attribute__((stdcall))")]
            public IntPtr HasOutput;

            [NativeTypeName("HRESULT (DXC_OUT_KIND, const IID &, void **, IDxcBlobUtf16 **) __attribute__((stdcall))")]
            public IntPtr GetOutput;

            [NativeTypeName("UINT32 () __attribute__((thiscall))")]
            public IntPtr GetNumOutputs;

            [NativeTypeName("DXC_OUT_KIND (UINT32) __attribute__((thiscall))")]
            public IntPtr GetOutputByIndex;

            [NativeTypeName("DXC_OUT_KIND () __attribute__((thiscall))")]
            public IntPtr PrimaryOutput;
        }
    }
}
