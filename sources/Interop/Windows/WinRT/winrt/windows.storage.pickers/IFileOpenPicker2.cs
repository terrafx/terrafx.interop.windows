// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileOpenPicker2.xml' path='doc/member[@name="IFileOpenPicker2"]/*' />
[Guid("8CEB6CD2-B446-46F7-B265-90F8E55AD650")]
[NativeTypeName("struct IFileOpenPicker2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileOpenPicker2 : IFileOpenPicker2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileOpenPicker2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, Guid*, void**, int>)(lpVtbl[0]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, uint>)(lpVtbl[1]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, uint>)(lpVtbl[2]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, uint*, Guid**, int>)(lpVtbl[3]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, HSTRING*, int>)(lpVtbl[4]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, TrustLevel*, int>)(lpVtbl[5]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileOpenPicker2.xml' path='doc/member[@name="IFileOpenPicker2.get_ContinuationData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Instead, use PickSingleFileAsync/PickMultipleFilesAsync")]
    public HRESULT get_ContinuationData([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, IPropertySet**, int>)(lpVtbl[6]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker2.xml' path='doc/member[@name="IFileOpenPicker2.PickSingleFileAndContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Instead, use PickSingleFileAsync")]
    public HRESULT PickSingleFileAndContinue()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, int>)(lpVtbl[7]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileOpenPicker2.xml' path='doc/member[@name="IFileOpenPicker2.PickMultipleFilesAndContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Instead, use PickMultipleFilesAsync")]
    public HRESULT PickMultipleFilesAndContinue()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker2*, int>)(lpVtbl[8]))((IFileOpenPicker2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Instead, use PickSingleFileAsync/PickMultipleFilesAsync")]
        HRESULT get_ContinuationData([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);

        [VtblIndex(7)]
        [Obsolete("Instead, use PickSingleFileAsync")]
        HRESULT PickSingleFileAndContinue();

        [VtblIndex(8)]
        [Obsolete("Instead, use PickMultipleFilesAsync")]
        HRESULT PickMultipleFilesAndContinue();
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        [Obsolete("Instead, use PickSingleFileAsync/PickMultipleFilesAsync")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_ContinuationData;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("Instead, use PickSingleFileAsync")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> PickSingleFileAndContinue;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("Instead, use PickMultipleFilesAsync")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> PickMultipleFilesAndContinue;
    }
}
