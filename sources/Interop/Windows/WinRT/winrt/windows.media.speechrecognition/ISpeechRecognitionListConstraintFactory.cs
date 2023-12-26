// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognitionListConstraintFactory.xml' path='doc/member[@name="ISpeechRecognitionListConstraintFactory"]/*' />
[Guid("40F3CDC7-562A-426A-9F3B-3B4E282BE1D5")]
[NativeTypeName("struct ISpeechRecognitionListConstraintFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionListConstraintFactory : ISpeechRecognitionListConstraintFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognitionListConstraintFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionListConstraintFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognitionListConstraintFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionListConstraintFactory*, uint>)(lpVtbl[1]))((ISpeechRecognitionListConstraintFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionListConstraintFactory*, uint>)(lpVtbl[2]))((ISpeechRecognitionListConstraintFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionListConstraintFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognitionListConstraintFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionListConstraintFactory*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognitionListConstraintFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionListConstraintFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognitionListConstraintFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognitionListConstraintFactory.xml' path='doc/member[@name="ISpeechRecognitionListConstraintFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* commands, [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionListConstraint **")] ISpeechRecognitionListConstraint** constraint)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionListConstraintFactory*, IIterable<HSTRING>*, ISpeechRecognitionListConstraint**, int>)(lpVtbl[6]))((ISpeechRecognitionListConstraintFactory*)Unsafe.AsPointer(ref this), commands, constraint);
    }

    /// <include file='ISpeechRecognitionListConstraintFactory.xml' path='doc/member[@name="ISpeechRecognitionListConstraintFactory.CreateWithTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTag([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* commands, HSTRING tag, [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionListConstraint **")] ISpeechRecognitionListConstraint** constraint)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionListConstraintFactory*, IIterable<HSTRING>*, HSTRING, ISpeechRecognitionListConstraint**, int>)(lpVtbl[7]))((ISpeechRecognitionListConstraintFactory*)Unsafe.AsPointer(ref this), commands, tag, constraint);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* commands, [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionListConstraint **")] ISpeechRecognitionListConstraint** constraint);

        [VtblIndex(7)]
        HRESULT CreateWithTag([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* commands, HSTRING tag, [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionListConstraint **")] ISpeechRecognitionListConstraint** constraint);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionListConstraint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, ISpeechRecognitionListConstraint**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, HSTRING, ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionListConstraint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, HSTRING, ISpeechRecognitionListConstraint**, int> CreateWithTag;
    }
}
