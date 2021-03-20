// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D7527847-57DA-4E15-914C-06806699A098")]
    [NativeTypeName("struct IDataReaderFactory : IInspectable")]
    public unsafe partial struct IDataReaderFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDataReaderFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDataReaderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataReaderFactory*, uint>)(lpVtbl[1]))((IDataReaderFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataReaderFactory*, uint>)(lpVtbl[2]))((IDataReaderFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDataReaderFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IDataReaderFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDataReaderFactory*, IntPtr*, int>)(lpVtbl[4]))((IDataReaderFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDataReaderFactory*, TrustLevel*, int>)(lpVtbl[5]))((IDataReaderFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDataReader([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* inputStream, [NativeTypeName("ABI::Windows::Storage::Streams::IDataReader **")] IDataReader** dataReader)
        {
            return ((delegate* unmanaged<IDataReaderFactory*, IInputStream*, IDataReader**, int>)(lpVtbl[6]))((IDataReaderFactory*)Unsafe.AsPointer(ref this), inputStream, dataReader);
        }
    }
}
