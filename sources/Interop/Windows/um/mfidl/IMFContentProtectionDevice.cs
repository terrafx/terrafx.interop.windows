// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E6257174-A060-4C9A-A088-3B1B471CAD28")]
    [NativeTypeName("struct IMFContentProtectionDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFContentProtectionDevice : IMFContentProtectionDevice.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, uint>)(lpVtbl[1]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, uint>)(lpVtbl[2]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT InvokeFunction([NativeTypeName("DWORD")] uint FunctionId, [NativeTypeName("DWORD")] uint InputBufferByteCount, [NativeTypeName("const BYTE *")] byte* InputBuffer, [NativeTypeName("DWORD *")] uint* OutputBufferByteCount, byte* OutputBuffer)
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, uint, uint, byte*, uint*, byte*, int>)(lpVtbl[3]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this), FunctionId, InputBufferByteCount, InputBuffer, OutputBufferByteCount, OutputBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPrivateDataByteCount([NativeTypeName("DWORD *")] uint* PrivateInputByteCount, [NativeTypeName("DWORD *")] uint* PrivateOutputByteCount)
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, uint*, uint*, int>)(lpVtbl[4]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this), PrivateInputByteCount, PrivateOutputByteCount);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT InvokeFunction([NativeTypeName("DWORD")] uint FunctionId, [NativeTypeName("DWORD")] uint InputBufferByteCount, [NativeTypeName("const BYTE *")] byte* InputBuffer, [NativeTypeName("DWORD *")] uint* OutputBufferByteCount, byte* OutputBuffer);

            [VtblIndex(4)]
            HRESULT GetPrivateDataByteCount([NativeTypeName("DWORD *")] uint* PrivateInputByteCount, [NativeTypeName("DWORD *")] uint* PrivateOutputByteCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentProtectionDevice*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentProtectionDevice*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentProtectionDevice*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD, const BYTE *, DWORD *, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentProtectionDevice*, uint, uint, byte*, uint*, byte*, int> InvokeFunction;

            [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFContentProtectionDevice*, uint*, uint*, int> GetPrivateDataByteCount;
        }
    }
}
