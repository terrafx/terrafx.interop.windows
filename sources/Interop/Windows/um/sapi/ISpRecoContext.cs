// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F740A62F-7C15-489E-8234-940A33D9272D")]
    [NativeTypeName("struct ISpRecoContext : ISpEventSource")]
    [NativeInheritance("ISpEventSource")]
    public unsafe partial struct ISpRecoContext : ISpRecoContext.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecoContext*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecoContext*, uint>)(lpVtbl[1]))((ISpRecoContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecoContext*, uint>)(lpVtbl[2]))((ISpRecoContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetNotifySink(ISpNotifySink* pNotifySink)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpRecoContext*, HWND, uint, WPARAM, LPARAM, int>)(lpVtbl[4]))((ISpRecoContext*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpRecoContext*, delegate* unmanaged<WPARAM, LPARAM, void>, WPARAM, LPARAM, int>)(lpVtbl[5]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ISpNotifyCallback*, WPARAM, LPARAM, int>)(lpVtbl[6]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetNotifyWin32Event()
        {
            return ((delegate* unmanaged<ISpRecoContext*, int>)(lpVtbl[7]))((ISpRecoContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISpRecoContext*, uint, int>)(lpVtbl[8]))((ISpRecoContext*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HANDLE GetNotifyEventHandle()
        {
            return ((HANDLE)(((delegate* unmanaged<ISpRecoContext*, void*>)(lpVtbl[9]))((ISpRecoContext*)Unsafe.AsPointer(ref this))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ulong, ulong, int>)(lpVtbl[10]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetEvents([NativeTypeName("ULONG")] uint ulCount, SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* unmanaged<ISpRecoContext*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetInfo(SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* unmanaged<ISpRecoContext*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetRecognizer(ISpRecognizer** ppRecognizer)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ISpRecognizer**, int>)(lpVtbl[13]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ppRecognizer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CreateGrammar([NativeTypeName("ULONGLONG")] ulong ullGrammarId, ISpRecoGrammar** ppGrammar)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ulong, ISpRecoGrammar**, int>)(lpVtbl[14]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ullGrammarId, ppGrammar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetStatus(SPRECOCONTEXTSTATUS* pStatus)
        {
            return ((delegate* unmanaged<ISpRecoContext*, SPRECOCONTEXTSTATUS*, int>)(lpVtbl[15]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetMaxAlternates([NativeTypeName("ULONG *")] uint* pcAlternates)
        {
            return ((delegate* unmanaged<ISpRecoContext*, uint*, int>)(lpVtbl[16]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pcAlternates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetMaxAlternates([NativeTypeName("ULONG")] uint cAlternates)
        {
            return ((delegate* unmanaged<ISpRecoContext*, uint, int>)(lpVtbl[17]))((ISpRecoContext*)Unsafe.AsPointer(ref this), cAlternates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetAudioOptions(SPAUDIOOPTIONS Options, [NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpRecoContext*, SPAUDIOOPTIONS, Guid*, WAVEFORMATEX*, int>)(lpVtbl[18]))((ISpRecoContext*)Unsafe.AsPointer(ref this), Options, pAudioFormatId, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetAudioOptions(SPAUDIOOPTIONS* pOptions, Guid* pAudioFormatId, WAVEFORMATEX** ppCoMemWFEX)
        {
            return ((delegate* unmanaged<ISpRecoContext*, SPAUDIOOPTIONS*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[19]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pOptions, pAudioFormatId, ppCoMemWFEX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DeserializeResult([NativeTypeName("const SPSERIALIZEDRESULT *")] SPSERIALIZEDRESULT* pSerializedResult, ISpRecoResult** ppResult)
        {
            return ((delegate* unmanaged<ISpRecoContext*, SPSERIALIZEDRESULT*, ISpRecoResult**, int>)(lpVtbl[20]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pSerializedResult, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT Bookmark(SPBOOKMARKOPTIONS Options, [NativeTypeName("ULONGLONG")] ulong ullStreamPosition, LPARAM lparamEvent)
        {
            return ((delegate* unmanaged<ISpRecoContext*, SPBOOKMARKOPTIONS, ulong, LPARAM, int>)(lpVtbl[21]))((ISpRecoContext*)Unsafe.AsPointer(ref this), Options, ullStreamPosition, lparamEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetAdaptationData([NativeTypeName("LPCWSTR")] ushort* pAdaptationData, [NativeTypeName("const ULONG")] uint cch)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ushort*, uint, int>)(lpVtbl[22]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pAdaptationData, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT Pause([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISpRecoContext*, uint, int>)(lpVtbl[23]))((ISpRecoContext*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT Resume([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISpRecoContext*, uint, int>)(lpVtbl[24]))((ISpRecoContext*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetVoice(ISpVoice* pVoice, BOOL fAllowFormatChanges)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ISpVoice*, BOOL, int>)(lpVtbl[25]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pVoice, fAllowFormatChanges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetVoice(ISpVoice** ppVoice)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ISpVoice**, int>)(lpVtbl[26]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ppVoice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetVoicePurgeEvent([NativeTypeName("ULONGLONG")] ulong ullEventInterest)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ulong, int>)(lpVtbl[27]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ullEventInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetVoicePurgeEvent([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest)
        {
            return ((delegate* unmanaged<ISpRecoContext*, ulong*, int>)(lpVtbl[28]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pullEventInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SetContextState(SPCONTEXTSTATE eContextState)
        {
            return ((delegate* unmanaged<ISpRecoContext*, SPCONTEXTSTATE, int>)(lpVtbl[29]))((ISpRecoContext*)Unsafe.AsPointer(ref this), eContextState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetContextState(SPCONTEXTSTATE* peContextState)
        {
            return ((delegate* unmanaged<ISpRecoContext*, SPCONTEXTSTATE*, int>)(lpVtbl[30]))((ISpRecoContext*)Unsafe.AsPointer(ref this), peContextState);
        }

        public interface Interface : ISpEventSource.Interface
        {
            [VtblIndex(13)]
            HRESULT GetRecognizer(ISpRecognizer** ppRecognizer);

            [VtblIndex(14)]
            HRESULT CreateGrammar([NativeTypeName("ULONGLONG")] ulong ullGrammarId, ISpRecoGrammar** ppGrammar);

            [VtblIndex(15)]
            HRESULT GetStatus(SPRECOCONTEXTSTATUS* pStatus);

            [VtblIndex(16)]
            HRESULT GetMaxAlternates([NativeTypeName("ULONG *")] uint* pcAlternates);

            [VtblIndex(17)]
            HRESULT SetMaxAlternates([NativeTypeName("ULONG")] uint cAlternates);

            [VtblIndex(18)]
            HRESULT SetAudioOptions(SPAUDIOOPTIONS Options, [NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx);

            [VtblIndex(19)]
            HRESULT GetAudioOptions(SPAUDIOOPTIONS* pOptions, Guid* pAudioFormatId, WAVEFORMATEX** ppCoMemWFEX);

            [VtblIndex(20)]
            HRESULT DeserializeResult([NativeTypeName("const SPSERIALIZEDRESULT *")] SPSERIALIZEDRESULT* pSerializedResult, ISpRecoResult** ppResult);

            [VtblIndex(21)]
            HRESULT Bookmark(SPBOOKMARKOPTIONS Options, [NativeTypeName("ULONGLONG")] ulong ullStreamPosition, LPARAM lparamEvent);

            [VtblIndex(22)]
            HRESULT SetAdaptationData([NativeTypeName("LPCWSTR")] ushort* pAdaptationData, [NativeTypeName("const ULONG")] uint cch);

            [VtblIndex(23)]
            HRESULT Pause([NativeTypeName("DWORD")] uint dwReserved);

            [VtblIndex(24)]
            HRESULT Resume([NativeTypeName("DWORD")] uint dwReserved);

            [VtblIndex(25)]
            HRESULT SetVoice(ISpVoice* pVoice, BOOL fAllowFormatChanges);

            [VtblIndex(26)]
            HRESULT GetVoice(ISpVoice** ppVoice);

            [VtblIndex(27)]
            HRESULT SetVoicePurgeEvent([NativeTypeName("ULONGLONG")] ulong ullEventInterest);

            [VtblIndex(28)]
            HRESULT GetVoicePurgeEvent([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest);

            [VtblIndex(29)]
            HRESULT SetContextState(SPCONTEXTSTATE eContextState);

            [VtblIndex(30)]
            HRESULT GetContextState(SPCONTEXTSTATE* peContextState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, uint> Release;

            [NativeTypeName("HRESULT (ISpNotifySink *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ISpNotifySink*, int> SetNotifySink;

            [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, HWND, uint, WPARAM, LPARAM, int> SetNotifyWindowMessage;

            [NativeTypeName("HRESULT (SPNOTIFYCALLBACK *, WPARAM, LPARAM) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, delegate* unmanaged<WPARAM, LPARAM, void>, WPARAM, LPARAM, int> SetNotifyCallbackFunction;

            [NativeTypeName("HRESULT (ISpNotifyCallback *, WPARAM, LPARAM) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ISpNotifyCallback*, WPARAM, LPARAM, int> SetNotifyCallbackInterface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, int> SetNotifyWin32Event;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, uint, int> WaitForNotifyEvent;

            [NativeTypeName("HANDLE () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, void*> GetNotifyEventHandle;

            [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ulong, ulong, int> SetInterest;

            [NativeTypeName("HRESULT (ULONG, SPEVENT *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, uint, SPEVENT*, uint*, int> GetEvents;

            [NativeTypeName("HRESULT (SPEVENTSOURCEINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, SPEVENTSOURCEINFO*, int> GetInfo;

            [NativeTypeName("HRESULT (ISpRecognizer **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ISpRecognizer**, int> GetRecognizer;

            [NativeTypeName("HRESULT (ULONGLONG, ISpRecoGrammar **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ulong, ISpRecoGrammar**, int> CreateGrammar;

            [NativeTypeName("HRESULT (SPRECOCONTEXTSTATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, SPRECOCONTEXTSTATUS*, int> GetStatus;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, uint*, int> GetMaxAlternates;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, uint, int> SetMaxAlternates;

            [NativeTypeName("HRESULT (SPAUDIOOPTIONS, const GUID *, const WAVEFORMATEX *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, SPAUDIOOPTIONS, Guid*, WAVEFORMATEX*, int> SetAudioOptions;

            [NativeTypeName("HRESULT (SPAUDIOOPTIONS *, GUID *, WAVEFORMATEX **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, SPAUDIOOPTIONS*, Guid*, WAVEFORMATEX**, int> GetAudioOptions;

            [NativeTypeName("HRESULT (const SPSERIALIZEDRESULT *, ISpRecoResult **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, SPSERIALIZEDRESULT*, ISpRecoResult**, int> DeserializeResult;

            [NativeTypeName("HRESULT (SPBOOKMARKOPTIONS, ULONGLONG, LPARAM) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, SPBOOKMARKOPTIONS, ulong, LPARAM, int> Bookmark;

            [NativeTypeName("HRESULT (LPCWSTR, const ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ushort*, uint, int> SetAdaptationData;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, uint, int> Pause;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, uint, int> Resume;

            [NativeTypeName("HRESULT (ISpVoice *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ISpVoice*, BOOL, int> SetVoice;

            [NativeTypeName("HRESULT (ISpVoice **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ISpVoice**, int> GetVoice;

            [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ulong, int> SetVoicePurgeEvent;

            [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, ulong*, int> GetVoicePurgeEvent;

            [NativeTypeName("HRESULT (SPCONTEXTSTATE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, SPCONTEXTSTATE, int> SetContextState;

            [NativeTypeName("HRESULT (SPCONTEXTSTATE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext*, SPCONTEXTSTATE*, int> GetContextState;
        }
    }
}
