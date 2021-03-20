// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("905A0FE2-BC53-11DF-8C49-001E4FC686DA")]
    [NativeTypeName("struct IInputStream : IInspectable")]
    public unsafe partial struct IInputStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IInputStream*, Guid*, void**, int>)(lpVtbl[0]))((IInputStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInputStream*, uint>)(lpVtbl[1]))((IInputStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInputStream*, uint>)(lpVtbl[2]))((IInputStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IInputStream*, uint*, Guid**, int>)(lpVtbl[3]))((IInputStream*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IInputStream*, IntPtr*, int>)(lpVtbl[4]))((IInputStream*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IInputStream*, TrustLevel*, int>)(lpVtbl[5]))((IInputStream*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions")] InputStreamOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT32_t **")] IAsyncOperationWithProgress<IntPtr, uint>** operation)
        {
            return ((delegate* unmanaged<IInputStream*, IBuffer*, uint, InputStreamOptions, IAsyncOperationWithProgress<IntPtr, uint>**, int>)(lpVtbl[6]))((IInputStream*)Unsafe.AsPointer(ref this), buffer, count, options, operation);
        }
    }
}
