// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("HRESULT *")] int* pStatus)
        {
            return lpVtbl->GetStatus((IDxcResult*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResult([NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return lpVtbl->GetResult((IDxcResult*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetErrorBuffer([NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppErrors)
        {
            return lpVtbl->GetErrorBuffer((IDxcResult*)Unsafe.AsPointer(ref this), ppErrors);
        }

        [return: NativeTypeName("BOOL")]
        public int HasOutput(DXC_OUT_KIND dxcOutKind)
        {
            return lpVtbl->HasOutput((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvObject, [NativeTypeName("IDxcBlobUtf16 **")] IDxcBlobUtf16** ppOutputName)
        {
            return lpVtbl->GetOutput((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind, iid, ppvObject, ppOutputName);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetNumOutputs()
        {
            return lpVtbl->GetNumOutputs((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
        {
            return lpVtbl->GetOutputByIndex((IDxcResult*)Unsafe.AsPointer(ref this), Index);
        }

        public DXC_OUT_KIND PrimaryOutput()
        {
            return lpVtbl->PrimaryOutput((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcResult*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcResult*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcResult*, uint> Release;

            [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcResult*, int*, int> GetStatus;

            [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcResult*, IDxcBlob**, int> GetResult;

            [NativeTypeName("HRESULT (IDxcBlobEncoding **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcResult*, IDxcBlobEncoding**, int> GetErrorBuffer;

            [NativeTypeName("BOOL (DXC_OUT_KIND) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcResult*, DXC_OUT_KIND, int> HasOutput;

            [NativeTypeName("HRESULT (DXC_OUT_KIND, const IID &, void **, IDxcBlobUtf16 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcResult*, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16**, int> GetOutput;

            [NativeTypeName("UINT32 () __attribute__((thiscall))")]
            public delegate* stdcall<IDxcResult*, uint> GetNumOutputs;

            [NativeTypeName("DXC_OUT_KIND (UINT32) __attribute__((thiscall))")]
            public delegate* stdcall<IDxcResult*, uint, DXC_OUT_KIND> GetOutputByIndex;

            [NativeTypeName("DXC_OUT_KIND () __attribute__((thiscall))")]
            public delegate* stdcall<IDxcResult*, DXC_OUT_KIND> PrimaryOutput;
        }
    }
}
