// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Winmm", EntryPoint = "waveOutGetNumDevs", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint waveOutGetNumDevs();

        [DllImport("Winmm", EntryPoint = "waveOutGetDevCapsA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPWAVEOUTCAPSA")] WAVEOUTCAPSA* pwoc, [NativeTypeName("UINT")] uint cbwoc);

        [DllImport("Winmm", EntryPoint = "waveOutGetDevCapsW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPWAVEOUTCAPSW")] WAVEOUTCAPSW* pwoc, [NativeTypeName("UINT")] uint cbwoc);

        [DllImport("Winmm", EntryPoint = "waveOutGetVolume", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetVolume([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("LPDWORD")] uint* pdwVolume);

        [DllImport("Winmm", EntryPoint = "waveOutSetVolume", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutSetVolume([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("DWORD")] uint dwVolume);

        [DllImport("Winmm", EntryPoint = "waveOutGetErrorTextA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetErrorTextA([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPSTR")] sbyte* pszText, [NativeTypeName("UINT")] uint cchText);

        [DllImport("Winmm", EntryPoint = "waveOutGetErrorTextW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetErrorTextW([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPWSTR")] ushort* pszText, [NativeTypeName("UINT")] uint cchText);

        [DllImport("Winmm", EntryPoint = "waveOutOpen", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutOpen([NativeTypeName("LPHWAVEOUT")] IntPtr* phwo, [NativeTypeName("UINT")] uint uDeviceID, [NativeTypeName("LPCWAVEFORMATEX")] WAVEFORMATEX* pwfx, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("Winmm", EntryPoint = "waveOutClose", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutClose([NativeTypeName("HWAVEOUT")] IntPtr hwo);

        [DllImport("Winmm", EntryPoint = "waveOutPrepareHeader", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutPrepareHeader([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, [NativeTypeName("UINT")] uint cbwh);

        [DllImport("Winmm", EntryPoint = "waveOutUnprepareHeader", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutUnprepareHeader([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, [NativeTypeName("UINT")] uint cbwh);

        [DllImport("Winmm", EntryPoint = "waveOutWrite", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutWrite([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, [NativeTypeName("UINT")] uint cbwh);

        [DllImport("Winmm", EntryPoint = "waveOutPause", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutPause([NativeTypeName("HWAVEOUT")] IntPtr hwo);

        [DllImport("Winmm", EntryPoint = "waveOutRestart", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutRestart([NativeTypeName("HWAVEOUT")] IntPtr hwo);

        [DllImport("Winmm", EntryPoint = "waveOutReset", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutReset([NativeTypeName("HWAVEOUT")] IntPtr hwo);

        [DllImport("Winmm", EntryPoint = "waveOutBreakLoop", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutBreakLoop([NativeTypeName("HWAVEOUT")] IntPtr hwo);

        [DllImport("Winmm", EntryPoint = "waveOutGetPosition", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetPosition([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("LPMMTIME")] MMTIME* pmmt, [NativeTypeName("UINT")] uint cbmmt);

        [DllImport("Winmm", EntryPoint = "waveOutGetPitch", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetPitch([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("LPDWORD")] uint* pdwPitch);

        [DllImport("Winmm", EntryPoint = "waveOutSetPitch", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutSetPitch([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("DWORD")] uint dwPitch);

        [DllImport("Winmm", EntryPoint = "waveOutGetPlaybackRate", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetPlaybackRate([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("LPDWORD")] uint* pdwRate);

        [DllImport("Winmm", EntryPoint = "waveOutSetPlaybackRate", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutSetPlaybackRate([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("DWORD")] uint dwRate);

        [DllImport("Winmm", EntryPoint = "waveOutGetID", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetID([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("LPUINT")] uint* puDeviceID);

        [DllImport("Winmm", EntryPoint = "waveOutMessage", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutMessage([NativeTypeName("HWAVEOUT")] IntPtr hwo, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("Winmm", EntryPoint = "waveInGetNumDevs", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint waveInGetNumDevs();

        [DllImport("Winmm", EntryPoint = "waveInGetDevCapsA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPWAVEINCAPSA")] WAVEINCAPSA* pwic, [NativeTypeName("UINT")] uint cbwic);

        [DllImport("Winmm", EntryPoint = "waveInGetDevCapsW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPWAVEINCAPSW")] WAVEINCAPSW* pwic, [NativeTypeName("UINT")] uint cbwic);

        [DllImport("Winmm", EntryPoint = "waveInGetErrorTextA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetErrorTextA([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPSTR")] sbyte* pszText, [NativeTypeName("UINT")] uint cchText);

        [DllImport("Winmm", EntryPoint = "waveInGetErrorTextW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetErrorTextW([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPWSTR")] ushort* pszText, [NativeTypeName("UINT")] uint cchText);

        [DllImport("Winmm", EntryPoint = "waveInOpen", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInOpen([NativeTypeName("LPHWAVEIN")] IntPtr* phwi, [NativeTypeName("UINT")] uint uDeviceID, [NativeTypeName("LPCWAVEFORMATEX")] WAVEFORMATEX* pwfx, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("Winmm", EntryPoint = "waveInClose", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInClose([NativeTypeName("HWAVEIN")] IntPtr hwi);

        [DllImport("Winmm", EntryPoint = "waveInPrepareHeader", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInPrepareHeader([NativeTypeName("HWAVEIN")] IntPtr hwi, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, [NativeTypeName("UINT")] uint cbwh);

        [DllImport("Winmm", EntryPoint = "waveInUnprepareHeader", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInUnprepareHeader([NativeTypeName("HWAVEIN")] IntPtr hwi, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, [NativeTypeName("UINT")] uint cbwh);

        [DllImport("Winmm", EntryPoint = "waveInAddBuffer", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInAddBuffer([NativeTypeName("HWAVEIN")] IntPtr hwi, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, [NativeTypeName("UINT")] uint cbwh);

        [DllImport("Winmm", EntryPoint = "waveInStart", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInStart([NativeTypeName("HWAVEIN")] IntPtr hwi);

        [DllImport("Winmm", EntryPoint = "waveInStop", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInStop([NativeTypeName("HWAVEIN")] IntPtr hwi);

        [DllImport("Winmm", EntryPoint = "waveInReset", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInReset([NativeTypeName("HWAVEIN")] IntPtr hwi);

        [DllImport("Winmm", EntryPoint = "waveInGetPosition", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetPosition([NativeTypeName("HWAVEIN")] IntPtr hwi, [NativeTypeName("LPMMTIME")] MMTIME* pmmt, [NativeTypeName("UINT")] uint cbmmt);

        [DllImport("Winmm", EntryPoint = "waveInGetID", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetID([NativeTypeName("HWAVEIN")] IntPtr hwi, [NativeTypeName("LPUINT")] uint* puDeviceID);

        [DllImport("Winmm", EntryPoint = "waveInMessage", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInMessage([NativeTypeName("HWAVEIN")] IntPtr hwi, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("Winmm", EntryPoint = "midiOutGetNumDevs", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint midiOutGetNumDevs();

        [DllImport("Winmm", EntryPoint = "midiStreamOpen", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamOpen([NativeTypeName("LPHMIDISTRM")] IntPtr* phms, [NativeTypeName("LPUINT")] uint* puDeviceID, [NativeTypeName("DWORD")] uint cMidi, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("Winmm", EntryPoint = "midiStreamClose", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamClose([NativeTypeName("HMIDISTRM")] IntPtr hms);

        [DllImport("Winmm", EntryPoint = "midiStreamProperty", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamProperty([NativeTypeName("HMIDISTRM")] IntPtr hms, [NativeTypeName("LPBYTE")] byte* lppropdata, [NativeTypeName("DWORD")] uint dwProperty);

        [DllImport("Winmm", EntryPoint = "midiStreamPosition", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamPosition([NativeTypeName("HMIDISTRM")] IntPtr hms, [NativeTypeName("LPMMTIME")] MMTIME* lpmmt, [NativeTypeName("UINT")] uint cbmmt);

        [DllImport("Winmm", EntryPoint = "midiStreamOut", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamOut([NativeTypeName("HMIDISTRM")] IntPtr hms, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, [NativeTypeName("UINT")] uint cbmh);

        [DllImport("Winmm", EntryPoint = "midiStreamPause", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamPause([NativeTypeName("HMIDISTRM")] IntPtr hms);

        [DllImport("Winmm", EntryPoint = "midiStreamRestart", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamRestart([NativeTypeName("HMIDISTRM")] IntPtr hms);

        [DllImport("Winmm", EntryPoint = "midiStreamStop", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamStop([NativeTypeName("HMIDISTRM")] IntPtr hms);

        [DllImport("Winmm", EntryPoint = "midiConnect", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiConnect([NativeTypeName("HMIDI")] IntPtr hmi, [NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("LPVOID")] void* pReserved);

        [DllImport("Winmm", EntryPoint = "midiDisconnect", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiDisconnect([NativeTypeName("HMIDI")] IntPtr hmi, [NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("LPVOID")] void* pReserved);

        [DllImport("Winmm", EntryPoint = "midiOutGetDevCapsA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPMIDIOUTCAPSA")] MIDIOUTCAPSA* pmoc, [NativeTypeName("UINT")] uint cbmoc);

        [DllImport("Winmm", EntryPoint = "midiOutGetDevCapsW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPMIDIOUTCAPSW")] MIDIOUTCAPSW* pmoc, [NativeTypeName("UINT")] uint cbmoc);

        [DllImport("Winmm", EntryPoint = "midiOutGetVolume", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetVolume([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("LPDWORD")] uint* pdwVolume);

        [DllImport("Winmm", EntryPoint = "midiOutSetVolume", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutSetVolume([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("DWORD")] uint dwVolume);

        [DllImport("Winmm", EntryPoint = "midiOutGetErrorTextA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetErrorTextA([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPSTR")] sbyte* pszText, [NativeTypeName("UINT")] uint cchText);

        [DllImport("Winmm", EntryPoint = "midiOutGetErrorTextW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetErrorTextW([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPWSTR")] ushort* pszText, [NativeTypeName("UINT")] uint cchText);

        [DllImport("Winmm", EntryPoint = "midiOutOpen", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutOpen([NativeTypeName("LPHMIDIOUT")] IntPtr* phmo, [NativeTypeName("UINT")] uint uDeviceID, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("Winmm", EntryPoint = "midiOutClose", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutClose([NativeTypeName("HMIDIOUT")] IntPtr hmo);

        [DllImport("Winmm", EntryPoint = "midiOutPrepareHeader", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutPrepareHeader([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, [NativeTypeName("UINT")] uint cbmh);

        [DllImport("Winmm", EntryPoint = "midiOutUnprepareHeader", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutUnprepareHeader([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, [NativeTypeName("UINT")] uint cbmh);

        [DllImport("Winmm", EntryPoint = "midiOutShortMsg", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutShortMsg([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("DWORD")] uint dwMsg);

        [DllImport("Winmm", EntryPoint = "midiOutLongMsg", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutLongMsg([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, [NativeTypeName("UINT")] uint cbmh);

        [DllImport("Winmm", EntryPoint = "midiOutReset", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutReset([NativeTypeName("HMIDIOUT")] IntPtr hmo);

        [DllImport("Winmm", EntryPoint = "midiOutCachePatches", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutCachePatches([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("UINT")] uint uBank, [NativeTypeName("LPWORD")] ushort* pwpa, [NativeTypeName("UINT")] uint fuCache);

        [DllImport("Winmm", EntryPoint = "midiOutCacheDrumPatches", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutCacheDrumPatches([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("UINT")] uint uPatch, [NativeTypeName("LPWORD")] ushort* pwkya, [NativeTypeName("UINT")] uint fuCache);

        [DllImport("Winmm", EntryPoint = "midiOutGetID", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetID([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("LPUINT")] uint* puDeviceID);

        [DllImport("Winmm", EntryPoint = "midiOutMessage", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutMessage([NativeTypeName("HMIDIOUT")] IntPtr hmo, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("Winmm", EntryPoint = "midiInGetNumDevs", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint midiInGetNumDevs();

        [DllImport("Winmm", EntryPoint = "midiInGetDevCapsA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPMIDIINCAPSA")] MIDIINCAPSA* pmic, [NativeTypeName("UINT")] uint cbmic);

        [DllImport("Winmm", EntryPoint = "midiInGetDevCapsW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPMIDIINCAPSW")] MIDIINCAPSW* pmic, [NativeTypeName("UINT")] uint cbmic);

        [DllImport("Winmm", EntryPoint = "midiInGetErrorTextA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetErrorTextA([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPSTR")] sbyte* pszText, [NativeTypeName("UINT")] uint cchText);

        [DllImport("Winmm", EntryPoint = "midiInGetErrorTextW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetErrorTextW([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPWSTR")] ushort* pszText, [NativeTypeName("UINT")] uint cchText);

        [DllImport("Winmm", EntryPoint = "midiInOpen", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInOpen([NativeTypeName("LPHMIDIIN")] IntPtr* phmi, [NativeTypeName("UINT")] uint uDeviceID, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("Winmm", EntryPoint = "midiInClose", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInClose([NativeTypeName("HMIDIIN")] IntPtr hmi);

        [DllImport("Winmm", EntryPoint = "midiInPrepareHeader", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInPrepareHeader([NativeTypeName("HMIDIIN")] IntPtr hmi, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, [NativeTypeName("UINT")] uint cbmh);

        [DllImport("Winmm", EntryPoint = "midiInUnprepareHeader", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInUnprepareHeader([NativeTypeName("HMIDIIN")] IntPtr hmi, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, [NativeTypeName("UINT")] uint cbmh);

        [DllImport("Winmm", EntryPoint = "midiInAddBuffer", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInAddBuffer([NativeTypeName("HMIDIIN")] IntPtr hmi, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, [NativeTypeName("UINT")] uint cbmh);

        [DllImport("Winmm", EntryPoint = "midiInStart", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInStart([NativeTypeName("HMIDIIN")] IntPtr hmi);

        [DllImport("Winmm", EntryPoint = "midiInStop", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInStop([NativeTypeName("HMIDIIN")] IntPtr hmi);

        [DllImport("Winmm", EntryPoint = "midiInReset", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInReset([NativeTypeName("HMIDIIN")] IntPtr hmi);

        [DllImport("Winmm", EntryPoint = "midiInGetID", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetID([NativeTypeName("HMIDIIN")] IntPtr hmi, [NativeTypeName("LPUINT")] uint* puDeviceID);

        [DllImport("Winmm", EntryPoint = "midiInMessage", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInMessage([NativeTypeName("HMIDIIN")] IntPtr hmi, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("Winmm", EntryPoint = "auxGetNumDevs", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint auxGetNumDevs();

        [DllImport("Winmm", EntryPoint = "auxGetDevCapsA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPAUXCAPSA")] AUXCAPSA* pac, [NativeTypeName("UINT")] uint cbac);

        [DllImport("Winmm", EntryPoint = "auxGetDevCapsW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPAUXCAPSW")] AUXCAPSW* pac, [NativeTypeName("UINT")] uint cbac);

        [DllImport("Winmm", EntryPoint = "auxSetVolume", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxSetVolume([NativeTypeName("UINT")] uint uDeviceID, [NativeTypeName("DWORD")] uint dwVolume);

        [DllImport("Winmm", EntryPoint = "auxGetVolume", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxGetVolume([NativeTypeName("UINT")] uint uDeviceID, [NativeTypeName("LPDWORD")] uint* pdwVolume);

        [DllImport("Winmm", EntryPoint = "auxOutMessage", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxOutMessage([NativeTypeName("UINT")] uint uDeviceID, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("Winmm", EntryPoint = "mixerGetNumDevs", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint mixerGetNumDevs();

        [DllImport("Winmm", EntryPoint = "mixerGetDevCapsA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uMxId, [NativeTypeName("LPMIXERCAPSA")] MIXERCAPSA* pmxcaps, [NativeTypeName("UINT")] uint cbmxcaps);

        [DllImport("Winmm", EntryPoint = "mixerGetDevCapsW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uMxId, [NativeTypeName("LPMIXERCAPSW")] MIXERCAPSW* pmxcaps, [NativeTypeName("UINT")] uint cbmxcaps);

        [DllImport("Winmm", EntryPoint = "mixerOpen", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerOpen([NativeTypeName("LPHMIXER")] IntPtr* phmx, [NativeTypeName("UINT")] uint uMxId, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("Winmm", EntryPoint = "mixerClose", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerClose([NativeTypeName("HMIXER")] IntPtr hmx);

        [DllImport("Winmm", EntryPoint = "mixerMessage", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint mixerMessage([NativeTypeName("HMIXER")] IntPtr hmx, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dwParam1, [NativeTypeName("DWORD_PTR")] nuint dwParam2);

        [DllImport("Winmm", EntryPoint = "mixerGetLineInfoA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetLineInfoA([NativeTypeName("HMIXEROBJ")] IntPtr hmxobj, [NativeTypeName("LPMIXERLINEA")] MIXERLINEA* pmxl, [NativeTypeName("DWORD")] uint fdwInfo);

        [DllImport("Winmm", EntryPoint = "mixerGetLineInfoW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetLineInfoW([NativeTypeName("HMIXEROBJ")] IntPtr hmxobj, [NativeTypeName("LPMIXERLINEW")] MIXERLINEW* pmxl, [NativeTypeName("DWORD")] uint fdwInfo);

        [DllImport("Winmm", EntryPoint = "mixerGetID", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetID([NativeTypeName("HMIXEROBJ")] IntPtr hmxobj, [NativeTypeName("UINT *")] uint* puMxId, [NativeTypeName("DWORD")] uint fdwId);

        [DllImport("Winmm", EntryPoint = "mixerGetLineControlsA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetLineControlsA([NativeTypeName("HMIXEROBJ")] IntPtr hmxobj, [NativeTypeName("LPMIXERLINECONTROLSA")] MIXERLINECONTROLSA* pmxlc, [NativeTypeName("DWORD")] uint fdwControls);

        [DllImport("Winmm", EntryPoint = "mixerGetLineControlsW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetLineControlsW([NativeTypeName("HMIXEROBJ")] IntPtr hmxobj, [NativeTypeName("LPMIXERLINECONTROLSW")] MIXERLINECONTROLSW* pmxlc, [NativeTypeName("DWORD")] uint fdwControls);

        [DllImport("Winmm", EntryPoint = "mixerGetControlDetailsA", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetControlDetailsA([NativeTypeName("HMIXEROBJ")] IntPtr hmxobj, [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd, [NativeTypeName("DWORD")] uint fdwDetails);

        [DllImport("Winmm", EntryPoint = "mixerGetControlDetailsW", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetControlDetailsW([NativeTypeName("HMIXEROBJ")] IntPtr hmxobj, [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd, [NativeTypeName("DWORD")] uint fdwDetails);

        [DllImport("Winmm", EntryPoint = "mixerSetControlDetails", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerSetControlDetails([NativeTypeName("HMIXEROBJ")] IntPtr hmxobj, [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd, [NativeTypeName("DWORD")] uint fdwDetails);
    }
}
