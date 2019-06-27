// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>A transform uses this interface to specify how to render a particular pass using compute shader.</summary>
    [Guid("5598B14B-9FD7-48B7-9BDB-8F0964EB38BC")]
    public unsafe struct ID2D1ComputeInfo
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1ComputeInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1ComputeInfo* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1ComputeInfo* This
        );
        #endregion

        #region ID2D1RenderInfo Delegates
        /// <summary>Sets options for sampling the specified image input</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetInputDescription(
            [In] ID2D1ComputeInfo* This,
            [In, NativeTypeName("UINT32")] uint inputIndex,
            [In] D2D1_INPUT_DESCRIPTION inputDescription
        );

        /// <summary>Controls the output precision and channel-depth for the associated transform.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetOutputBuffer(
            [In] ID2D1ComputeInfo* This,
            [In] D2D1_BUFFER_PRECISION bufferPrecision,
            [In] D2D1_CHANNEL_DEPTH channelDepth
        );

        /// <summary>Controls whether the output of the associated transform is cached.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetCached(
            [In] ID2D1ComputeInfo* This,
            [In, NativeTypeName("BOOL")] int isCached
        );

        /// <summary>Provides a hint of the approximate shader instruction count per pixel.  If provided, it may improve performance when processing large images.  Instructions should be counted multiple times if occurring within loops.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetInstructionCountHint(
            [In] ID2D1ComputeInfo* This,
            [In, NativeTypeName("UINT32")] uint instructionCount
        );
        #endregion

        #region Delegates
        /// <summary>Set the constant buffer for this transform.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetComputeShaderConstantBuffer(
            [In] ID2D1ComputeInfo* This,
            [In, NativeTypeName("BYTE[]")] byte* buffer,
            [In, NativeTypeName("UINT32")] uint bufferCount
        );

        /// <summary>Set the shader instructions for this transform.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetComputeShader(
            [In] ID2D1ComputeInfo* This,
            [In, NativeTypeName("REFGUID")] Guid* shaderId
        );

        /// <summary>Sets the resource texture corresponding to the given shader texture index.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetResourceTexture(
            [In] ID2D1ComputeInfo* This,
            [In, NativeTypeName("UINT32")] uint textureIndex,
            [In] ID2D1ResourceTexture* resourceTexture
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1RenderInfo Methods
        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription(
            [In, NativeTypeName("UINT32")] uint inputIndex,
            [In] D2D1_INPUT_DESCRIPTION inputDescription
        )
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return MarshalFunction<_SetInputDescription>(lpVtbl->SetInputDescription)(
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
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return MarshalFunction<_SetOutputBuffer>(lpVtbl->SetOutputBuffer)(
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
            fixed (ID2D1ComputeInfo* This = &this)
            {
                MarshalFunction<_SetCached>(lpVtbl->SetCached)(
                    This,
                    isCached
                );
            }
        }

        public void SetInstructionCountHint(
            [In, NativeTypeName("UINT32")] uint instructionCount
        )
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                MarshalFunction<_SetInstructionCountHint>(lpVtbl->SetInstructionCountHint)(
                    This,
                    instructionCount
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int SetComputeShaderConstantBuffer(
            [In, NativeTypeName("BYTE[]")] byte* buffer,
            [In, NativeTypeName("UINT32")] uint bufferCount
        )
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return MarshalFunction<_SetComputeShaderConstantBuffer>(lpVtbl->SetComputeShaderConstantBuffer)(
                    This,
                    buffer,
                    bufferCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetComputeShader(
            [In, NativeTypeName("REFGUID")] Guid* shaderId
        )
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return MarshalFunction<_SetComputeShader>(lpVtbl->SetComputeShader)(
                    This,
                    shaderId
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResourceTexture(
            [In, NativeTypeName("UINT32")] uint textureIndex,
            [In] ID2D1ResourceTexture* resourceTexture
        )
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return MarshalFunction<_SetResourceTexture>(lpVtbl->SetResourceTexture)(
                    This,
                    textureIndex,
                    resourceTexture
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1RenderInfo Fields
            public IntPtr SetInputDescription;

            public IntPtr SetOutputBuffer;

            public IntPtr SetCached;

            public IntPtr SetInstructionCountHint;
            #endregion

            #region Fields
            public IntPtr SetComputeShaderConstantBuffer;

            public IntPtr SetComputeShader;

            public IntPtr SetResourceTexture;
            #endregion
        }
        #endregion
    }
}
