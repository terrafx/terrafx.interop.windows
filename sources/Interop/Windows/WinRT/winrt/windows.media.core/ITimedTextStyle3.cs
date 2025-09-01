// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextStyle3.xml' path='doc/member[@name="ITimedTextStyle3"]/*' />
[Guid("F803F93B-3E99-595E-BBB7-78A2FA13C270")]
[NativeTypeName("struct ITimedTextStyle3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextStyle3 : ITimedTextStyle3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITimedTextStyle3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, uint>)(lpVtbl[1]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, uint>)(lpVtbl[2]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextStyle3.xml' path='doc/member[@name="ITimedTextStyle3.get_Ruby"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Ruby([NativeTypeName("ABI::Windows::Media::Core::ITimedTextRuby **")] ITimedTextRuby** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, ITimedTextRuby**, int>)(lpVtbl[6]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle3.xml' path='doc/member[@name="ITimedTextStyle3.get_Bouten"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bouten([NativeTypeName("ABI::Windows::Media::Core::ITimedTextBouten **")] ITimedTextBouten** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, ITimedTextBouten**, int>)(lpVtbl[7]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle3.xml' path='doc/member[@name="ITimedTextStyle3.get_IsTextCombined"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsTextCombined([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, byte*, int>)(lpVtbl[8]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle3.xml' path='doc/member[@name="ITimedTextStyle3.put_IsTextCombined"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsTextCombined([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, byte, int>)(lpVtbl[9]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle3.xml' path='doc/member[@name="ITimedTextStyle3.get_FontAngleInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FontAngleInDegrees(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, double*, int>)(lpVtbl[10]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle3.xml' path='doc/member[@name="ITimedTextStyle3.put_FontAngleInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FontAngleInDegrees(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle3*, double, int>)(lpVtbl[11]))((ITimedTextStyle3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Ruby([NativeTypeName("ABI::Windows::Media::Core::ITimedTextRuby **")] ITimedTextRuby** value);

        [VtblIndex(7)]
        HRESULT get_Bouten([NativeTypeName("ABI::Windows::Media::Core::ITimedTextBouten **")] ITimedTextBouten** value);

        [VtblIndex(8)]
        HRESULT get_IsTextCombined([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsTextCombined([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_FontAngleInDegrees(double* value);

        [VtblIndex(11)]
        HRESULT put_FontAngleInDegrees(double value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedTextRuby **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedTextRuby**, int> get_Ruby;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedTextBouten **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedTextBouten**, int> get_Bouten;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsTextCombined;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsTextCombined;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_FontAngleInDegrees;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_FontAngleInDegrees;
    }
}
