// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("905A0FE1-BC53-11DF-8C49-001E4FC686DA")]
    [NativeTypeName("struct IRandomAccessStream : IInspectable")]
    public unsafe partial struct IRandomAccessStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRandomAccessStream*, uint>)(lpVtbl[1]))((IRandomAccessStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRandomAccessStream*, uint>)(lpVtbl[2]))((IRandomAccessStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, uint*, Guid**, int>)(lpVtbl[3]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, IntPtr*, int>)(lpVtbl[4]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, TrustLevel*, int>)(lpVtbl[5]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Size([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, ulong*, int>)(lpVtbl[6]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Size([NativeTypeName("UINT64")] ulong value)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, ulong, int>)(lpVtbl[7]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamAt([NativeTypeName("UINT64")] ulong position, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** stream)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, ulong, IInputStream**, int>)(lpVtbl[8]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), position, stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStreamAt([NativeTypeName("UINT64")] ulong position, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** stream)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, ulong, IOutputStream**, int>)(lpVtbl[9]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), position, stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Position([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, ulong*, int>)(lpVtbl[10]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek([NativeTypeName("UINT64")] ulong position)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, ulong, int>)(lpVtbl[11]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloneStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** stream)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, IRandomAccessStream**, int>)(lpVtbl[12]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CanRead([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, byte*, int>)(lpVtbl[13]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CanWrite([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IRandomAccessStream*, byte*, int>)(lpVtbl[14]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
        }
    }
}
