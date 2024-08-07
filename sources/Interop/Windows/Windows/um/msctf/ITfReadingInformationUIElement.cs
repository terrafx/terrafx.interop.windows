// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITfReadingInformationUIElement.xml' path='doc/member[@name="ITfReadingInformationUIElement"]/*' />
[Guid("EA1EA139-19DF-11D7-A6D2-00065B84435C")]
[NativeTypeName("struct ITfReadingInformationUIElement : ITfUIElement")]
[NativeInheritance("ITfUIElement")]
public unsafe partial struct ITfReadingInformationUIElement : ITfReadingInformationUIElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfReadingInformationUIElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, uint>)(lpVtbl[1]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, uint>)(lpVtbl[2]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfUIElement.GetDescription" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] char** pbstrDescription)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, char**, int>)(lpVtbl[3]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
    }

    /// <inheritdoc cref="ITfUIElement.GetGUID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, Guid*, int>)(lpVtbl[4]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <inheritdoc cref="ITfUIElement.Show" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, BOOL, int>)(lpVtbl[5]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), bShow);
    }

    /// <inheritdoc cref="ITfUIElement.IsShown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, BOOL*, int>)(lpVtbl[6]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pbShow);
    }

    /// <include file='ITfReadingInformationUIElement.xml' path='doc/member[@name="ITfReadingInformationUIElement.GetUpdatedFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[7]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    /// <include file='ITfReadingInformationUIElement.xml' path='doc/member[@name="ITfReadingInformationUIElement.GetContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetContext(ITfContext** ppic)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, ITfContext**, int>)(lpVtbl[8]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), ppic);
    }

    /// <include file='ITfReadingInformationUIElement.xml' path='doc/member[@name="ITfReadingInformationUIElement.GetString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetString([NativeTypeName("BSTR *")] char** pstr)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, char**, int>)(lpVtbl[9]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pstr);
    }

    /// <include file='ITfReadingInformationUIElement.xml' path='doc/member[@name="ITfReadingInformationUIElement.GetMaxReadingStringLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetMaxReadingStringLength(uint* pcchMax)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[10]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pcchMax);
    }

    /// <include file='ITfReadingInformationUIElement.xml' path='doc/member[@name="ITfReadingInformationUIElement.GetErrorIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetErrorIndex(uint* pErrorIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[11]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pErrorIndex);
    }

    /// <include file='ITfReadingInformationUIElement.xml' path='doc/member[@name="ITfReadingInformationUIElement.IsVerticalOrderPreferred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsVerticalOrderPreferred(BOOL* pfVertical)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfReadingInformationUIElement*, BOOL*, int>)(lpVtbl[12]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pfVertical);
    }

    public interface Interface : ITfUIElement.Interface
    {
        [VtblIndex(7)]
        HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(8)]
        HRESULT GetContext(ITfContext** ppic);

        [VtblIndex(9)]
        HRESULT GetString([NativeTypeName("BSTR *")] char** pstr);

        [VtblIndex(10)]
        HRESULT GetMaxReadingStringLength(uint* pcchMax);

        [VtblIndex(11)]
        HRESULT GetErrorIndex(uint* pErrorIndex);

        [VtblIndex(12)]
        HRESULT IsVerticalOrderPreferred(BOOL* pfVertical);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetDescription;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> Show;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> IsShown;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetUpdatedFlags;

        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITfContext**, int> GetContext;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetString;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetMaxReadingStringLength;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetErrorIndex;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> IsVerticalOrderPreferred;
    }
}
