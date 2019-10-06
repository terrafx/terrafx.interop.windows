// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_PIXEL_OPTIONS;

namespace TerraFX.Interop
{
    /// <summary>A transform uses this interface to specify how to render a particular pass using pixel and vertex shaders.</summary>
    [Guid("693CE632-7F2F-45DE-93FE-18D88B37AA21")]
    public unsafe partial struct ID2D1DrawInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1DrawInfo* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1DrawInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1DrawInfo* This);

        /// <summary>Sets options for sampling the specified image input</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInputDescription(ID2D1DrawInfo* This, [NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription);

        /// <summary>Controls the output precision and channel-depth for the associated transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputBuffer(ID2D1DrawInfo* This, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);

        /// <summary>Controls whether the output of the associated transform is cached.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetCached(ID2D1DrawInfo* This, [NativeTypeName("BOOL")] int isCached);

        /// <summary>Provides a hint of the approximate shader instruction count per pixel.  If provided, it may improve performance when processing large images.  Instructions should be counted multiple times if occurring within loops.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetInstructionCountHint(ID2D1DrawInfo* This, [NativeTypeName("UINT32")] uint instructionCount);

        /// <summary>Set the constant buffer for this transform's pixel shader.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPixelShaderConstantBuffer(ID2D1DrawInfo* This, [NativeTypeName("BYTE[]")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount);

        /// <summary>Sets the resource texture corresponding to the given shader texture index.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResourceTexture(ID2D1DrawInfo* This, [NativeTypeName("UINT32")] uint textureIndex, ID2D1ResourceTexture* resourceTexture);

        /// <summary>Set the constant buffer for this transform's vertex shader.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVertexShaderConstantBuffer(ID2D1DrawInfo* This, [NativeTypeName("BYTE[]")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount);

        /// <summary>Set the shader instructions for this transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPixelShader(ID2D1DrawInfo* This, [NativeTypeName("REFGUID")] Guid* shaderId, D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE);

        /// <summary>Set custom vertices for the associated transform.  A blend mode if foreground-over will be used if blendDescription is NULL.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVertexProcessing(ID2D1DrawInfo* This, [Optional] ID2D1VertexBuffer* vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, D2D1_BLEND_DESCRIPTION* blendDescription = null, D2D1_VERTEX_RANGE* vertexRange = null, [NativeTypeName("GUID")] Guid* vertexShader = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetInputDescription>(lpVtbl->SetInputDescription)(This, inputIndex, inputDescription);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetOutputBuffer>(lpVtbl->SetOutputBuffer)(This, bufferPrecision, channelDepth);
            }
        }

        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetCached>(lpVtbl->SetCached)(This, isCached);
            }
        }

        public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInstructionCountHint>(lpVtbl->SetInstructionCountHint)(This, instructionCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantBuffer([NativeTypeName("BYTE[]")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPixelShaderConstantBuffer>(lpVtbl->SetPixelShaderConstantBuffer)(This, buffer, bufferCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResourceTexture([NativeTypeName("UINT32")] uint textureIndex, ID2D1ResourceTexture* resourceTexture)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResourceTexture>(lpVtbl->SetResourceTexture)(This, textureIndex, resourceTexture);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantBuffer([NativeTypeName("BYTE[]")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetVertexShaderConstantBuffer>(lpVtbl->SetVertexShaderConstantBuffer)(This, buffer, bufferCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelShader([NativeTypeName("REFGUID")] Guid* shaderId, D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPixelShader>(lpVtbl->SetPixelShader)(This, shaderId, pixelOptions);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVertexProcessing([Optional] ID2D1VertexBuffer* vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, D2D1_BLEND_DESCRIPTION* blendDescription = null, D2D1_VERTEX_RANGE* vertexRange = null, [NativeTypeName("GUID")] Guid* vertexShader = null)
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetVertexProcessing>(lpVtbl->SetVertexProcessing)(This, vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShader);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetInputDescription;

            public IntPtr SetOutputBuffer;

            public IntPtr SetCached;

            public IntPtr SetInstructionCountHint;

            public IntPtr SetPixelShaderConstantBuffer;

            public IntPtr SetResourceTexture;

            public IntPtr SetVertexShaderConstantBuffer;

            public IntPtr SetPixelShader;

            public IntPtr SetVertexProcessing;
        }
    }
}
