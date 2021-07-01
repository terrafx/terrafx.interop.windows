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
    public unsafe partial struct IMFContentProtectionDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, uint>)(lpVtbl[1]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, uint>)(lpVtbl[2]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeFunction([NativeTypeName("DWORD")] uint FunctionId, [NativeTypeName("DWORD")] uint InputBufferByteCount, [NativeTypeName("const BYTE *")] byte* InputBuffer, [NativeTypeName("DWORD *")] uint* OutputBufferByteCount, [NativeTypeName("BYTE *")] byte* OutputBuffer)
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, uint, uint, byte*, uint*, byte*, int>)(lpVtbl[3]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this), FunctionId, InputBufferByteCount, InputBuffer, OutputBufferByteCount, OutputBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateDataByteCount([NativeTypeName("DWORD *")] uint* PrivateInputByteCount, [NativeTypeName("DWORD *")] uint* PrivateOutputByteCount)
        {
            return ((delegate* unmanaged<IMFContentProtectionDevice*, uint*, uint*, int>)(lpVtbl[4]))((IMFContentProtectionDevice*)Unsafe.AsPointer(ref this), PrivateInputByteCount, PrivateOutputByteCount);
        }
    }
}
