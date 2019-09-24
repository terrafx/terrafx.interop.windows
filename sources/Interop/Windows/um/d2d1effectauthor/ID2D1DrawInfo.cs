// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Interop.D2D1_PIXEL_OPTIONS;

namespace TerraFX.Interop
{
    /// <summary>A transform uses this interface to specify how to render a particular pass using pixel and vertex shaders.</summary>
    [Guid("693CE632-7F2F-45DE-93FE-18D88B37AA21")]
    public unsafe struct ID2D1DrawInfo
    {
        public readonly Vtbl* lpVtbl;

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1DrawInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1DrawInfo* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1DrawInfo* This
        );

        /// <summary>Sets options for sampling the specified image input</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetInputDescription(
            [In] ID2D1DrawInfo* This,
            [In, NativeTypeName("UINT32")] uint inputIndex,
            [In] D2D1_INPUT_DESCRIPTION inputDescription
        );

        /// <summary>Controls the output precision and channel-depth for the associated transform.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetOutputBuffer(
            [In] ID2D1DrawInfo* This,
            [In] D2D1_BUFFER_PRECISION bufferPrecision,
            [In] D2D1_CHANNEL_DEPTH channelDepth
        );

        /// <summary>Controls whether the output of the associated transform is cached.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetCached(
            [In] ID2D1DrawInfo* This,
            [In, NativeTypeName("BOOL")] int isCached
        );

        /// <summary>Provides a hint of the approximate shader instruction count per pixel.  If provided, it may improve performance when processing large images.  Instructions should be counted multiple times if occurring within loops.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetInstructionCountHint(
            [In] ID2D1DrawInfo* This,
            [In, NativeTypeName("UINT32")] uint instructionCount
        );

        /// <summary>Set the constant buffer for this transform's pixel shader.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPixelShaderConstantBuffer(
            [In] ID2D1DrawInfo* This,
            [In, NativeTypeName("BYTE[]")] byte* buffer,
            [In, NativeTypeName("UINT32")] uint bufferCount
        );

        /// <summary>Sets the resource texture corresponding to the given shader texture index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetResourceTexture(
            [In] ID2D1DrawInfo* This,
            [In, NativeTypeName("UINT32")] uint textureIndex,
            [In] ID2D1ResourceTexture* resourceTexture
        );

        /// <summary>Set the constant buffer for this transform's vertex shader.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetVertexShaderConstantBuffer(
            [In] ID2D1DrawInfo* This,
            [In, NativeTypeName("BYTE[]")] byte* buffer,
            [In, NativeTypeName("UINT32")] uint bufferCount
        );

        /// <summary>Set the shader instructions for this transform.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPixelShader(
            [In] ID2D1DrawInfo* This,
            [In, NativeTypeName("REFGUID")] Guid* shaderId,
            [In] D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE
        );

        /// <summary>Set custom vertices for the associated transform.  A blend mode if foreground-over will be used if blendDescription is NULL.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetVertexProcessing(
            [In] ID2D1DrawInfo* This,
            [In, Optional] ID2D1VertexBuffer* vertexBuffer,
            [In] D2D1_VERTEX_OPTIONS vertexOptions,
            [In] D2D1_BLEND_DESCRIPTION* blendDescription = null,
            [In] D2D1_VERTEX_RANGE* vertexRange = null,
            [In, NativeTypeName("GUID")] Guid* vertexShader = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription(
            [In, NativeTypeName("UINT32")] uint inputIndex,
            [In] D2D1_INPUT_DESCRIPTION inputDescription
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetInputDescription>(lpVtbl->SetInputDescription)(
                    This,
                    inputIndex,
                    inputDescription
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(
            [In] D2D1_BUFFER_PRECISION bufferPrecision,
            [In] D2D1_CHANNEL_DEPTH channelDepth
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetOutputBuffer>(lpVtbl->SetOutputBuffer)(
                    This,
                    bufferPrecision,
                    channelDepth
                );
            }
        }

        public void SetCached(
            [In, NativeTypeName("BOOL")] int isCached
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetCached>(lpVtbl->SetCached)(
                    This,
                    isCached
                );
            }
        }

        public void SetInstructionCountHint(
            [In, NativeTypeName("UINT32")] uint instructionCount
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInstructionCountHint>(lpVtbl->SetInstructionCountHint)(
                    This,
                    instructionCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelShaderConstantBuffer(
            [In, NativeTypeName("BYTE[]")] byte* buffer,
            [In, NativeTypeName("UINT32")] uint bufferCount
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPixelShaderConstantBuffer>(lpVtbl->SetPixelShaderConstantBuffer)(
                    This,
                    buffer,
                    bufferCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResourceTexture(
            [In, NativeTypeName("UINT32")] uint textureIndex,
            [In] ID2D1ResourceTexture* resourceTexture
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResourceTexture>(lpVtbl->SetResourceTexture)(
                    This,
                    textureIndex,
                    resourceTexture
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVertexShaderConstantBuffer(
            [In, NativeTypeName("BYTE[]")] byte* buffer,
            [In, NativeTypeName("UINT32")] uint bufferCount
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetVertexShaderConstantBuffer>(lpVtbl->SetVertexShaderConstantBuffer)(
                    This,
                    buffer,
                    bufferCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelShader(
            [In, NativeTypeName("REFGUID")] Guid* shaderId,
            [In] D2D1_PIXEL_OPTIONS pixelOptions = D2D1_PIXEL_OPTIONS_NONE
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPixelShader>(lpVtbl->SetPixelShader)(
                    This,
                    shaderId,
                    pixelOptions
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVertexProcessing(
            [In, Optional] ID2D1VertexBuffer* vertexBuffer,
            [In] D2D1_VERTEX_OPTIONS vertexOptions,
            [In] D2D1_BLEND_DESCRIPTION* blendDescription = null,
            [In] D2D1_VERTEX_RANGE* vertexRange = null,
            [In, NativeTypeName("GUID")] Guid* vertexShader = null
        )
        {
            fixed (ID2D1DrawInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetVertexProcessing>(lpVtbl->SetVertexProcessing)(
                    This,
                    vertexBuffer,
                    vertexOptions,
                    blendDescription,
                    vertexRange,
                    vertexShader
                );
            }
        }

        public struct Vtbl
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
