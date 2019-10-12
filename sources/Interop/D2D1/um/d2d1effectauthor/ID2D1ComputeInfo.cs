// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>A transform uses this interface to specify how to render a particular pass using compute shader.</summary>
    [Guid("5598B14B-9FD7-48B7-9BDB-8F0964EB38BC")]
    public unsafe partial struct ID2D1ComputeInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1ComputeInfo* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1ComputeInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1ComputeInfo* This);

        /// <summary>Sets options for sampling the specified image input</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInputDescription(ID2D1ComputeInfo* This, [NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription);

        /// <summary>Controls the output precision and channel-depth for the associated transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputBuffer(ID2D1ComputeInfo* This, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);

        /// <summary>Controls whether the output of the associated transform is cached.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetCached(ID2D1ComputeInfo* This, [NativeTypeName("BOOL")] int isCached);

        /// <summary>Provides a hint of the approximate shader instruction count per pixel.  If provided, it may improve performance when processing large images.  Instructions should be counted multiple times if occurring within loops.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetInstructionCountHint(ID2D1ComputeInfo* This, [NativeTypeName("UINT32")] uint instructionCount);

        /// <summary>Set the constant buffer for this transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetComputeShaderConstantBuffer(ID2D1ComputeInfo* This, [NativeTypeName("BYTE[]")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount);

        /// <summary>Set the shader instructions for this transform.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetComputeShader(ID2D1ComputeInfo* This, [NativeTypeName("REFGUID")] Guid* shaderId);

        /// <summary>Sets the resource texture corresponding to the given shader texture index.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResourceTexture(ID2D1ComputeInfo* This, [NativeTypeName("UINT32")] uint textureIndex, ID2D1ResourceTexture* resourceTexture);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetInputDescription>(lpVtbl->SetInputDescription)(This, inputIndex, inputDescription);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetOutputBuffer>(lpVtbl->SetOutputBuffer)(This, bufferPrecision, channelDepth);
            }
        }

        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetCached>(lpVtbl->SetCached)(This, isCached);
            }
        }

        public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetInstructionCountHint>(lpVtbl->SetInstructionCountHint)(This, instructionCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetComputeShaderConstantBuffer([NativeTypeName("BYTE[]")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetComputeShaderConstantBuffer>(lpVtbl->SetComputeShaderConstantBuffer)(This, buffer, bufferCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetComputeShader([NativeTypeName("REFGUID")] Guid* shaderId)
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetComputeShader>(lpVtbl->SetComputeShader)(This, shaderId);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResourceTexture([NativeTypeName("UINT32")] uint textureIndex, ID2D1ResourceTexture* resourceTexture)
        {
            fixed (ID2D1ComputeInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetResourceTexture>(lpVtbl->SetResourceTexture)(This, textureIndex, resourceTexture);
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

            public IntPtr SetComputeShaderConstantBuffer;

            public IntPtr SetComputeShader;

            public IntPtr SetResourceTexture;
        }
    }
}
