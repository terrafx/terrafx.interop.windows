// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallBlockingStatics.xml' path='doc/member[@name="IPhoneCallBlockingStatics"]/*' />
[Guid("19646F84-2B79-26F1-A46F-694BE043F313")]
[NativeTypeName("struct IPhoneCallBlockingStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallBlockingStatics : IPhoneCallBlockingStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallBlockingStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, uint>)(lpVtbl[1]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, uint>)(lpVtbl[2]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallBlockingStatics.xml' path='doc/member[@name="IPhoneCallBlockingStatics.get_BlockUnknownNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BlockUnknownNumbers([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, byte*, int>)(lpVtbl[6]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallBlockingStatics.xml' path='doc/member[@name="IPhoneCallBlockingStatics.put_BlockUnknownNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BlockUnknownNumbers([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, byte, int>)(lpVtbl[7]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallBlockingStatics.xml' path='doc/member[@name="IPhoneCallBlockingStatics.get_BlockPrivateNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BlockPrivateNumbers([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, byte*, int>)(lpVtbl[8]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallBlockingStatics.xml' path='doc/member[@name="IPhoneCallBlockingStatics.put_BlockPrivateNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BlockPrivateNumbers([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, byte, int>)(lpVtbl[9]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallBlockingStatics.xml' path='doc/member[@name="IPhoneCallBlockingStatics.SetCallBlockingListAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCallBlockingListAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* phoneNumberList, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallBlockingStatics*, IIterable<HSTRING>*, IAsyncOperation<bool>**, int>)(lpVtbl[10]))((IPhoneCallBlockingStatics*)Unsafe.AsPointer(ref this), phoneNumberList, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BlockUnknownNumbers([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_BlockUnknownNumbers([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_BlockPrivateNumbers([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_BlockPrivateNumbers([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT SetCallBlockingListAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* phoneNumberList, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_BlockUnknownNumbers;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_BlockUnknownNumbers;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_BlockPrivateNumbers;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_BlockPrivateNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IAsyncOperation<bool>**, int> SetCallBlockingListAsync;
    }
}
