// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties"]/*' />
[Guid("92AB0007-090E-4704-BB5C-84FC0B0D9C31")]
[NativeTypeName("struct IUserDataTaskRegenerationProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskRegenerationProperties : IUserDataTaskRegenerationProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTaskRegenerationProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, uint>)(lpVtbl[1]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, uint>)(lpVtbl[2]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, HSTRING*, int>)(lpVtbl[4]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties.get_Unit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Unit([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRegenerationUnit *")] UserDataTaskRegenerationUnit* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, UserDataTaskRegenerationUnit*, int>)(lpVtbl[6]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties.put_Unit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Unit([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRegenerationUnit")] UserDataTaskRegenerationUnit value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, UserDataTaskRegenerationUnit, int>)(lpVtbl[7]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties.get_Occurrences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Occurrences([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, IReference<int>**, int>)(lpVtbl[8]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties.put_Occurrences"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Occurrences([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, IReference<int>*, int>)(lpVtbl[9]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties.get_Until"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Until([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, IReference<DateTime>**, int>)(lpVtbl[10]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties.put_Until"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Until([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, IReference<DateTime>*, int>)(lpVtbl[11]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties.get_Interval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Interval([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, int*, int>)(lpVtbl[12]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskRegenerationProperties.xml' path='doc/member[@name="IUserDataTaskRegenerationProperties.put_Interval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Interval([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskRegenerationProperties*, int, int>)(lpVtbl[13]))((IUserDataTaskRegenerationProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Unit([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRegenerationUnit *")] UserDataTaskRegenerationUnit* value);

        [VtblIndex(7)]
        HRESULT put_Unit([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRegenerationUnit")] UserDataTaskRegenerationUnit value);

        [VtblIndex(8)]
        HRESULT get_Occurrences([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(9)]
        HRESULT put_Occurrences([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(10)]
        HRESULT get_Until([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(11)]
        HRESULT put_Until([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(12)]
        HRESULT get_Interval([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_Interval([NativeTypeName("INT32")] int value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRegenerationUnit *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskRegenerationUnit*, int> get_Unit;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskRegenerationUnit) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskRegenerationUnit, int> put_Unit;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_Occurrences;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_Occurrences;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_Until;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_Until;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Interval;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_Interval;
    }
}
