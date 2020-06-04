// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/dxc/dxcapi.h in the microsoft/DirectXCompiler commit e0cde072b09b51506c0460697b2695d6cccca59d
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("58346CDA-DDE7-4497-9461-6F87AF5E0659")]
    public unsafe partial struct IDxcResult
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcResult*, Guid*, void**, int>)(lpVtbl[0]))((IDxcResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcResult*, uint>)(lpVtbl[1]))((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcResult*, uint>)(lpVtbl[2]))((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("HRESULT *")] int* pStatus)
        {
            return ((delegate* stdcall<IDxcResult*, int*, int>)(lpVtbl[0]))((IDxcResult*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResult([NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return ((delegate* stdcall<IDxcResult*, IDxcBlob**, int>)(lpVtbl[1]))((IDxcResult*)Unsafe.AsPointer(ref this), ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetErrorBuffer([NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppErrors)
        {
            return ((delegate* stdcall<IDxcResult*, IDxcBlobEncoding**, int>)(lpVtbl[2]))((IDxcResult*)Unsafe.AsPointer(ref this), ppErrors);
        }

        [return: NativeTypeName("BOOL")]
        public int HasOutput(DXC_OUT_KIND dxcOutKind)
        {
            return ((delegate* stdcall<IDxcResult*, DXC_OUT_KIND, int>)(lpVtbl[0]))((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvObject, [NativeTypeName("IDxcBlobUtf16 **")] IDxcBlobUtf16** ppOutputName)
        {
            return ((delegate* stdcall<IDxcResult*, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16**, int>)(lpVtbl[1]))((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind, iid, ppvObject, ppOutputName);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetNumOutputs()
        {
            return ((delegate* stdcall<IDxcResult*, uint>)(lpVtbl[2]))((IDxcResult*)Unsafe.AsPointer(ref this));
        }

        public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
        {
            return ((delegate* stdcall<IDxcResult*, uint, DXC_OUT_KIND>)(lpVtbl[3]))((IDxcResult*)Unsafe.AsPointer(ref this), Index);
        }

        public DXC_OUT_KIND PrimaryOutput()
        {
            return ((delegate* stdcall<IDxcResult*, DXC_OUT_KIND>)(lpVtbl[4]))((IDxcResult*)Unsafe.AsPointer(ref this));
        }
    }
}
