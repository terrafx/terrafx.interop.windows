// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Windows.Graphics.Capture.Interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWindowGraphicsCaptureItemInterop.xml' path='doc/member[@name="IWindowGraphicsCaptureItemInterop"]/*' />
[Guid("38E4C48B-94E6-4C44-9CFA-968193316C0C")]
[NativeTypeName("struct IWindowGraphicsCaptureItemInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWindowGraphicsCaptureItemInterop : IWindowGraphicsCaptureItemInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWindowGraphicsCaptureItemInterop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowGraphicsCaptureItemInterop*, Guid*, void**, int>)(lpVtbl[0]))((IWindowGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowGraphicsCaptureItemInterop*, uint>)(lpVtbl[1]))((IWindowGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowGraphicsCaptureItemInterop*, uint>)(lpVtbl[2]))((IWindowGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWindowGraphicsCaptureItemInterop.xml' path='doc/member[@name="IWindowGraphicsCaptureItemInterop.GetWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* window)
    {
        return ((delegate* unmanaged[MemberFunction]<IWindowGraphicsCaptureItemInterop*, HWND*, int>)(lpVtbl[3]))((IWindowGraphicsCaptureItemInterop*)Unsafe.AsPointer(ref this), window);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWindow(HWND* window);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HWND *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND*, int> GetWindow;
    }
}
