// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_PIXEL_OPTIONS;

namespace TerraFX.Interop
{
    [Guid("693CE632-7F2F-45DE-93FE-18D88B37AA21")]
    public unsafe partial struct ID2D1DrawInfo
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1DrawInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1DrawInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)
        {
            return lpVtbl->SetInputDescription((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), inputIndex, inputDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return lpVtbl->SetOutputBuffer((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            lpVtbl->SetCached((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), isCached);
        }

        public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
        {
            lpVtbl->SetInstructionCountHint((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), instructionCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            return lpVtbl->SetPixelShaderConstantBuffer((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResourceTexture([NativeTypeName("UINT32")] uint textureIndex, [NativeTypeName("ID2D1ResourceTexture *")] ID2D1ResourceTexture* resourceTexture)
        {
            return lpVtbl->SetResourceTexture((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), textureIndex, resourceTexture);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            return lpVtbl->SetVertexShaderConstantBuffer((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelShader([NativeTypeName("const GUID &")] Guid* shaderId, D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE)
        {
            return lpVtbl->SetPixelShader((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), shaderId, pixelOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVertexProcessing([NativeTypeName("ID2D1VertexBuffer *")] ID2D1VertexBuffer* vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription = null, [NativeTypeName("const D2D1_VERTEX_RANGE *")] D2D1_VERTEX_RANGE* vertexRange = null, [NativeTypeName("const GUID *")] Guid* vertexShader = null)
        {
            return lpVtbl->SetVertexProcessing((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShader);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, uint> Release;

            [NativeTypeName("HRESULT (UINT32, D2D1_INPUT_DESCRIPTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, uint, D2D1_INPUT_DESCRIPTION, int> SetInputDescription;

            [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> SetOutputBuffer;

            [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, int, void> SetCached;

            [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, uint, void> SetInstructionCountHint;

            [NativeTypeName("HRESULT (const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, byte*, uint, int> SetPixelShaderConstantBuffer;

            [NativeTypeName("HRESULT (UINT32, ID2D1ResourceTexture *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, uint, ID2D1ResourceTexture*, int> SetResourceTexture;

            [NativeTypeName("HRESULT (const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, byte*, uint, int> SetVertexShaderConstantBuffer;

            [NativeTypeName("HRESULT (const GUID &, D2D1_PIXEL_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, Guid*, D2D1_PIXEL_OPTIONS, int> SetPixelShader;

            [NativeTypeName("HRESULT (ID2D1VertexBuffer *, D2D1_VERTEX_OPTIONS, const D2D1_BLEND_DESCRIPTION *, const D2D1_VERTEX_RANGE *, const GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DrawInfo*, ID2D1VertexBuffer*, D2D1_VERTEX_OPTIONS, D2D1_BLEND_DESCRIPTION*, D2D1_VERTEX_RANGE*, Guid*, int> SetVertexProcessing;
        }
    }
}
