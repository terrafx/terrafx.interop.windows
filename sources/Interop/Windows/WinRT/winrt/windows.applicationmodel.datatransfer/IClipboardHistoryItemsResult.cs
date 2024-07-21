// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IClipboardHistoryItemsResult.xml' path='doc/member[@name="IClipboardHistoryItemsResult"]/*' />
[Guid("E6DFDEE6-0EE2-52E3-852B-F295DB65939A")]
[NativeTypeName("struct IClipboardHistoryItemsResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IClipboardHistoryItemsResult : IClipboardHistoryItemsResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IClipboardHistoryItemsResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardHistoryItemsResult*, Guid*, void**, int>)(lpVtbl[0]))((IClipboardHistoryItemsResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardHistoryItemsResult*, uint>)(lpVtbl[1]))((IClipboardHistoryItemsResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardHistoryItemsResult*, uint>)(lpVtbl[2]))((IClipboardHistoryItemsResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardHistoryItemsResult*, uint*, Guid**, int>)(lpVtbl[3]))((IClipboardHistoryItemsResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardHistoryItemsResult*, HSTRING*, int>)(lpVtbl[4]))((IClipboardHistoryItemsResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardHistoryItemsResult*, TrustLevel*, int>)(lpVtbl[5]))((IClipboardHistoryItemsResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IClipboardHistoryItemsResult.xml' path='doc/member[@name="IClipboardHistoryItemsResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ClipboardHistoryItemsResultStatus *")] ClipboardHistoryItemsResultStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardHistoryItemsResult*, ClipboardHistoryItemsResultStatus*, int>)(lpVtbl[6]))((IClipboardHistoryItemsResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IClipboardHistoryItemsResult.xml' path='doc/member[@name="IClipboardHistoryItemsResult.get_Items"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Items([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItem_t **")] IVectorView<Pointer<IClipboardHistoryItem>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardHistoryItemsResult*, IVectorView<Pointer<IClipboardHistoryItem>>**, int>)(lpVtbl[7]))((IClipboardHistoryItemsResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ClipboardHistoryItemsResultStatus *")] ClipboardHistoryItemsResultStatus* value);

        [VtblIndex(7)]
        HRESULT get_Items([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItem_t **")] IVectorView<Pointer<IClipboardHistoryItem>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::ClipboardHistoryItemsResultStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ClipboardHistoryItemsResultStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IClipboardHistoryItem>>**, int> get_Items;
    }
}
