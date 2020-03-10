// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5598B14B-9FD7-48B7-9BDB-8F0964EB38BC")]
    public unsafe partial struct ID2D1ComputeInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1ComputeInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1ComputeInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1ComputeInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetInputDescription(ID2D1ComputeInfo* pThis, [NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputBuffer(ID2D1ComputeInfo* pThis, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetCached(ID2D1ComputeInfo* pThis, [NativeTypeName("BOOL")] int isCached);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetInstructionCountHint(ID2D1ComputeInfo* pThis, [NativeTypeName("UINT32")] uint instructionCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetComputeShaderConstantBuffer(ID2D1ComputeInfo* pThis, [NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetComputeShader(ID2D1ComputeInfo* pThis, [NativeTypeName("const GUID &")] Guid* shaderId);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetResourceTexture(ID2D1ComputeInfo* pThis, [NativeTypeName("UINT32")] uint textureIndex, [NativeTypeName("ID2D1ResourceTexture *")] ID2D1ResourceTexture* resourceTexture);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputDescription([NativeTypeName("UINT32")] uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetInputDescription>(lpVtbl->SetInputDescription)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), inputIndex, inputDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOutputBuffer>(lpVtbl->SetOutputBuffer)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            Marshal.GetDelegateForFunctionPointer<_SetCached>(lpVtbl->SetCached)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), isCached);
        }

        public void SetInstructionCountHint([NativeTypeName("UINT32")] uint instructionCount)
        {
            Marshal.GetDelegateForFunctionPointer<_SetInstructionCountHint>(lpVtbl->SetInstructionCountHint)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), instructionCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetComputeShaderConstantBuffer([NativeTypeName("const BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetComputeShaderConstantBuffer>(lpVtbl->SetComputeShaderConstantBuffer)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetComputeShader([NativeTypeName("const GUID &")] Guid* shaderId)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetComputeShader>(lpVtbl->SetComputeShader)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), shaderId);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetResourceTexture([NativeTypeName("UINT32")] uint textureIndex, [NativeTypeName("ID2D1ResourceTexture *")] ID2D1ResourceTexture* resourceTexture)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetResourceTexture>(lpVtbl->SetResourceTexture)((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), textureIndex, resourceTexture);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT32, D2D1_INPUT_DESCRIPTION) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInputDescription;

            [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOutputBuffer;

            [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCached;

            [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetInstructionCountHint;

            [NativeTypeName("HRESULT (const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetComputeShaderConstantBuffer;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetComputeShader;

            [NativeTypeName("HRESULT (UINT32, ID2D1ResourceTexture *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetResourceTexture;
        }
    }
}
