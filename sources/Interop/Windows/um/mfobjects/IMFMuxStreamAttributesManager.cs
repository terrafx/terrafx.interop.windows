// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CE8BD576-E440-43B3-BE34-1E53F565F7E8")]
    [NativeTypeName("struct IMFMuxStreamAttributesManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMuxStreamAttributesManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, uint>)(lpVtbl[1]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, uint>)(lpVtbl[2]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
        {
            return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, uint*, int>)(lpVtbl[3]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), pdwMuxStreamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAttributes([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFAttributes** ppStreamAttributes)
        {
            return ((delegate* unmanaged<IMFMuxStreamAttributesManager*, uint, IMFAttributes**, int>)(lpVtbl[4]))((IMFMuxStreamAttributesManager*)Unsafe.AsPointer(ref this), dwMuxStreamIndex, ppStreamAttributes);
        }
    }
}
