// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLPainterEventInfo.xml' path='doc/member[@name="IHTMLPainterEventInfo"]/*' />
[Guid("3050F6DF-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLPainterEventInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLPainterEventInfo : IHTMLPainterEventInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHTMLPainterEventInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLPainterEventInfo*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLPainterEventInfo*, uint>)(lpVtbl[1]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLPainterEventInfo*, uint>)(lpVtbl[2]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLPainterEventInfo.xml' path='doc/member[@name="IHTMLPainterEventInfo.GetEventInfoFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEventInfoFlags([NativeTypeName("long *")] int* plEventInfoFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLPainterEventInfo*, int*, int>)(lpVtbl[3]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), plEventInfoFlags);
    }

    /// <include file='IHTMLPainterEventInfo.xml' path='doc/member[@name="IHTMLPainterEventInfo.GetEventTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEventTarget(IHTMLElement** ppElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLPainterEventInfo*, IHTMLElement**, int>)(lpVtbl[4]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), ppElement);
    }

    /// <include file='IHTMLPainterEventInfo.xml' path='doc/member[@name="IHTMLPainterEventInfo.SetCursor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetCursor([NativeTypeName("LONG")] int lPartID)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLPainterEventInfo*, int, int>)(lpVtbl[5]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), lPartID);
    }

    /// <include file='IHTMLPainterEventInfo.xml' path='doc/member[@name="IHTMLPainterEventInfo.StringFromPartID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StringFromPartID([NativeTypeName("LONG")] int lPartID, [NativeTypeName("BSTR *")] char** pbstrPart)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLPainterEventInfo*, int, char**, int>)(lpVtbl[6]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), lPartID, pbstrPart);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEventInfoFlags([NativeTypeName("long *")] int* plEventInfoFlags);

        [VtblIndex(4)]
        HRESULT GetEventTarget(IHTMLElement** ppElement);

        [VtblIndex(5)]
        HRESULT SetCursor([NativeTypeName("LONG")] int lPartID);

        [VtblIndex(6)]
        HRESULT StringFromPartID([NativeTypeName("LONG")] int lPartID, [NativeTypeName("BSTR *")] char** pbstrPart);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetEventInfoFlags;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHTMLElement**, int> GetEventTarget;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> SetCursor;

        [NativeTypeName("HRESULT (LONG, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char**, int> StringFromPartID;
    }
}
