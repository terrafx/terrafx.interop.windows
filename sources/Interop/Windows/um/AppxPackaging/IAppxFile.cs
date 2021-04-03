// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("91DF827B-94FD-468F-827B-57F41B2F6F2E")]
    [NativeTypeName("struct IAppxFile : IUnknown")]
    public unsafe partial struct IAppxFile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxFile*, Guid*, void**, int>)(lpVtbl[0]))((IAppxFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxFile*, uint>)(lpVtbl[1]))((IAppxFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxFile*, uint>)(lpVtbl[2]))((IAppxFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCompressionOption(APPX_COMPRESSION_OPTION* compressionOption)
        {
            return ((delegate* unmanaged<IAppxFile*, APPX_COMPRESSION_OPTION*, int>)(lpVtbl[3]))((IAppxFile*)Unsafe.AsPointer(ref this), compressionOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContentType([NativeTypeName("LPWSTR *")] ushort** contentType)
        {
            return ((delegate* unmanaged<IAppxFile*, ushort**, int>)(lpVtbl[4]))((IAppxFile*)Unsafe.AsPointer(ref this), contentType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** fileName)
        {
            return ((delegate* unmanaged<IAppxFile*, ushort**, int>)(lpVtbl[5]))((IAppxFile*)Unsafe.AsPointer(ref this), fileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT64 *")] ulong* size)
        {
            return ((delegate* unmanaged<IAppxFile*, ulong*, int>)(lpVtbl[6]))((IAppxFile*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStream(IStream** stream)
        {
            return ((delegate* unmanaged<IAppxFile*, IStream**, int>)(lpVtbl[7]))((IAppxFile*)Unsafe.AsPointer(ref this), stream);
        }
    }
}
