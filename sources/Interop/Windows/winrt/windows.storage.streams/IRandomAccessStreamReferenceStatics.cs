// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("857309DC-3FBF-4E7D-986F-EF3B1A07A964")]
    [NativeTypeName("struct IRandomAccessStreamReferenceStatics : IInspectable")]
    public unsafe partial struct IRandomAccessStreamReferenceStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, uint>)(lpVtbl[1]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, uint>)(lpVtbl[2]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, IntPtr*, int>)(lpVtbl[4]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IInspectable* file, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** streamReference)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, IInspectable*, IRandomAccessStreamReference**, int>)(lpVtbl[6]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this), file, streamReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** streamReference)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, IUriRuntimeClass*, IRandomAccessStreamReference**, int>)(lpVtbl[7]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this), uri, streamReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** streamReference)
        {
            return ((delegate* unmanaged<IRandomAccessStreamReferenceStatics*, IRandomAccessStream*, IRandomAccessStreamReference**, int>)(lpVtbl[8]))((IRandomAccessStreamReferenceStatics*)Unsafe.AsPointer(ref this), stream, streamReference);
        }
    }
}
