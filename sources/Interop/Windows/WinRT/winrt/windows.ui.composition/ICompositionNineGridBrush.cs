// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush"]/*' />
[Guid("F25154E4-BC8C-4BE7-B80F-8685B83C0186")]
[NativeTypeName("struct ICompositionNineGridBrush : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionNineGridBrush : ICompositionNineGridBrush.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICompositionNineGridBrush);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, uint>)(lpVtbl[1]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, uint>)(lpVtbl[2]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, HSTRING*, int>)(lpVtbl[4]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_BottomInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BottomInset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float*, int>)(lpVtbl[6]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_BottomInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BottomInset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[7]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_BottomInsetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BottomInsetScale(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float*, int>)(lpVtbl[8]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_BottomInsetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BottomInsetScale(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[9]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_IsCenterHollow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsCenterHollow([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, byte*, int>)(lpVtbl[10]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_IsCenterHollow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsCenterHollow([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, byte, int>)(lpVtbl[11]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_LeftInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LeftInset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float*, int>)(lpVtbl[12]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_LeftInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_LeftInset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[13]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_LeftInsetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LeftInsetScale(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float*, int>)(lpVtbl[14]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_LeftInsetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_LeftInsetScale(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[15]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_RightInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RightInset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float*, int>)(lpVtbl[16]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_RightInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_RightInset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[17]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_RightInsetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RightInsetScale(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float*, int>)(lpVtbl[18]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_RightInsetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_RightInsetScale(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[19]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")] ICompositionBrush** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, ICompositionBrush**, int>)(lpVtbl[20]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Source([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")] ICompositionBrush* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, ICompositionBrush*, int>)(lpVtbl[21]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_TopInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_TopInset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float*, int>)(lpVtbl[22]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_TopInset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_TopInset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[23]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.get_TopInsetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_TopInsetScale(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float*, int>)(lpVtbl[24]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.put_TopInsetScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_TopInsetScale(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[25]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.SetInsets"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetInsets(float inset)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[26]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), inset);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.SetInsetsWithValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetInsetsWithValues(float left, float top, float right, float bottom)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, float, float, float, int>)(lpVtbl[27]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), left, top, right, bottom);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.SetInsetScales"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetInsetScales(float scale)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, int>)(lpVtbl[28]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), scale);
    }

    /// <include file='ICompositionNineGridBrush.xml' path='doc/member[@name="ICompositionNineGridBrush.SetInsetScalesWithValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetInsetScalesWithValues(float left, float top, float right, float bottom)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionNineGridBrush*, float, float, float, float, int>)(lpVtbl[29]))((ICompositionNineGridBrush*)Unsafe.AsPointer(ref this), left, top, right, bottom);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BottomInset(float* value);

        [VtblIndex(7)]
        HRESULT put_BottomInset(float value);

        [VtblIndex(8)]
        HRESULT get_BottomInsetScale(float* value);

        [VtblIndex(9)]
        HRESULT put_BottomInsetScale(float value);

        [VtblIndex(10)]
        HRESULT get_IsCenterHollow([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsCenterHollow([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_LeftInset(float* value);

        [VtblIndex(13)]
        HRESULT put_LeftInset(float value);

        [VtblIndex(14)]
        HRESULT get_LeftInsetScale(float* value);

        [VtblIndex(15)]
        HRESULT put_LeftInsetScale(float value);

        [VtblIndex(16)]
        HRESULT get_RightInset(float* value);

        [VtblIndex(17)]
        HRESULT put_RightInset(float value);

        [VtblIndex(18)]
        HRESULT get_RightInsetScale(float* value);

        [VtblIndex(19)]
        HRESULT put_RightInsetScale(float value);

        [VtblIndex(20)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")] ICompositionBrush** value);

        [VtblIndex(21)]
        HRESULT put_Source([NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")] ICompositionBrush* value);

        [VtblIndex(22)]
        HRESULT get_TopInset(float* value);

        [VtblIndex(23)]
        HRESULT put_TopInset(float value);

        [VtblIndex(24)]
        HRESULT get_TopInsetScale(float* value);

        [VtblIndex(25)]
        HRESULT put_TopInsetScale(float value);

        [VtblIndex(26)]
        HRESULT SetInsets(float inset);

        [VtblIndex(27)]
        HRESULT SetInsetsWithValues(float left, float top, float right, float bottom);

        [VtblIndex(28)]
        HRESULT SetInsetScales(float scale);

        [VtblIndex(29)]
        HRESULT SetInsetScalesWithValues(float left, float top, float right, float bottom);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_BottomInsetScale;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_BottomInsetScale;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCenterHollow;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsCenterHollow;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LeftInset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_LeftInset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_LeftInsetScale;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_LeftInsetScale;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RightInset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RightInset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_RightInsetScale;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_RightInsetScale;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionBrush **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionBrush**, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionBrush *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionBrush*, int> put_Source;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_TopInset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_TopInset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_TopInsetScale;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_TopInsetScale;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetInsets;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, float, int> SetInsetsWithValues;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetInsetScales;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, float, int> SetInsetScalesWithValues;
    }
}
