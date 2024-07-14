// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackage5.xml' path='doc/member[@name="IPackage5"]/*' />
[Guid("0E842DD4-D9AC-45ED-9A1E-74CE056B2635")]
[NativeTypeName("struct IPackage5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackage5 : IPackage5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackage5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, Guid*, void**, int>)(lpVtbl[0]))((IPackage5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, uint>)(lpVtbl[1]))((IPackage5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, uint>)(lpVtbl[2]))((IPackage5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, uint*, Guid**, int>)(lpVtbl[3]))((IPackage5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, HSTRING*, int>)(lpVtbl[4]))((IPackage5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, TrustLevel*, int>)(lpVtbl[5]))((IPackage5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackage5.xml' path='doc/member[@name="IPackage5.GetContentGroupsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetContentGroupsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **")] IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>**, int>)(lpVtbl[6]))((IPackage5*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPackage5.xml' path='doc/member[@name="IPackage5.GetContentGroupAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetContentGroupAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageContentGroup_t **")] IAsyncOperation<Pointer<IPackageContentGroup>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, HSTRING, IAsyncOperation<Pointer<IPackageContentGroup>>**, int>)(lpVtbl[7]))((IPackage5*)Unsafe.AsPointer(ref this), name, operation);
    }

    /// <include file='IPackage5.xml' path='doc/member[@name="IPackage5.StageContentGroupsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StageContentGroupsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* names, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **")] IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, IIterable<HSTRING>*, IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>**, int>)(lpVtbl[8]))((IPackage5*)Unsafe.AsPointer(ref this), names, operation);
    }

    /// <include file='IPackage5.xml' path='doc/member[@name="IPackage5.StageContentGroupsWithPriorityAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StageContentGroupsWithPriorityAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* names, [NativeTypeName("boolean")] byte moveToHeadOfQueue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **")] IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, IIterable<HSTRING>*, byte, IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>**, int>)(lpVtbl[9]))((IPackage5*)Unsafe.AsPointer(ref this), names, moveToHeadOfQueue, operation);
    }

    /// <include file='IPackage5.xml' path='doc/member[@name="IPackage5.SetInUseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetInUseAsync([NativeTypeName("boolean")] byte inUse, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackage5*, byte, IAsyncOperation<bool>**, int>)(lpVtbl[10]))((IPackage5*)Unsafe.AsPointer(ref this), inUse, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetContentGroupsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **")] IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>** operation);

        [VtblIndex(7)]
        HRESULT GetContentGroupAsync(HSTRING name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageContentGroup_t **")] IAsyncOperation<Pointer<IPackageContentGroup>>** operation);

        [VtblIndex(8)]
        HRESULT StageContentGroupsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* names, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **")] IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>** operation);

        [VtblIndex(9)]
        HRESULT StageContentGroupsWithPriorityAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* names, [NativeTypeName("boolean")] byte moveToHeadOfQueue, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **")] IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>** operation);

        [VtblIndex(10)]
        HRESULT SetInUseAsync([NativeTypeName("boolean")] byte inUse, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>**, int> GetContentGroupsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageContentGroup_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IPackageContentGroup>>**, int> GetContentGroupAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>**, int> StageContentGroupsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, boolean, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CApplicationModel__CPackageContentGroup_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, byte, IAsyncOperation<Pointer<IVector<Pointer<IPackageContentGroup>>>>**, int> StageContentGroupsWithPriorityAsync;

        [NativeTypeName("HRESULT (boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, IAsyncOperation<bool>**, int> SetInUseAsync;
    }
}
