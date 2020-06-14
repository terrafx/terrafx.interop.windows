// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F740A62F-7C15-489E-8234-940A33D9272D")]
    public unsafe partial struct ISpRecoContext
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpRecoContext*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpRecoContext*, uint>)(lpVtbl[1]))((ISpRecoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpRecoContext*, uint>)(lpVtbl[2]))((ISpRecoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifySink([NativeTypeName("ISpNotifySink *")] ISpNotifySink* pNotifySink)
        {
            return ((delegate* stdcall<ISpRecoContext*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWindowMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpRecoContext*, IntPtr, uint, nuint, nint, int>)(lpVtbl[4]))((ISpRecoContext*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* stdcall<nuint, nint, void>* pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpRecoContext*, delegate* stdcall<nuint, nint, void>*, nuint, nint, int>)(lpVtbl[5]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackInterface([NativeTypeName("ISpNotifyCallback *")] ISpNotifyCallback* pSpCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpRecoContext*, ISpNotifyCallback*, nuint, nint, int>)(lpVtbl[6]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWin32Event()
        {
            return ((delegate* stdcall<ISpRecoContext*, int>)(lpVtbl[7]))((ISpRecoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* stdcall<ISpRecoContext*, uint, int>)(lpVtbl[8]))((ISpRecoContext*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetNotifyEventHandle()
        {
            return ((delegate* stdcall<ISpRecoContext*, IntPtr>)(lpVtbl[9]))((ISpRecoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* stdcall<ISpRecoContext*, ulong, ulong, int>)(lpVtbl[10]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvents([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("SPEVENT *")] SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* stdcall<ISpRecoContext*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("SPEVENTSOURCEINFO *")] SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* stdcall<ISpRecoContext*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecognizer([NativeTypeName("ISpRecognizer **")] ISpRecognizer** ppRecognizer)
        {
            return ((delegate* stdcall<ISpRecoContext*, ISpRecognizer**, int>)(lpVtbl[13]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ppRecognizer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGrammar([NativeTypeName("ULONGLONG")] ulong ullGrammarId, [NativeTypeName("ISpRecoGrammar **")] ISpRecoGrammar** ppGrammar)
        {
            return ((delegate* stdcall<ISpRecoContext*, ulong, ISpRecoGrammar**, int>)(lpVtbl[14]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ullGrammarId, ppGrammar);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("SPRECOCONTEXTSTATUS *")] SPRECOCONTEXTSTATUS* pStatus)
        {
            return ((delegate* stdcall<ISpRecoContext*, SPRECOCONTEXTSTATUS*, int>)(lpVtbl[15]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxAlternates([NativeTypeName("ULONG *")] uint* pcAlternates)
        {
            return ((delegate* stdcall<ISpRecoContext*, uint*, int>)(lpVtbl[16]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pcAlternates);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaxAlternates([NativeTypeName("ULONG")] uint cAlternates)
        {
            return ((delegate* stdcall<ISpRecoContext*, uint, int>)(lpVtbl[17]))((ISpRecoContext*)Unsafe.AsPointer(ref this), cAlternates);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAudioOptions(SPAUDIOOPTIONS Options, [NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* stdcall<ISpRecoContext*, SPAUDIOOPTIONS, Guid*, WAVEFORMATEX*, int>)(lpVtbl[18]))((ISpRecoContext*)Unsafe.AsPointer(ref this), Options, pAudioFormatId, pWaveFormatEx);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAudioOptions([NativeTypeName("SPAUDIOOPTIONS *")] SPAUDIOOPTIONS* pOptions, [NativeTypeName("GUID *")] Guid* pAudioFormatId, [NativeTypeName("WAVEFORMATEX **")] WAVEFORMATEX** ppCoMemWFEX)
        {
            return ((delegate* stdcall<ISpRecoContext*, SPAUDIOOPTIONS*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[19]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pOptions, pAudioFormatId, ppCoMemWFEX);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeserializeResult([NativeTypeName("const SPSERIALIZEDRESULT *")] SPSERIALIZEDRESULT* pSerializedResult, [NativeTypeName("ISpRecoResult **")] ISpRecoResult** ppResult)
        {
            return ((delegate* stdcall<ISpRecoContext*, SPSERIALIZEDRESULT*, ISpRecoResult**, int>)(lpVtbl[20]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pSerializedResult, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Bookmark(SPBOOKMARKOPTIONS Options, [NativeTypeName("ULONGLONG")] ulong ullStreamPosition, [NativeTypeName("LPARAM")] nint lparamEvent)
        {
            return ((delegate* stdcall<ISpRecoContext*, SPBOOKMARKOPTIONS, ulong, nint, int>)(lpVtbl[21]))((ISpRecoContext*)Unsafe.AsPointer(ref this), Options, ullStreamPosition, lparamEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAdaptationData([NativeTypeName("LPCWSTR")] ushort* pAdaptationData, [NativeTypeName("const ULONG")] uint cch)
        {
            return ((delegate* stdcall<ISpRecoContext*, ushort*, uint, int>)(lpVtbl[22]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pAdaptationData, cch);
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<ISpRecoContext*, uint, int>)(lpVtbl[23]))((ISpRecoContext*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int Resume([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<ISpRecoContext*, uint, int>)(lpVtbl[24]))((ISpRecoContext*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVoice([NativeTypeName("ISpVoice *")] ISpVoice* pVoice, [NativeTypeName("BOOL")] int fAllowFormatChanges)
        {
            return ((delegate* stdcall<ISpRecoContext*, ISpVoice*, int, int>)(lpVtbl[25]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pVoice, fAllowFormatChanges);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVoice([NativeTypeName("ISpVoice **")] ISpVoice** ppVoice)
        {
            return ((delegate* stdcall<ISpRecoContext*, ISpVoice**, int>)(lpVtbl[26]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ppVoice);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVoicePurgeEvent([NativeTypeName("ULONGLONG")] ulong ullEventInterest)
        {
            return ((delegate* stdcall<ISpRecoContext*, ulong, int>)(lpVtbl[27]))((ISpRecoContext*)Unsafe.AsPointer(ref this), ullEventInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVoicePurgeEvent([NativeTypeName("ULONGLONG *")] ulong* pullEventInterest)
        {
            return ((delegate* stdcall<ISpRecoContext*, ulong*, int>)(lpVtbl[28]))((ISpRecoContext*)Unsafe.AsPointer(ref this), pullEventInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContextState(SPCONTEXTSTATE eContextState)
        {
            return ((delegate* stdcall<ISpRecoContext*, SPCONTEXTSTATE, int>)(lpVtbl[29]))((ISpRecoContext*)Unsafe.AsPointer(ref this), eContextState);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContextState([NativeTypeName("SPCONTEXTSTATE *")] SPCONTEXTSTATE* peContextState)
        {
            return ((delegate* stdcall<ISpRecoContext*, SPCONTEXTSTATE*, int>)(lpVtbl[30]))((ISpRecoContext*)Unsafe.AsPointer(ref this), peContextState);
        }
    }
}
