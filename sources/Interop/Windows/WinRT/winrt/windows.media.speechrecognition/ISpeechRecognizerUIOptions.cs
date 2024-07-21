// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions"]/*' />
[Guid("7888D641-B92B-44BA-A25F-D1864630641F")]
[NativeTypeName("struct ISpeechRecognizerUIOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognizerUIOptions : ISpeechRecognizerUIOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognizerUIOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, uint>)(lpVtbl[1]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, uint>)(lpVtbl[2]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions.get_ExampleText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExampleText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, HSTRING*, int>)(lpVtbl[6]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions.put_ExampleText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ExampleText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, HSTRING, int>)(lpVtbl[7]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions.get_AudiblePrompt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AudiblePrompt(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, HSTRING*, int>)(lpVtbl[8]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions.put_AudiblePrompt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AudiblePrompt(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, HSTRING, int>)(lpVtbl[9]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions.get_IsReadBackEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsReadBackEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, byte*, int>)(lpVtbl[10]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions.put_IsReadBackEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsReadBackEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, byte, int>)(lpVtbl[11]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions.get_ShowConfirmation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ShowConfirmation([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, byte*, int>)(lpVtbl[12]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerUIOptions.xml' path='doc/member[@name="ISpeechRecognizerUIOptions.put_ShowConfirmation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ShowConfirmation([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerUIOptions*, byte, int>)(lpVtbl[13]))((ISpeechRecognizerUIOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ExampleText(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_ExampleText(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_AudiblePrompt(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_AudiblePrompt(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_IsReadBackEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsReadBackEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_ShowConfirmation([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_ShowConfirmation([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ExampleText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ExampleText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudiblePrompt;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AudiblePrompt;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsReadBackEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsReadBackEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShowConfirmation;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShowConfirmation;
    }
}
