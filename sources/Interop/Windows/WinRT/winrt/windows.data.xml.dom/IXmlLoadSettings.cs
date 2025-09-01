// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings"]/*' />
[Guid("58AA07A8-FED6-46F7-B4C5-FB1BA72108D6")]
[NativeTypeName("struct IXmlLoadSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlLoadSettings : IXmlLoadSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IXmlLoadSettings);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, Guid*, void**, int>)(lpVtbl[0]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, uint>)(lpVtbl[1]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, uint>)(lpVtbl[2]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, HSTRING*, int>)(lpVtbl[4]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, TrustLevel*, int>)(lpVtbl[5]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.get_MaxElementDepth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxElementDepth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, uint*, int>)(lpVtbl[6]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.put_MaxElementDepth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MaxElementDepth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, uint, int>)(lpVtbl[7]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.get_ProhibitDtd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProhibitDtd([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, byte*, int>)(lpVtbl[8]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.put_ProhibitDtd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ProhibitDtd([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, byte, int>)(lpVtbl[9]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.get_ResolveExternals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ResolveExternals([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, byte*, int>)(lpVtbl[10]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.put_ResolveExternals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ResolveExternals([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, byte, int>)(lpVtbl[11]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.get_ValidateOnParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ValidateOnParse([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, byte*, int>)(lpVtbl[12]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.put_ValidateOnParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ValidateOnParse([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, byte, int>)(lpVtbl[13]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.get_ElementContentWhiteSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ElementContentWhiteSpace([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, byte*, int>)(lpVtbl[14]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlLoadSettings.xml' path='doc/member[@name="IXmlLoadSettings.put_ElementContentWhiteSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ElementContentWhiteSpace([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlLoadSettings*, byte, int>)(lpVtbl[15]))((IXmlLoadSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxElementDepth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_MaxElementDepth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_ProhibitDtd([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_ProhibitDtd([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_ResolveExternals([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_ResolveExternals([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_ValidateOnParse([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_ValidateOnParse([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_ElementContentWhiteSpace([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_ElementContentWhiteSpace([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxElementDepth;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_MaxElementDepth;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ProhibitDtd;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ProhibitDtd;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ResolveExternals;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ResolveExternals;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ValidateOnParse;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ValidateOnParse;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ElementContentWhiteSpace;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ElementContentWhiteSpace;
    }
}
