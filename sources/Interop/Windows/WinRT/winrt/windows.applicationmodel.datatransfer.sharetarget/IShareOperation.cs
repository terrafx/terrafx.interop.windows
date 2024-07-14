// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.sharetarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation"]/*' />
[Guid("2246BAB8-D0F8-41C1-A82A-4137DB6504FB")]
[NativeTypeName("struct IShareOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShareOperation : IShareOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShareOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, Guid*, void**, int>)(lpVtbl[0]))((IShareOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, uint>)(lpVtbl[1]))((IShareOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, uint>)(lpVtbl[2]))((IShareOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IShareOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, HSTRING*, int>)(lpVtbl[4]))((IShareOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, TrustLevel*, int>)(lpVtbl[5]))((IShareOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.get_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Data([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, IDataPackageView**, int>)(lpVtbl[6]))((IShareOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.get_QuickLinkId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_QuickLinkId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, HSTRING*, int>)(lpVtbl[7]))((IShareOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.RemoveThisQuickLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveThisQuickLink()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, int>)(lpVtbl[8]))((IShareOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.ReportStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReportStarted()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, int>)(lpVtbl[9]))((IShareOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.ReportDataRetrieved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReportDataRetrieved()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, int>)(lpVtbl[10]))((IShareOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.ReportSubmittedBackgroundTask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReportSubmittedBackgroundTask()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, int>)(lpVtbl[11]))((IShareOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.ReportCompletedWithQuickLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReportCompletedWithQuickLink([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ShareTarget::IQuickLink *")] IQuickLink* quicklink)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, IQuickLink*, int>)(lpVtbl[12]))((IShareOperation*)Unsafe.AsPointer(ref this), quicklink);
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.ReportCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReportCompleted()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, int>)(lpVtbl[13]))((IShareOperation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShareOperation.xml' path='doc/member[@name="IShareOperation.ReportError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReportError(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareOperation*, HSTRING, int>)(lpVtbl[14]))((IShareOperation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Data([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** value);

        [VtblIndex(7)]
        HRESULT get_QuickLinkId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT RemoveThisQuickLink();

        [VtblIndex(9)]
        HRESULT ReportStarted();

        [VtblIndex(10)]
        HRESULT ReportDataRetrieved();

        [VtblIndex(11)]
        HRESULT ReportSubmittedBackgroundTask();

        [VtblIndex(12)]
        HRESULT ReportCompletedWithQuickLink([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ShareTarget::IQuickLink *")] IQuickLink* quicklink);

        [VtblIndex(13)]
        HRESULT ReportCompleted();

        [VtblIndex(14)]
        HRESULT ReportError(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackageView**, int> get_Data;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_QuickLinkId;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveThisQuickLink;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportStarted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportDataRetrieved;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportSubmittedBackgroundTask;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::ShareTarget::IQuickLink *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IQuickLink*, int> ReportCompletedWithQuickLink;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportCompleted;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ReportError;
    }
}
