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
    [NativeTypeName("struct ID2D1DrawInfo : ID2D1RenderInfo")]
    public unsafe partial struct ID2D1DrawInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, uint>)(lpVtbl[1]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, uint>)(lpVtbl[2]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, uint, D2D1_INPUT_DESCRIPTION, int>)(lpVtbl[3]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), inputIndex, inputDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int>)(lpVtbl[4]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            ((delegate* stdcall<ID2D1DrawInfo*, int, void>)(lpVtbl[5]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), isCached);
        }

        public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
        {
            ((delegate* stdcall<ID2D1DrawInfo*, uint, void>)(lpVtbl[6]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), instructionCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, byte*, uint, int>)(lpVtbl[7]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResourceTexture([NativeTypeName("UINT32")] uint textureIndex, [NativeTypeName("ID2D1ResourceTexture *")] ID2D1ResourceTexture* resourceTexture)
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, uint, ID2D1ResourceTexture*, int>)(lpVtbl[8]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), textureIndex, resourceTexture);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, byte*, uint, int>)(lpVtbl[9]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelShader([NativeTypeName("const GUID &")] Guid* shaderId, D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE)
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, Guid*, D2D1_PIXEL_OPTIONS, int>)(lpVtbl[10]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), shaderId, pixelOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVertexProcessing([NativeTypeName("ID2D1VertexBuffer *")] ID2D1VertexBuffer* vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, [NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* blendDescription = null, [NativeTypeName("const D2D1_VERTEX_RANGE *")] D2D1_VERTEX_RANGE* vertexRange = null, [NativeTypeName("const GUID *")] Guid* vertexShader = null)
        {
            return ((delegate* stdcall<ID2D1DrawInfo*, ID2D1VertexBuffer*, D2D1_VERTEX_OPTIONS, D2D1_BLEND_DESCRIPTION*, D2D1_VERTEX_RANGE*, Guid*, int>)(lpVtbl[11]))((ID2D1DrawInfo*)Unsafe.AsPointer(ref this), vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShader);
        }
    }
}
