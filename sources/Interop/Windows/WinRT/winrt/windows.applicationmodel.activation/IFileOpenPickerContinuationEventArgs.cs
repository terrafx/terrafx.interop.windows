// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileOpenPickerContinuationEventArgs.xml' path='doc/member[@name="IFileOpenPickerContinuationEventArgs"]/*' />
[Guid("F0FA3F3A-D4E8-4AD3-9C34-2308F32FCEC9")]
[NativeTypeName("struct IFileOpenPickerContinuationEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IFileOpenPickerContinuationEventArgs : IFileOpenPickerContinuationEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFileOpenPickerContinuationEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerContinuationEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IFileOpenPickerContinuationEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerContinuationEventArgs*, uint>)(lpVtbl[1]))((IFileOpenPickerContinuationEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerContinuationEventArgs*, uint>)(lpVtbl[2]))((IFileOpenPickerContinuationEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerContinuationEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IFileOpenPickerContinuationEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerContinuationEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IFileOpenPickerContinuationEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerContinuationEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IFileOpenPickerContinuationEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileOpenPickerContinuationEventArgs.xml' path='doc/member[@name="IFileOpenPickerContinuationEventArgs.get_Files"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT get_Files([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IVectorView<Pointer<IStorageFile>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerContinuationEventArgs*, IVectorView<Pointer<IStorageFile>>**, int>)(lpVtbl[6]))((IFileOpenPickerContinuationEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT get_Files([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IVectorView<Pointer<IStorageFile>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        [Obsolete("IFileOpenPickerContinuationEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IStorageFile>>**, int> get_Files;
    }
}
