// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognitionConstraint.xml' path='doc/member[@name="ISpeechRecognitionConstraint"]/*' />
[Guid("79AC1628-4D68-43C4-8911-40DC4101B55B")]
[NativeTypeName("struct ISpeechRecognitionConstraint : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionConstraint : ISpeechRecognitionConstraint.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpeechRecognitionConstraint);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, uint>)(lpVtbl[1]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, uint>)(lpVtbl[2]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognitionConstraint.xml' path='doc/member[@name="ISpeechRecognitionConstraint.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, byte*, int>)(lpVtbl[6]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionConstraint.xml' path='doc/member[@name="ISpeechRecognitionConstraint.put_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, byte, int>)(lpVtbl[7]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionConstraint.xml' path='doc/member[@name="ISpeechRecognitionConstraint.get_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Tag(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, HSTRING*, int>)(lpVtbl[8]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionConstraint.xml' path='doc/member[@name="ISpeechRecognitionConstraint.put_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Tag(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, HSTRING, int>)(lpVtbl[9]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionConstraint.xml' path='doc/member[@name="ISpeechRecognitionConstraint.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintType *")] SpeechRecognitionConstraintType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, SpeechRecognitionConstraintType*, int>)(lpVtbl[10]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionConstraint.xml' path='doc/member[@name="ISpeechRecognitionConstraint.get_Probability"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Probability([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability *")] SpeechRecognitionConstraintProbability* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, SpeechRecognitionConstraintProbability*, int>)(lpVtbl[11]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionConstraint.xml' path='doc/member[@name="ISpeechRecognitionConstraint.put_Probability"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Probability([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability")] SpeechRecognitionConstraintProbability value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionConstraint*, SpeechRecognitionConstraintProbability, int>)(lpVtbl[12]))((ISpeechRecognitionConstraint*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_Tag(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Tag(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintType *")] SpeechRecognitionConstraintType* value);

        [VtblIndex(11)]
        HRESULT get_Probability([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability *")] SpeechRecognitionConstraintProbability* value);

        [VtblIndex(12)]
        HRESULT put_Probability([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability")] SpeechRecognitionConstraintProbability value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Tag;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Tag;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpeechRecognitionConstraintType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpeechRecognitionConstraintProbability*, int> get_Probability;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConstraintProbability) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpeechRecognitionConstraintProbability, int> put_Probability;
    }
}
