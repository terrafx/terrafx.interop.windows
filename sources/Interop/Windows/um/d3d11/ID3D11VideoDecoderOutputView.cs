// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C2931AEA-2A85-4F20-860F-FBA1FD256E18")]
    public unsafe partial struct ID3D11VideoDecoderOutputView
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11VideoDecoderOutputView*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11VideoDecoderOutputView*, uint>)(lpVtbl[1]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11VideoDecoderOutputView*, uint>)(lpVtbl[2]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* stdcall<ID3D11VideoDecoderOutputView*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11VideoDecoderOutputView*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11VideoDecoderOutputView*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D11VideoDecoderOutputView*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetResource([NativeTypeName("ID3D11Resource **")] ID3D11Resource** ppResource)
        {
            ((delegate* stdcall<ID3D11VideoDecoderOutputView*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this), ppResource);
        }

        public void GetDesc([NativeTypeName("D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC *")] D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC* pDesc)
        {
            ((delegate* stdcall<ID3D11VideoDecoderOutputView*, D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC*, void>)(lpVtbl[8]))((ID3D11VideoDecoderOutputView*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
