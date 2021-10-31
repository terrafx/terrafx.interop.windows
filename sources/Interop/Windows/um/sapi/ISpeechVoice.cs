// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("269316D8-57BD-11D2-9EEE-00C04F797396")]
    [NativeTypeName("struct ISpeechVoice : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechVoice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechVoice*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechVoice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechVoice*, uint>)(lpVtbl[1]))((ISpeechVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechVoice*, uint>)(lpVtbl[2]))((ISpeechVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechVoice*, uint*, int>)(lpVtbl[3]))((ISpeechVoice*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechVoice*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechVoice*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechVoice*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechVoice*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechVoice*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Status(ISpeechVoiceStatus** Status)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ISpeechVoiceStatus**, int>)(lpVtbl[7]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Voice(ISpeechObjectToken** Voice)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ISpeechObjectToken**, int>)(lpVtbl[8]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Voice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_Voice(ISpeechObjectToken* Voice)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ISpeechObjectToken*, int>)(lpVtbl[9]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Voice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_AudioOutput(ISpeechObjectToken** AudioOutput)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ISpeechObjectToken**, int>)(lpVtbl[10]))((ISpeechVoice*)Unsafe.AsPointer(ref this), AudioOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_AudioOutput(ISpeechObjectToken* AudioOutput)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ISpeechObjectToken*, int>)(lpVtbl[11]))((ISpeechVoice*)Unsafe.AsPointer(ref this), AudioOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_AudioOutputStream(ISpeechBaseStream** AudioOutputStream)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ISpeechBaseStream**, int>)(lpVtbl[12]))((ISpeechVoice*)Unsafe.AsPointer(ref this), AudioOutputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT putref_AudioOutputStream(ISpeechBaseStream* AudioOutputStream)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ISpeechBaseStream*, int>)(lpVtbl[13]))((ISpeechVoice*)Unsafe.AsPointer(ref this), AudioOutputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Rate([NativeTypeName("long *")] int* Rate)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int*, int>)(lpVtbl[14]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_Rate([NativeTypeName("long")] int Rate)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int, int>)(lpVtbl[15]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_Volume([NativeTypeName("long *")] int* Volume)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int*, int>)(lpVtbl[16]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_Volume([NativeTypeName("long")] int Volume)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int, int>)(lpVtbl[17]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_AllowAudioOutputFormatChangesOnNextSet([NativeTypeName("VARIANT_BOOL")] short Allow)
        {
            return ((delegate* unmanaged<ISpeechVoice*, short, int>)(lpVtbl[18]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Allow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_AllowAudioOutputFormatChangesOnNextSet([NativeTypeName("VARIANT_BOOL *")] short* Allow)
        {
            return ((delegate* unmanaged<ISpeechVoice*, short*, int>)(lpVtbl[19]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Allow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_EventInterests(SpeechVoiceEvents* EventInterestFlags)
        {
            return ((delegate* unmanaged<ISpeechVoice*, SpeechVoiceEvents*, int>)(lpVtbl[20]))((ISpeechVoice*)Unsafe.AsPointer(ref this), EventInterestFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_EventInterests(SpeechVoiceEvents EventInterestFlags)
        {
            return ((delegate* unmanaged<ISpeechVoice*, SpeechVoiceEvents, int>)(lpVtbl[21]))((ISpeechVoice*)Unsafe.AsPointer(ref this), EventInterestFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_Priority(SpeechVoicePriority Priority)
        {
            return ((delegate* unmanaged<ISpeechVoice*, SpeechVoicePriority, int>)(lpVtbl[22]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Priority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_Priority(SpeechVoicePriority* Priority)
        {
            return ((delegate* unmanaged<ISpeechVoice*, SpeechVoicePriority*, int>)(lpVtbl[23]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Priority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_AlertBoundary(SpeechVoiceEvents Boundary)
        {
            return ((delegate* unmanaged<ISpeechVoice*, SpeechVoiceEvents, int>)(lpVtbl[24]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Boundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_AlertBoundary(SpeechVoiceEvents* Boundary)
        {
            return ((delegate* unmanaged<ISpeechVoice*, SpeechVoiceEvents*, int>)(lpVtbl[25]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Boundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_SynchronousSpeakTimeout([NativeTypeName("long")] int msTimeout)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int, int>)(lpVtbl[26]))((ISpeechVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_SynchronousSpeakTimeout([NativeTypeName("long *")] int* msTimeout)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int*, int>)(lpVtbl[27]))((ISpeechVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT Speak([NativeTypeName("BSTR")] ushort* Text, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ushort*, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[28]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Text, Flags, StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SpeakStream(ISpeechBaseStream* Stream, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ISpeechBaseStream*, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[29]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Stream, Flags, StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT Pause()
        {
            return ((delegate* unmanaged<ISpeechVoice*, int>)(lpVtbl[30]))((ISpeechVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT Resume()
        {
            return ((delegate* unmanaged<ISpeechVoice*, int>)(lpVtbl[31]))((ISpeechVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT Skip([NativeTypeName("const BSTR")] ushort* Type, [NativeTypeName("long")] int NumItems, [NativeTypeName("long *")] int* NumSkipped)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ushort*, int, int*, int>)(lpVtbl[32]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Type, NumItems, NumSkipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetVoices([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[33]))((ISpeechVoice*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetAudioOutputs([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, ISpeechObjectTokens** ObjectTokens)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[34]))((ISpeechVoice*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, ObjectTokens);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT WaitUntilDone([NativeTypeName("long")] int msTimeout, [NativeTypeName("VARIANT_BOOL *")] short* Done)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int, short*, int>)(lpVtbl[35]))((ISpeechVoice*)Unsafe.AsPointer(ref this), msTimeout, Done);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT SpeakCompleteEvent([NativeTypeName("long *")] int* Handle)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int*, int>)(lpVtbl[36]))((ISpeechVoice*)Unsafe.AsPointer(ref this), Handle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT IsUISupported([NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData, [NativeTypeName("VARIANT_BOOL *")] short* Supported)
        {
            return ((delegate* unmanaged<ISpeechVoice*, ushort*, VARIANT*, short*, int>)(lpVtbl[37]))((ISpeechVoice*)Unsafe.AsPointer(ref this), TypeOfUI, ExtraData, Supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT DisplayUI([NativeTypeName("long")] int hWndParent, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("const BSTR")] ushort* TypeOfUI, [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null)
        {
            return ((delegate* unmanaged<ISpeechVoice*, int, ushort*, ushort*, VARIANT*, int>)(lpVtbl[38]))((ISpeechVoice*)Unsafe.AsPointer(ref this), hWndParent, Title, TypeOfUI, ExtraData);
        }
    }
}
