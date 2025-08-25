// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoiceCommandManager.xml' path='doc/member[@name="IVoiceCommandManager"]/*' />
[Guid("AA3A8DD5-B6E7-4EE2-BAA9-DD6BACED0A2B")]
[NativeTypeName("struct IVoiceCommandManager : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN.")]
public unsafe partial struct IVoiceCommandManager : IVoiceCommandManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVoiceCommandManager);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandManager*, Guid*, void**, int>)(lpVtbl[0]))((IVoiceCommandManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandManager*, uint>)(lpVtbl[1]))((IVoiceCommandManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandManager*, uint>)(lpVtbl[2]))((IVoiceCommandManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandManager*, uint*, Guid**, int>)(lpVtbl[3]))((IVoiceCommandManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandManager*, HSTRING*, int>)(lpVtbl[4]))((IVoiceCommandManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandManager*, TrustLevel*, int>)(lpVtbl[5]))((IVoiceCommandManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoiceCommandManager.xml' path='doc/member[@name="IVoiceCommandManager.InstallCommandSetsFromStorageFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN.")]
    public HRESULT InstallCommandSetsFromStorageFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** installAction)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandManager*, IStorageFile*, IAsyncAction**, int>)(lpVtbl[6]))((IVoiceCommandManager*)Unsafe.AsPointer(ref this), file, installAction);
    }

    /// <include file='IVoiceCommandManager.xml' path='doc/member[@name="IVoiceCommandManager.get_InstalledCommandSets"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN.")]
    public HRESULT get_InstalledCommandSets([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CSpeechRecognition__CVoiceCommandSet_t **")] IMapView<HSTRING, Pointer<IVoiceCommandSet>>** voiceCommandSets)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoiceCommandManager*, IMapView<HSTRING, Pointer<IVoiceCommandSet>>**, int>)(lpVtbl[7]))((IVoiceCommandManager*)Unsafe.AsPointer(ref this), voiceCommandSets);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN.")]
        HRESULT InstallCommandSetsFromStorageFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** installAction);

        [VtblIndex(7)]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN.")]
        HRESULT get_InstalledCommandSets([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CSpeechRecognition__CVoiceCommandSet_t **")] IMapView<HSTRING, Pointer<IVoiceCommandSet>>** voiceCommandSets);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncAction**, int> InstallCommandSetsFromStorageFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CSpeechRecognition__CVoiceCommandSet_t **) __attribute__((stdcall))")]
        [Obsolete("Use Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager instead of Windows.Media.SpeechRecognition.VoiceComandManager. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, Pointer<IVoiceCommandSet>>**, int> get_InstalledCommandSets;
    }
}
