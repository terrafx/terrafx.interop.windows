// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip"]/*' />
[Guid("1E73E647-84C7-477A-B474-5880E0442E15")]
[NativeTypeName("struct IInsetClip : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInsetClip : IInsetClip.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IInsetClip);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, Guid*, void**, int>)(lpVtbl[0]))((IInsetClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, uint>)(lpVtbl[1]))((IInsetClip*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, uint>)(lpVtbl[2]))((IInsetClip*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, uint*, Guid**, int>)(lpVtbl[3]))((IInsetClip*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, HSTRING*, int>)(lpVtbl[4]))((IInsetClip*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, TrustLevel*, int>)(lpVtbl[5]))((IInsetClip*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip.get_BottomInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BottomInset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, float*, int>)(lpVtbl[6]))((IInsetClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip.put_BottomInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BottomInset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, float, int>)(lpVtbl[7]))((IInsetClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip.get_LeftInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LeftInset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, float*, int>)(lpVtbl[8]))((IInsetClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip.put_LeftInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_LeftInset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, float, int>)(lpVtbl[9]))((IInsetClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip.get_RightInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RightInset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, float*, int>)(lpVtbl[10]))((IInsetClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip.put_RightInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RightInset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, float, int>)(lpVtbl[11]))((IInsetClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip.get_TopInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_TopInset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, float*, int>)(lpVtbl[12]))((IInsetClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInsetClip.xml' path='doc/member[@name="IInsetClip.put_TopInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_TopInset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInsetClip*, float, int>)(lpVtbl[13]))((IInsetClip*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BottomInset(float* value);

        [VtblIndex(7)]
        HRESULT put_BottomInset(float value);

        [VtblIndex(8)]
        HRESULT get_LeftInset(float* value);

        [VtblIndex(9)]
        HRESULT put_LeftInset(float value);

        [VtblIndex(10)]
        HRESULT get_RightInset(float* value);

        [VtblIndex(11)]
        HRESULT put_RightInset(float value);

        [VtblIndex(12)]
        HRESULT get_TopInset(float* value);

        [VtblIndex(13)]
        HRESULT put_TopInset(float value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_BottomInset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_BottomInset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LeftInset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_LeftInset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RightInset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RightInset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_TopInset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_TopInset;
    }
}
