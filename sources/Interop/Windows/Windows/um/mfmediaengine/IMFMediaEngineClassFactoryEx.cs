// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.1")]
[Guid("C56156C6-EA5B-48A5-9DF8-FBE035D0929E")]
[NativeTypeName("struct IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory")]
[NativeInheritance("IMFMediaEngineClassFactory")]
public unsafe partial struct IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactoryEx.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint>)(lpVtbl[1]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint>)(lpVtbl[2]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)(lpVtbl[3]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppPlayer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateTimeRange(IMFMediaTimeRange** ppTimeRange)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, IMFMediaTimeRange**, int>)(lpVtbl[4]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), ppTimeRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateError(IMFMediaError** ppError)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, IMFMediaError**, int>)(lpVtbl[5]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), ppError);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateMediaSourceExtension([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSourceExtension** ppMSE)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)(lpVtbl[6]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppMSE);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMediaKeys([NativeTypeName("BSTR")] ushort* keySystem, [NativeTypeName("BSTR")] ushort* cdmStorePath, IMFMediaKeys** ppKeys)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, ushort*, ushort*, IMFMediaKeys**, int>)(lpVtbl[7]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), keySystem, cdmStorePath, ppKeys);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsTypeSupported([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR")] ushort* keySystem, BOOL* isSupported)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, ushort*, ushort*, BOOL*, int>)(lpVtbl[8]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), type, keySystem, isSupported);
    }

    public interface Interface : IMFMediaEngineClassFactory.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateMediaSourceExtension([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSourceExtension** ppMSE);

        [VtblIndex(7)]
        HRESULT CreateMediaKeys([NativeTypeName("BSTR")] ushort* keySystem, [NativeTypeName("BSTR")] ushort* cdmStorePath, IMFMediaKeys** ppKeys);

        [VtblIndex(8)]
        HRESULT IsTypeSupported([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR")] ushort* keySystem, BOOL* isSupported);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, IMFAttributes *, IMFMediaEngine **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int> CreateInstance;

        [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, IMFMediaTimeRange**, int> CreateTimeRange;

        [NativeTypeName("HRESULT (IMFMediaError **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, IMFMediaError**, int> CreateError;

        [NativeTypeName("HRESULT (DWORD, IMFAttributes *, IMFMediaSourceExtension **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int> CreateMediaSourceExtension;

        [NativeTypeName("HRESULT (BSTR, BSTR, IMFMediaKeys **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, ushort*, ushort*, IMFMediaKeys**, int> CreateMediaKeys;

        [NativeTypeName("HRESULT (BSTR, BSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEngineClassFactoryEx*, ushort*, ushort*, BOOL*, int> IsTypeSupported;
    }
}
