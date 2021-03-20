// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11FCBFC8-F93A-471B-B121-F379E349313C")]
    [NativeTypeName("struct IDataReaderStatics : IInspectable")]
    public unsafe partial struct IDataReaderStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDataReaderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDataReaderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataReaderStatics*, uint>)(lpVtbl[1]))((IDataReaderStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataReaderStatics*, uint>)(lpVtbl[2]))((IDataReaderStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDataReaderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDataReaderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDataReaderStatics*, IntPtr*, int>)(lpVtbl[4]))((IDataReaderStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDataReaderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDataReaderStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Storage::Streams::IDataReader **")] IDataReader** dataReader)
        {
            return ((delegate* unmanaged<IDataReaderStatics*, IBuffer*, IDataReader**, int>)(lpVtbl[6]))((IDataReaderStatics*)Unsafe.AsPointer(ref this), buffer, dataReader);
        }
    }
}
