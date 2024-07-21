// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoiceCommandSet.xml' path='doc/member[@name="IVoiceCommandSet"]/*' />
[Guid("0BEDDA75-46E6-4B11-A088-5C68632899B5")]
[NativeTypeName("struct IVoiceCommandSet : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
public unsafe partial struct IVoiceCommandSet : IVoiceCommandSet.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoiceCommandSet));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, Guid*, void**, int>)(lpVtbl[0]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, uint>)(lpVtbl[1]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, uint>)(lpVtbl[2]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, uint*, Guid**, int>)(lpVtbl[3]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, HSTRING*, int>)(lpVtbl[4]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, TrustLevel*, int>)(lpVtbl[5]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoiceCommandSet.xml' path='doc/member[@name="IVoiceCommandSet.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, HSTRING*, int>)(lpVtbl[6]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoiceCommandSet.xml' path='doc/member[@name="IVoiceCommandSet.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, HSTRING*, int>)(lpVtbl[7]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoiceCommandSet.xml' path='doc/member[@name="IVoiceCommandSet.SetPhraseListAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
    public HRESULT SetPhraseListAsync(HSTRING phraseListName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* phraseList, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** updateAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandSet*, HSTRING, IIterable<HSTRING>*, IAsyncAction**, int>)(lpVtbl[8]))((IVoiceCommandSet*)Unsafe.AsPointer(ref this), phraseListName, phraseList, updateAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
        HRESULT SetPhraseListAsync(HSTRING phraseListName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* phraseList, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** updateAction);
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
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition instead of Windows.Media.SpeechRecognition.VoiceComandSet. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IAsyncAction**, int> SetPhraseListAsync;
    }
}
