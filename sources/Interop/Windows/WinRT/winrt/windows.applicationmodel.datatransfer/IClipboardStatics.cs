// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IClipboardStatics.xml' path='doc/member[@name="IClipboardStatics"]/*' />
[Guid("C627E291-34E2-4963-8EED-93CBB0EA3D70")]
[NativeTypeName("struct IClipboardStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IClipboardStatics : IClipboardStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IClipboardStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, Guid*, void**, int>)(lpVtbl[0]))((IClipboardStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, uint>)(lpVtbl[1]))((IClipboardStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, uint>)(lpVtbl[2]))((IClipboardStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IClipboardStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, HSTRING*, int>)(lpVtbl[4]))((IClipboardStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, TrustLevel*, int>)(lpVtbl[5]))((IClipboardStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IClipboardStatics.xml' path='doc/member[@name="IClipboardStatics.GetContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetContent([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, IDataPackageView**, int>)(lpVtbl[6]))((IClipboardStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IClipboardStatics.xml' path='doc/member[@name="IClipboardStatics.SetContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetContent([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")] IDataPackage* content)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, IDataPackage*, int>)(lpVtbl[7]))((IClipboardStatics*)Unsafe.AsPointer(ref this), content);
    }

    /// <include file='IClipboardStatics.xml' path='doc/member[@name="IClipboardStatics.Flush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, int>)(lpVtbl[8]))((IClipboardStatics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IClipboardStatics.xml' path='doc/member[@name="IClipboardStatics.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, int>)(lpVtbl[9]))((IClipboardStatics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IClipboardStatics.xml' path='doc/member[@name="IClipboardStatics.add_ContentChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ContentChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IClipboardStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IClipboardStatics.xml' path='doc/member[@name="IClipboardStatics.remove_ContentChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ContentChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics*, EventRegistrationToken, int>)(lpVtbl[11]))((IClipboardStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetContent([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** result);

        [VtblIndex(7)]
        HRESULT SetContent([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")] IDataPackage* content);

        [VtblIndex(8)]
        HRESULT Flush();

        [VtblIndex(9)]
        HRESULT Clear();

        [VtblIndex(10)]
        HRESULT add_ContentChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ContentChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackageView**, int> GetContent;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackage*, int> SetContent;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Flush;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ContentChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ContentChanged;
    }
}
