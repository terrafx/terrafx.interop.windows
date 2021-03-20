// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E901E65B-D716-475A-A90A-AF7229B1E741")]
    [NativeTypeName("struct IBufferStatics : IInspectable")]
    public unsafe partial struct IBufferStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IBufferStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBufferStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBufferStatics*, uint>)(lpVtbl[1]))((IBufferStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBufferStatics*, uint>)(lpVtbl[2]))((IBufferStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IBufferStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBufferStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IBufferStatics*, IntPtr*, int>)(lpVtbl[4]))((IBufferStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IBufferStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBufferStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCopyFromMemoryBuffer([NativeTypeName("ABI::Windows::Foundation::IMemoryBuffer *")] IMemoryBuffer* input, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
        {
            return ((delegate* unmanaged<IBufferStatics*, IMemoryBuffer*, IBuffer**, int>)(lpVtbl[6]))((IBufferStatics*)Unsafe.AsPointer(ref this), input, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMemoryBufferOverIBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* input, [NativeTypeName("ABI::Windows::Foundation::IMemoryBuffer **")] IMemoryBuffer** value)
        {
            return ((delegate* unmanaged<IBufferStatics*, IBuffer*, IMemoryBuffer**, int>)(lpVtbl[7]))((IBufferStatics*)Unsafe.AsPointer(ref this), input, value);
        }
    }
}
