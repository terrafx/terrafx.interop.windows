// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("33EE3134-1DD6-4E3A-8067-D1C162E8642B")]
    [NativeTypeName("struct IRandomAccessStreamReference : IInspectable")]
    public unsafe partial struct IRandomAccessStreamReference
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReference*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStreamReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRandomAccessStreamReference*, uint>)(lpVtbl[1]))((IRandomAccessStreamReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRandomAccessStreamReference*, uint>)(lpVtbl[2]))((IRandomAccessStreamReference*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReference*, uint*, Guid**, int>)(lpVtbl[3]))((IRandomAccessStreamReference*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReference*, IntPtr*, int>)(lpVtbl[4]))((IRandomAccessStreamReference*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReference*, TrustLevel*, int>)(lpVtbl[5]))((IRandomAccessStreamReference*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenReadAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReference*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IRandomAccessStreamReference*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
