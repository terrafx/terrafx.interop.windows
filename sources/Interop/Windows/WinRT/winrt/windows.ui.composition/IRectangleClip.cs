// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip"]/*' />
[Guid("B3E7549E-00B4-5B53-8BE8-353F6C433101")]
[NativeTypeName("struct IRectangleClip : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRectangleClip : IRectangleClip.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRectangleClip);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Guid*, void**, int>)(lpVtbl[0]))((IRectangleClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, uint>)(lpVtbl[1]))((IRectangleClip*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, uint>)(lpVtbl[2]))((IRectangleClip*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, uint*, Guid**, int>)(lpVtbl[3]))((IRectangleClip*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, HSTRING*, int>)(lpVtbl[4]))((IRectangleClip*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, TrustLevel*, int>)(lpVtbl[5]))((IRectangleClip*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.get_Bottom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Bottom(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, float*, int>)(lpVtbl[6]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.put_Bottom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Bottom(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, float, int>)(lpVtbl[7]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.get_BottomLeftRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BottomLeftRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Vector2*, int>)(lpVtbl[8]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.put_BottomLeftRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BottomLeftRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Vector2, int>)(lpVtbl[9]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.get_BottomRightRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BottomRightRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Vector2*, int>)(lpVtbl[10]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.put_BottomRightRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BottomRightRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Vector2, int>)(lpVtbl[11]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.get_Left"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Left(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, float*, int>)(lpVtbl[12]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.put_Left"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Left(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, float, int>)(lpVtbl[13]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.get_Right"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Right(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, float*, int>)(lpVtbl[14]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.put_Right"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Right(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, float, int>)(lpVtbl[15]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.get_Top"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Top(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, float*, int>)(lpVtbl[16]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.put_Top"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Top(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, float, int>)(lpVtbl[17]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.get_TopLeftRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_TopLeftRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Vector2*, int>)(lpVtbl[18]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.put_TopLeftRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_TopLeftRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Vector2, int>)(lpVtbl[19]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.get_TopRightRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TopRightRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Vector2*, int>)(lpVtbl[20]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRectangleClip.xml' path='doc/member[@name="IRectangleClip.put_TopRightRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_TopRightRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRectangleClip*, Vector2, int>)(lpVtbl[21]))((IRectangleClip*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Bottom(float* value);

        [VtblIndex(7)]
        HRESULT put_Bottom(float value);

        [VtblIndex(8)]
        HRESULT get_BottomLeftRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(9)]
        HRESULT put_BottomLeftRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(10)]
        HRESULT get_BottomRightRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(11)]
        HRESULT put_BottomRightRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(12)]
        HRESULT get_Left(float* value);

        [VtblIndex(13)]
        HRESULT put_Left(float value);

        [VtblIndex(14)]
        HRESULT get_Right(float* value);

        [VtblIndex(15)]
        HRESULT put_Right(float value);

        [VtblIndex(16)]
        HRESULT get_Top(float* value);

        [VtblIndex(17)]
        HRESULT put_Top(float value);

        [VtblIndex(18)]
        HRESULT get_TopLeftRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(19)]
        HRESULT put_TopLeftRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(20)]
        HRESULT get_TopRightRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value);

        [VtblIndex(21)]
        HRESULT put_TopRightRadius([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Bottom;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Bottom;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_BottomLeftRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_BottomLeftRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_BottomRightRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_BottomRightRadius;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Left;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Left;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Right;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Right;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Top;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_Top;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_TopLeftRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_TopLeftRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2*, int> get_TopRightRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector2, int> put_TopRightRadius;
    }
}
