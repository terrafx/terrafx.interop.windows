// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("DCDAA858-895A-4A22-A5EB-67BDA506096D")]
[NativeTypeName("struct IAudioFormatEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioFormatEnumerator : IAudioFormatEnumerator.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, uint>)(lpVtbl[1]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, uint>)(lpVtbl[2]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* count)
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, uint*, int>)(lpVtbl[3]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFormat([NativeTypeName("UINT32")] uint index, WAVEFORMATEX** format)
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, uint, WAVEFORMATEX**, int>)(lpVtbl[4]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), index, format);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount([NativeTypeName("UINT32 *")] uint* count);

        [VtblIndex(4)]
        HRESULT GetFormat([NativeTypeName("UINT32")] uint index, WAVEFORMATEX** format);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioFormatEnumerator*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioFormatEnumerator*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioFormatEnumerator*, uint> Release;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioFormatEnumerator*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT32, WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioFormatEnumerator*, uint, WAVEFORMATEX**, int> GetFormat;
    }
}
