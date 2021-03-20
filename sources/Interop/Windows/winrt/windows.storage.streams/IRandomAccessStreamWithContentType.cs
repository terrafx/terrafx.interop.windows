// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CC254827-4B3D-438F-9232-10C76BC7E038")]
    [NativeTypeName("struct IRandomAccessStreamWithContentType : IInspectable")]
    public unsafe partial struct IRandomAccessStreamWithContentType
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRandomAccessStreamWithContentType*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStreamWithContentType*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRandomAccessStreamWithContentType*, uint>)(lpVtbl[1]))((IRandomAccessStreamWithContentType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRandomAccessStreamWithContentType*, uint>)(lpVtbl[2]))((IRandomAccessStreamWithContentType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRandomAccessStreamWithContentType*, uint*, Guid**, int>)(lpVtbl[3]))((IRandomAccessStreamWithContentType*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRandomAccessStreamWithContentType*, IntPtr*, int>)(lpVtbl[4]))((IRandomAccessStreamWithContentType*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRandomAccessStreamWithContentType*, TrustLevel*, int>)(lpVtbl[5]))((IRandomAccessStreamWithContentType*)Unsafe.AsPointer(ref this), trustLevel);
        }
    }
}
