// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBitmapBuffer.xml' path='doc/member[@name="IBitmapBuffer"]/*' />
[Guid("A53E04C4-399C-438C-B28F-A63A6B83D1A1")]
[NativeTypeName("struct IBitmapBuffer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapBuffer : IBitmapBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapBuffer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapBuffer*, uint>)(lpVtbl[1]))((IBitmapBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapBuffer*, uint>)(lpVtbl[2]))((IBitmapBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapBuffer*, uint*, Guid**, int>)(lpVtbl[3]))((IBitmapBuffer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapBuffer*, HSTRING*, int>)(lpVtbl[4]))((IBitmapBuffer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapBuffer*, TrustLevel*, int>)(lpVtbl[5]))((IBitmapBuffer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBitmapBuffer.xml' path='doc/member[@name="IBitmapBuffer.GetPlaneCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPlaneCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapBuffer*, int*, int>)(lpVtbl[6]))((IBitmapBuffer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapBuffer.xml' path='doc/member[@name="IBitmapBuffer.GetPlaneDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPlaneDescription([NativeTypeName("INT32")] int index, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPlaneDescription *")] BitmapPlaneDescription* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapBuffer*, int, BitmapPlaneDescription*, int>)(lpVtbl[7]))((IBitmapBuffer*)Unsafe.AsPointer(ref this), index, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPlaneCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT GetPlaneDescription([NativeTypeName("INT32")] int index, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPlaneDescription *")] BitmapPlaneDescription* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetPlaneCount;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Graphics::Imaging::BitmapPlaneDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, BitmapPlaneDescription*, int> GetPlaneDescription;
    }
}
