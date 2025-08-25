// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2"]/*' />
[Guid("D646097F-6EF7-5746-8BA8-8FF2206E6F3B")]
[NativeTypeName("struct IGestureRecognizer2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGestureRecognizer2 : IGestureRecognizer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGestureRecognizer2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, Guid*, void**, int>)(lpVtbl[0]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint>)(lpVtbl[1]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint>)(lpVtbl[2]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint*, Guid**, int>)(lpVtbl[3]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, HSTRING*, int>)(lpVtbl[4]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, TrustLevel*, int>)(lpVtbl[5]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.get_TapMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TapMinContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint*, int>)(lpVtbl[6]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.put_TapMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TapMinContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint, int>)(lpVtbl[7]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.get_TapMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TapMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint*, int>)(lpVtbl[8]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.put_TapMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_TapMaxContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint, int>)(lpVtbl[9]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.get_HoldMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HoldMinContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint*, int>)(lpVtbl[10]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.put_HoldMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_HoldMinContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint, int>)(lpVtbl[11]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.get_HoldMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_HoldMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint*, int>)(lpVtbl[12]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.put_HoldMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_HoldMaxContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint, int>)(lpVtbl[13]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.get_HoldRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_HoldRadius(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, float*, int>)(lpVtbl[14]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.put_HoldRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_HoldRadius(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, float, int>)(lpVtbl[15]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.get_HoldStartDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, TimeSpan*, int>)(lpVtbl[16]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.put_HoldStartDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, TimeSpan, int>)(lpVtbl[17]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.get_TranslationMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_TranslationMinContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint*, int>)(lpVtbl[18]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.put_TranslationMinContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_TranslationMinContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint, int>)(lpVtbl[19]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.get_TranslationMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TranslationMaxContactCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint*, int>)(lpVtbl[20]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGestureRecognizer2.xml' path='doc/member[@name="IGestureRecognizer2.put_TranslationMaxContactCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_TranslationMaxContactCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGestureRecognizer2*, uint, int>)(lpVtbl[21]))((IGestureRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TapMinContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_TapMinContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_TapMaxContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_TapMaxContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_HoldMinContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT put_HoldMinContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(12)]
        HRESULT get_HoldMaxContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT put_HoldMaxContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(14)]
        HRESULT get_HoldRadius(float* value);

        [VtblIndex(15)]
        HRESULT put_HoldRadius(float value);

        [VtblIndex(16)]
        HRESULT get_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(17)]
        HRESULT put_HoldStartDelay([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(18)]
        HRESULT get_TranslationMinContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(19)]
        HRESULT put_TranslationMinContactCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(20)]
        HRESULT get_TranslationMaxContactCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(21)]
        HRESULT put_TranslationMaxContactCount([NativeTypeName("UINT32")] uint value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TapMinContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TapMinContactCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TapMaxContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TapMaxContactCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_HoldMinContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_HoldMinContactCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_HoldMaxContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_HoldMaxContactCount;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_HoldRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_HoldRadius;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_HoldStartDelay;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_HoldStartDelay;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TranslationMinContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TranslationMinContactCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TranslationMaxContactCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_TranslationMaxContactCount;
    }
}
