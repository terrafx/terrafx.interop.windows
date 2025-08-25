// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISelectionServicesListener.xml' path='doc/member[@name="ISelectionServicesListener"]/*' />
[Guid("3050F699-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISelectionServicesListener : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISelectionServicesListener : ISelectionServicesListener.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISelectionServicesListener);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectionServicesListener*, Guid*, void**, int>)(lpVtbl[0]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectionServicesListener*, uint>)(lpVtbl[1]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectionServicesListener*, uint>)(lpVtbl[2]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISelectionServicesListener.xml' path='doc/member[@name="ISelectionServicesListener.BeginSelectionUndo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginSelectionUndo()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectionServicesListener*, int>)(lpVtbl[3]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISelectionServicesListener.xml' path='doc/member[@name="ISelectionServicesListener.EndSelectionUndo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndSelectionUndo()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectionServicesListener*, int>)(lpVtbl[4]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISelectionServicesListener.xml' path='doc/member[@name="ISelectionServicesListener.OnSelectedElementExit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnSelectedElementExit(IMarkupPointer* pIElementStart, IMarkupPointer* pIElementEnd, IMarkupPointer* pIElementContentStart, IMarkupPointer* pIElementContentEnd)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectionServicesListener*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[5]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this), pIElementStart, pIElementEnd, pIElementContentStart, pIElementContentEnd);
    }

    /// <include file='ISelectionServicesListener.xml' path='doc/member[@name="ISelectionServicesListener.OnChangeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnChangeType(SELECTION_TYPE eType, ISelectionServicesListener* pIListener)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectionServicesListener*, SELECTION_TYPE, ISelectionServicesListener*, int>)(lpVtbl[6]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this), eType, pIListener);
    }

    /// <include file='ISelectionServicesListener.xml' path='doc/member[@name="ISelectionServicesListener.GetTypeDetail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTypeDetail([NativeTypeName("BSTR *")] char** pTypeDetail)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectionServicesListener*, char**, int>)(lpVtbl[7]))((ISelectionServicesListener*)Unsafe.AsPointer(ref this), pTypeDetail);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginSelectionUndo();

        [VtblIndex(4)]
        HRESULT EndSelectionUndo();

        [VtblIndex(5)]
        HRESULT OnSelectedElementExit(IMarkupPointer* pIElementStart, IMarkupPointer* pIElementEnd, IMarkupPointer* pIElementContentStart, IMarkupPointer* pIElementContentEnd);

        [VtblIndex(6)]
        HRESULT OnChangeType(SELECTION_TYPE eType, ISelectionServicesListener* pIListener);

        [VtblIndex(7)]
        HRESULT GetTypeDetail([NativeTypeName("BSTR *")] char** pTypeDetail);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> BeginSelectionUndo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> EndSelectionUndo;

        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *, IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, IMarkupPointer*, int> OnSelectedElementExit;

        [NativeTypeName("HRESULT (SELECTION_TYPE, ISelectionServicesListener *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SELECTION_TYPE, ISelectionServicesListener*, int> OnChangeType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetTypeDetail;
    }
}
