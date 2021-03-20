// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("338C67C2-8B84-4C2B-9C50-7B8767847A1F")]
    [NativeTypeName("struct IDataWriterFactory : IInspectable")]
    public unsafe partial struct IDataWriterFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDataWriterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDataWriterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataWriterFactory*, uint>)(lpVtbl[1]))((IDataWriterFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataWriterFactory*, uint>)(lpVtbl[2]))((IDataWriterFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDataWriterFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IDataWriterFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDataWriterFactory*, IntPtr*, int>)(lpVtbl[4]))((IDataWriterFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDataWriterFactory*, TrustLevel*, int>)(lpVtbl[5]))((IDataWriterFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDataWriter([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* outputStream, [NativeTypeName("ABI::Windows::Storage::Streams::IDataWriter **")] IDataWriter** dataWriter)
        {
            return ((delegate* unmanaged<IDataWriterFactory*, IOutputStream*, IDataWriter**, int>)(lpVtbl[6]))((IDataWriterFactory*)Unsafe.AsPointer(ref this), outputStream, dataWriter);
        }
    }
}
