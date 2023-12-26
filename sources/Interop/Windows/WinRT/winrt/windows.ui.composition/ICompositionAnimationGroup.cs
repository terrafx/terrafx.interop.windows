// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionAnimationGroup.xml' path='doc/member[@name="ICompositionAnimationGroup"]/*' />
[Guid("5E7CC90C-CD14-4E07-8A55-C72527AABDAC")]
[NativeTypeName("struct ICompositionAnimationGroup : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionAnimationGroup : ICompositionAnimationGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionAnimationGroup));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, uint>)(lpVtbl[1]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, uint>)(lpVtbl[2]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, HSTRING*, int>)(lpVtbl[4]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionAnimationGroup.xml' path='doc/member[@name="ICompositionAnimationGroup.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Count([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, int*, int>)(lpVtbl[6]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionAnimationGroup.xml' path='doc/member[@name="ICompositionAnimationGroup.Add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Add([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")] ICompositionAnimation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, ICompositionAnimation*, int>)(lpVtbl[7]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionAnimationGroup.xml' path='doc/member[@name="ICompositionAnimationGroup.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")] ICompositionAnimation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, ICompositionAnimation*, int>)(lpVtbl[8]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionAnimationGroup.xml' path='doc/member[@name="ICompositionAnimationGroup.RemoveAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAll()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionAnimationGroup*, int>)(lpVtbl[9]))((ICompositionAnimationGroup*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Count([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT Add([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")] ICompositionAnimation* value);

        [VtblIndex(8)]
        HRESULT Remove([NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimation *")] ICompositionAnimation* value);

        [VtblIndex(9)]
        HRESULT RemoveAll();
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionAnimation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionAnimation*, int> Add;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionAnimation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionAnimation*, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveAll;
    }
}
