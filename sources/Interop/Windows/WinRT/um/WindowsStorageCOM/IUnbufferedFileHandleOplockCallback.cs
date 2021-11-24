// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[SupportedOSPlatform("windows10.0")]
[Guid("D1019A0E-6243-4329-8497-2E75894D7710")]
[NativeTypeName("struct IUnbufferedFileHandleOplockCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUnbufferedFileHandleOplockCallback : IUnbufferedFileHandleOplockCallback.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, Guid*, void**, int>)(lpVtbl[0]))((IUnbufferedFileHandleOplockCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, uint>)(lpVtbl[1]))((IUnbufferedFileHandleOplockCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, uint>)(lpVtbl[2]))((IUnbufferedFileHandleOplockCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnBrokenCallback()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, int>)(lpVtbl[3]))((IUnbufferedFileHandleOplockCallback*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnBrokenCallback();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, uint> Release;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleOplockCallback*, int> OnBrokenCallback;
    }
}
