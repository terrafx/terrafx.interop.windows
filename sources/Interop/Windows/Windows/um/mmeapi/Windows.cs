// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("winmm", ExactSpelling = true)]
        public static extern uint waveOutGetNumDevs();

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPWAVEOUTCAPSA")] WAVEOUTCAPSA* pwoc, uint cbwoc);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPWAVEOUTCAPSW")] WAVEOUTCAPSW* pwoc, uint cbwoc);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetVolume(HWAVEOUT hwo, [NativeTypeName("LPDWORD")] uint* pdwVolume);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutSetVolume(HWAVEOUT hwo, [NativeTypeName("DWORD")] uint dwVolume);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetErrorTextA([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPSTR")] sbyte* pszText, uint cchText);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetErrorTextW([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPWSTR")] ushort* pszText, uint cchText);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutOpen([NativeTypeName("LPHWAVEOUT")] HWAVEOUT* phwo, uint uDeviceID, [NativeTypeName("LPCWAVEFORMATEX")] WAVEFORMATEX* pwfx, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutClose(HWAVEOUT hwo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutPrepareHeader(HWAVEOUT hwo, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, uint cbwh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutUnprepareHeader(HWAVEOUT hwo, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, uint cbwh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutWrite(HWAVEOUT hwo, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, uint cbwh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutPause(HWAVEOUT hwo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutRestart(HWAVEOUT hwo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutReset(HWAVEOUT hwo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutBreakLoop(HWAVEOUT hwo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetPosition(HWAVEOUT hwo, [NativeTypeName("LPMMTIME")] MMTIME* pmmt, uint cbmmt);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetPitch(HWAVEOUT hwo, [NativeTypeName("LPDWORD")] uint* pdwPitch);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutSetPitch(HWAVEOUT hwo, [NativeTypeName("DWORD")] uint dwPitch);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetPlaybackRate(HWAVEOUT hwo, [NativeTypeName("LPDWORD")] uint* pdwRate);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutSetPlaybackRate(HWAVEOUT hwo, [NativeTypeName("DWORD")] uint dwRate);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutGetID(HWAVEOUT hwo, [NativeTypeName("LPUINT")] uint* puDeviceID);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveOutMessage(HWAVEOUT hwo, uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("winmm", ExactSpelling = true)]
        public static extern uint waveInGetNumDevs();

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPWAVEINCAPSA")] WAVEINCAPSA* pwic, uint cbwic);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPWAVEINCAPSW")] WAVEINCAPSW* pwic, uint cbwic);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetErrorTextA([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPSTR")] sbyte* pszText, uint cchText);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetErrorTextW([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPWSTR")] ushort* pszText, uint cchText);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInOpen([NativeTypeName("LPHWAVEIN")] HWAVEIN* phwi, uint uDeviceID, [NativeTypeName("LPCWAVEFORMATEX")] WAVEFORMATEX* pwfx, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInClose(HWAVEIN hwi);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInPrepareHeader(HWAVEIN hwi, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, uint cbwh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInUnprepareHeader(HWAVEIN hwi, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, uint cbwh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInAddBuffer(HWAVEIN hwi, [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh, uint cbwh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInStart(HWAVEIN hwi);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInStop(HWAVEIN hwi);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInReset(HWAVEIN hwi);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetPosition(HWAVEIN hwi, [NativeTypeName("LPMMTIME")] MMTIME* pmmt, uint cbmmt);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInGetID(HWAVEIN hwi, [NativeTypeName("LPUINT")] uint* puDeviceID);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint waveInMessage(HWAVEIN hwi, uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("winmm", ExactSpelling = true)]
        public static extern uint midiOutGetNumDevs();

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamOpen([NativeTypeName("LPHMIDISTRM")] HMIDISTRM* phms, [NativeTypeName("LPUINT")] uint* puDeviceID, [NativeTypeName("DWORD")] uint cMidi, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamClose(HMIDISTRM hms);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamProperty(HMIDISTRM hms, [NativeTypeName("LPBYTE")] byte* lppropdata, [NativeTypeName("DWORD")] uint dwProperty);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamPosition(HMIDISTRM hms, [NativeTypeName("LPMMTIME")] MMTIME* lpmmt, uint cbmmt);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamOut(HMIDISTRM hms, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, uint cbmh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamPause(HMIDISTRM hms);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamRestart(HMIDISTRM hms);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiStreamStop(HMIDISTRM hms);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiConnect(HMIDI hmi, HMIDIOUT hmo, [NativeTypeName("LPVOID")] void* pReserved);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiDisconnect(HMIDI hmi, HMIDIOUT hmo, [NativeTypeName("LPVOID")] void* pReserved);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPMIDIOUTCAPSA")] MIDIOUTCAPSA* pmoc, uint cbmoc);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPMIDIOUTCAPSW")] MIDIOUTCAPSW* pmoc, uint cbmoc);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetVolume(HMIDIOUT hmo, [NativeTypeName("LPDWORD")] uint* pdwVolume);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutSetVolume(HMIDIOUT hmo, [NativeTypeName("DWORD")] uint dwVolume);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetErrorTextA([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPSTR")] sbyte* pszText, uint cchText);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetErrorTextW([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPWSTR")] ushort* pszText, uint cchText);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutOpen([NativeTypeName("LPHMIDIOUT")] HMIDIOUT* phmo, uint uDeviceID, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutClose(HMIDIOUT hmo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutPrepareHeader(HMIDIOUT hmo, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, uint cbmh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutUnprepareHeader(HMIDIOUT hmo, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, uint cbmh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutShortMsg(HMIDIOUT hmo, [NativeTypeName("DWORD")] uint dwMsg);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutLongMsg(HMIDIOUT hmo, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, uint cbmh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutReset(HMIDIOUT hmo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutCachePatches(HMIDIOUT hmo, uint uBank, [NativeTypeName("LPWORD")] ushort* pwpa, uint fuCache);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutCacheDrumPatches(HMIDIOUT hmo, uint uPatch, [NativeTypeName("LPWORD")] ushort* pwkya, uint fuCache);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutGetID(HMIDIOUT hmo, [NativeTypeName("LPUINT")] uint* puDeviceID);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiOutMessage(HMIDIOUT hmo, uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("winmm", ExactSpelling = true)]
        public static extern uint midiInGetNumDevs();

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPMIDIINCAPSA")] MIDIINCAPSA* pmic, uint cbmic);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPMIDIINCAPSW")] MIDIINCAPSW* pmic, uint cbmic);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetErrorTextA([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPSTR")] sbyte* pszText, uint cchText);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetErrorTextW([NativeTypeName("MMRESULT")] uint mmrError, [NativeTypeName("LPWSTR")] ushort* pszText, uint cchText);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInOpen([NativeTypeName("LPHMIDIIN")] HMIDIIN* phmi, uint uDeviceID, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInClose(HMIDIIN hmi);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInPrepareHeader(HMIDIIN hmi, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, uint cbmh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInUnprepareHeader(HMIDIIN hmi, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, uint cbmh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInAddBuffer(HMIDIIN hmi, [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh, uint cbmh);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInStart(HMIDIIN hmi);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInStop(HMIDIIN hmi);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInReset(HMIDIIN hmi);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInGetID(HMIDIIN hmi, [NativeTypeName("LPUINT")] uint* puDeviceID);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint midiInMessage(HMIDIIN hmi, uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("winmm", ExactSpelling = true)]
        public static extern uint auxGetNumDevs();

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPAUXCAPSA")] AUXCAPSA* pac, uint cbac);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uDeviceID, [NativeTypeName("LPAUXCAPSW")] AUXCAPSW* pac, uint cbac);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxSetVolume(uint uDeviceID, [NativeTypeName("DWORD")] uint dwVolume);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxGetVolume(uint uDeviceID, [NativeTypeName("LPDWORD")] uint* pdwVolume);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint auxOutMessage(uint uDeviceID, uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dw1, [NativeTypeName("DWORD_PTR")] nuint dw2);

        [DllImport("winmm", ExactSpelling = true)]
        public static extern uint mixerGetNumDevs();

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetDevCapsA([NativeTypeName("UINT_PTR")] nuint uMxId, [NativeTypeName("LPMIXERCAPSA")] MIXERCAPSA* pmxcaps, uint cbmxcaps);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetDevCapsW([NativeTypeName("UINT_PTR")] nuint uMxId, [NativeTypeName("LPMIXERCAPSW")] MIXERCAPSW* pmxcaps, uint cbmxcaps);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerOpen([NativeTypeName("LPHMIXER")] HMIXER* phmx, uint uMxId, [NativeTypeName("DWORD_PTR")] nuint dwCallback, [NativeTypeName("DWORD_PTR")] nuint dwInstance, [NativeTypeName("DWORD")] uint fdwOpen);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerClose(HMIXER hmx);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint mixerMessage(HMIXER hmx, uint uMsg, [NativeTypeName("DWORD_PTR")] nuint dwParam1, [NativeTypeName("DWORD_PTR")] nuint dwParam2);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetLineInfoA(HMIXEROBJ hmxobj, [NativeTypeName("LPMIXERLINEA")] MIXERLINEA* pmxl, [NativeTypeName("DWORD")] uint fdwInfo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetLineInfoW(HMIXEROBJ hmxobj, [NativeTypeName("LPMIXERLINEW")] MIXERLINEW* pmxl, [NativeTypeName("DWORD")] uint fdwInfo);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetID(HMIXEROBJ hmxobj, uint* puMxId, [NativeTypeName("DWORD")] uint fdwId);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetLineControlsA(HMIXEROBJ hmxobj, [NativeTypeName("LPMIXERLINECONTROLSA")] MIXERLINECONTROLSA* pmxlc, [NativeTypeName("DWORD")] uint fdwControls);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetLineControlsW(HMIXEROBJ hmxobj, [NativeTypeName("LPMIXERLINECONTROLSW")] MIXERLINECONTROLSW* pmxlc, [NativeTypeName("DWORD")] uint fdwControls);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetControlDetailsA(HMIXEROBJ hmxobj, [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd, [NativeTypeName("DWORD")] uint fdwDetails);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerGetControlDetailsW(HMIXEROBJ hmxobj, [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd, [NativeTypeName("DWORD")] uint fdwDetails);

        [DllImport("winmm", ExactSpelling = true)]
        [return: NativeTypeName("MMRESULT")]
        public static extern uint mixerSetControlDetails(HMIXEROBJ hmxobj, [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd, [NativeTypeName("DWORD")] uint fdwDetails);

        [NativeTypeName("#define WAVERR_BADFORMAT (WAVERR_BASE + 0)")]
        public const int WAVERR_BADFORMAT = (32 + 0);

        [NativeTypeName("#define WAVERR_STILLPLAYING (WAVERR_BASE + 1)")]
        public const int WAVERR_STILLPLAYING = (32 + 1);

        [NativeTypeName("#define WAVERR_UNPREPARED (WAVERR_BASE + 2)")]
        public const int WAVERR_UNPREPARED = (32 + 2);

        [NativeTypeName("#define WAVERR_SYNC (WAVERR_BASE + 3)")]
        public const int WAVERR_SYNC = (32 + 3);

        [NativeTypeName("#define WAVERR_LASTERROR (WAVERR_BASE + 3)")]
        public const int WAVERR_LASTERROR = (32 + 3);

        [NativeTypeName("#define WOM_OPEN MM_WOM_OPEN")]
        public const int WOM_OPEN = 0x3BB;

        [NativeTypeName("#define WOM_CLOSE MM_WOM_CLOSE")]
        public const int WOM_CLOSE = 0x3BC;

        [NativeTypeName("#define WOM_DONE MM_WOM_DONE")]
        public const int WOM_DONE = 0x3BD;

        [NativeTypeName("#define WIM_OPEN MM_WIM_OPEN")]
        public const int WIM_OPEN = 0x3BE;

        [NativeTypeName("#define WIM_CLOSE MM_WIM_CLOSE")]
        public const int WIM_CLOSE = 0x3BF;

        [NativeTypeName("#define WIM_DATA MM_WIM_DATA")]
        public const int WIM_DATA = 0x3C0;

        [NativeTypeName("#define WAVE_MAPPER ((UINT)-1)")]
        public const uint WAVE_MAPPER = unchecked((uint)(-1));

        [NativeTypeName("#define WAVE_FORMAT_QUERY 0x0001")]
        public const int WAVE_FORMAT_QUERY = 0x0001;

        [NativeTypeName("#define WAVE_ALLOWSYNC 0x0002")]
        public const int WAVE_ALLOWSYNC = 0x0002;

        [NativeTypeName("#define WAVE_MAPPED 0x0004")]
        public const int WAVE_MAPPED = 0x0004;

        [NativeTypeName("#define WAVE_FORMAT_DIRECT 0x0008")]
        public const int WAVE_FORMAT_DIRECT = 0x0008;

        [NativeTypeName("#define WAVE_FORMAT_DIRECT_QUERY (WAVE_FORMAT_QUERY | WAVE_FORMAT_DIRECT)")]
        public const int WAVE_FORMAT_DIRECT_QUERY = (0x0001 | 0x0008);

        [NativeTypeName("#define WAVE_MAPPED_DEFAULT_COMMUNICATION_DEVICE 0x0010")]
        public const int WAVE_MAPPED_DEFAULT_COMMUNICATION_DEVICE = 0x0010;

        [NativeTypeName("#define WHDR_DONE 0x00000001")]
        public const int WHDR_DONE = 0x00000001;

        [NativeTypeName("#define WHDR_PREPARED 0x00000002")]
        public const int WHDR_PREPARED = 0x00000002;

        [NativeTypeName("#define WHDR_BEGINLOOP 0x00000004")]
        public const int WHDR_BEGINLOOP = 0x00000004;

        [NativeTypeName("#define WHDR_ENDLOOP 0x00000008")]
        public const int WHDR_ENDLOOP = 0x00000008;

        [NativeTypeName("#define WHDR_INQUEUE 0x00000010")]
        public const int WHDR_INQUEUE = 0x00000010;

        [NativeTypeName("#define WAVECAPS_PITCH 0x0001")]
        public const int WAVECAPS_PITCH = 0x0001;

        [NativeTypeName("#define WAVECAPS_PLAYBACKRATE 0x0002")]
        public const int WAVECAPS_PLAYBACKRATE = 0x0002;

        [NativeTypeName("#define WAVECAPS_VOLUME 0x0004")]
        public const int WAVECAPS_VOLUME = 0x0004;

        [NativeTypeName("#define WAVECAPS_LRVOLUME 0x0008")]
        public const int WAVECAPS_LRVOLUME = 0x0008;

        [NativeTypeName("#define WAVECAPS_SYNC 0x0010")]
        public const int WAVECAPS_SYNC = 0x0010;

        [NativeTypeName("#define WAVECAPS_SAMPLEACCURATE 0x0020")]
        public const int WAVECAPS_SAMPLEACCURATE = 0x0020;

        [NativeTypeName("#define WAVE_INVALIDFORMAT 0x00000000")]
        public const int WAVE_INVALIDFORMAT = 0x00000000;

        [NativeTypeName("#define WAVE_FORMAT_1M08 0x00000001")]
        public const int WAVE_FORMAT_1M08 = 0x00000001;

        [NativeTypeName("#define WAVE_FORMAT_1S08 0x00000002")]
        public const int WAVE_FORMAT_1S08 = 0x00000002;

        [NativeTypeName("#define WAVE_FORMAT_1M16 0x00000004")]
        public const int WAVE_FORMAT_1M16 = 0x00000004;

        [NativeTypeName("#define WAVE_FORMAT_1S16 0x00000008")]
        public const int WAVE_FORMAT_1S16 = 0x00000008;

        [NativeTypeName("#define WAVE_FORMAT_2M08 0x00000010")]
        public const int WAVE_FORMAT_2M08 = 0x00000010;

        [NativeTypeName("#define WAVE_FORMAT_2S08 0x00000020")]
        public const int WAVE_FORMAT_2S08 = 0x00000020;

        [NativeTypeName("#define WAVE_FORMAT_2M16 0x00000040")]
        public const int WAVE_FORMAT_2M16 = 0x00000040;

        [NativeTypeName("#define WAVE_FORMAT_2S16 0x00000080")]
        public const int WAVE_FORMAT_2S16 = 0x00000080;

        [NativeTypeName("#define WAVE_FORMAT_4M08 0x00000100")]
        public const int WAVE_FORMAT_4M08 = 0x00000100;

        [NativeTypeName("#define WAVE_FORMAT_4S08 0x00000200")]
        public const int WAVE_FORMAT_4S08 = 0x00000200;

        [NativeTypeName("#define WAVE_FORMAT_4M16 0x00000400")]
        public const int WAVE_FORMAT_4M16 = 0x00000400;

        [NativeTypeName("#define WAVE_FORMAT_4S16 0x00000800")]
        public const int WAVE_FORMAT_4S16 = 0x00000800;

        [NativeTypeName("#define WAVE_FORMAT_44M08 0x00000100")]
        public const int WAVE_FORMAT_44M08 = 0x00000100;

        [NativeTypeName("#define WAVE_FORMAT_44S08 0x00000200")]
        public const int WAVE_FORMAT_44S08 = 0x00000200;

        [NativeTypeName("#define WAVE_FORMAT_44M16 0x00000400")]
        public const int WAVE_FORMAT_44M16 = 0x00000400;

        [NativeTypeName("#define WAVE_FORMAT_44S16 0x00000800")]
        public const int WAVE_FORMAT_44S16 = 0x00000800;

        [NativeTypeName("#define WAVE_FORMAT_48M08 0x00001000")]
        public const int WAVE_FORMAT_48M08 = 0x00001000;

        [NativeTypeName("#define WAVE_FORMAT_48S08 0x00002000")]
        public const int WAVE_FORMAT_48S08 = 0x00002000;

        [NativeTypeName("#define WAVE_FORMAT_48M16 0x00004000")]
        public const int WAVE_FORMAT_48M16 = 0x00004000;

        [NativeTypeName("#define WAVE_FORMAT_48S16 0x00008000")]
        public const int WAVE_FORMAT_48S16 = 0x00008000;

        [NativeTypeName("#define WAVE_FORMAT_96M08 0x00010000")]
        public const int WAVE_FORMAT_96M08 = 0x00010000;

        [NativeTypeName("#define WAVE_FORMAT_96S08 0x00020000")]
        public const int WAVE_FORMAT_96S08 = 0x00020000;

        [NativeTypeName("#define WAVE_FORMAT_96M16 0x00040000")]
        public const int WAVE_FORMAT_96M16 = 0x00040000;

        [NativeTypeName("#define WAVE_FORMAT_96S16 0x00080000")]
        public const int WAVE_FORMAT_96S16 = 0x00080000;

        [NativeTypeName("#define WAVE_FORMAT_PCM 1")]
        public const int WAVE_FORMAT_PCM = 1;

        [NativeTypeName("#define waveOutGetDevCaps waveOutGetDevCapsW")]
        public static delegate*<nuint, WAVEOUTCAPSW*, uint, uint> waveOutGetDevCaps => &waveOutGetDevCapsW;

        [NativeTypeName("#define waveOutGetErrorText waveOutGetErrorTextW")]
        public static delegate*<uint, ushort*, uint, uint> waveOutGetErrorText => &waveOutGetErrorTextW;

        [NativeTypeName("#define waveInGetDevCaps waveInGetDevCapsW")]
        public static delegate*<nuint, WAVEINCAPSW*, uint, uint> waveInGetDevCaps => &waveInGetDevCapsW;

        [NativeTypeName("#define waveInGetErrorText waveInGetErrorTextW")]
        public static delegate*<uint, ushort*, uint, uint> waveInGetErrorText => &waveInGetErrorTextW;

        [NativeTypeName("#define MIDIERR_UNPREPARED (MIDIERR_BASE + 0)")]
        public const int MIDIERR_UNPREPARED = (64 + 0);

        [NativeTypeName("#define MIDIERR_STILLPLAYING (MIDIERR_BASE + 1)")]
        public const int MIDIERR_STILLPLAYING = (64 + 1);

        [NativeTypeName("#define MIDIERR_NOMAP (MIDIERR_BASE + 2)")]
        public const int MIDIERR_NOMAP = (64 + 2);

        [NativeTypeName("#define MIDIERR_NOTREADY (MIDIERR_BASE + 3)")]
        public const int MIDIERR_NOTREADY = (64 + 3);

        [NativeTypeName("#define MIDIERR_NODEVICE (MIDIERR_BASE + 4)")]
        public const int MIDIERR_NODEVICE = (64 + 4);

        [NativeTypeName("#define MIDIERR_INVALIDSETUP (MIDIERR_BASE + 5)")]
        public const int MIDIERR_INVALIDSETUP = (64 + 5);

        [NativeTypeName("#define MIDIERR_BADOPENMODE (MIDIERR_BASE + 6)")]
        public const int MIDIERR_BADOPENMODE = (64 + 6);

        [NativeTypeName("#define MIDIERR_DONT_CONTINUE (MIDIERR_BASE + 7)")]
        public const int MIDIERR_DONT_CONTINUE = (64 + 7);

        [NativeTypeName("#define MIDIERR_LASTERROR (MIDIERR_BASE + 7)")]
        public const int MIDIERR_LASTERROR = (64 + 7);

        [NativeTypeName("#define MIDIPATCHSIZE 128")]
        public const int MIDIPATCHSIZE = 128;

        [NativeTypeName("#define MIM_OPEN MM_MIM_OPEN")]
        public const int MIM_OPEN = 0x3C1;

        [NativeTypeName("#define MIM_CLOSE MM_MIM_CLOSE")]
        public const int MIM_CLOSE = 0x3C2;

        [NativeTypeName("#define MIM_DATA MM_MIM_DATA")]
        public const int MIM_DATA = 0x3C3;

        [NativeTypeName("#define MIM_LONGDATA MM_MIM_LONGDATA")]
        public const int MIM_LONGDATA = 0x3C4;

        [NativeTypeName("#define MIM_ERROR MM_MIM_ERROR")]
        public const int MIM_ERROR = 0x3C5;

        [NativeTypeName("#define MIM_LONGERROR MM_MIM_LONGERROR")]
        public const int MIM_LONGERROR = 0x3C6;

        [NativeTypeName("#define MOM_OPEN MM_MOM_OPEN")]
        public const int MOM_OPEN = 0x3C7;

        [NativeTypeName("#define MOM_CLOSE MM_MOM_CLOSE")]
        public const int MOM_CLOSE = 0x3C8;

        [NativeTypeName("#define MOM_DONE MM_MOM_DONE")]
        public const int MOM_DONE = 0x3C9;

        [NativeTypeName("#define MIM_MOREDATA MM_MIM_MOREDATA")]
        public const int MIM_MOREDATA = 0x3CC;

        [NativeTypeName("#define MOM_POSITIONCB MM_MOM_POSITIONCB")]
        public const int MOM_POSITIONCB = 0x3CA;

        [NativeTypeName("#define MIDIMAPPER ((UINT)-1)")]
        public const uint MIDIMAPPER = unchecked((uint)(-1));

        [NativeTypeName("#define MIDI_MAPPER ((UINT)-1)")]
        public const uint MIDI_MAPPER = unchecked((uint)(-1));

        [NativeTypeName("#define MIDI_IO_STATUS 0x00000020L")]
        public const int MIDI_IO_STATUS = 0x00000020;

        [NativeTypeName("#define MIDI_CACHE_ALL 1")]
        public const int MIDI_CACHE_ALL = 1;

        [NativeTypeName("#define MIDI_CACHE_BESTFIT 2")]
        public const int MIDI_CACHE_BESTFIT = 2;

        [NativeTypeName("#define MIDI_CACHE_QUERY 3")]
        public const int MIDI_CACHE_QUERY = 3;

        [NativeTypeName("#define MIDI_UNCACHE 4")]
        public const int MIDI_UNCACHE = 4;

        [NativeTypeName("#define MOD_MIDIPORT 1")]
        public const int MOD_MIDIPORT = 1;

        [NativeTypeName("#define MOD_SYNTH 2")]
        public const int MOD_SYNTH = 2;

        [NativeTypeName("#define MOD_SQSYNTH 3")]
        public const int MOD_SQSYNTH = 3;

        [NativeTypeName("#define MOD_FMSYNTH 4")]
        public const int MOD_FMSYNTH = 4;

        [NativeTypeName("#define MOD_MAPPER 5")]
        public const int MOD_MAPPER = 5;

        [NativeTypeName("#define MOD_WAVETABLE 6")]
        public const int MOD_WAVETABLE = 6;

        [NativeTypeName("#define MOD_SWSYNTH 7")]
        public const int MOD_SWSYNTH = 7;

        [NativeTypeName("#define MIDICAPS_VOLUME 0x0001")]
        public const int MIDICAPS_VOLUME = 0x0001;

        [NativeTypeName("#define MIDICAPS_LRVOLUME 0x0002")]
        public const int MIDICAPS_LRVOLUME = 0x0002;

        [NativeTypeName("#define MIDICAPS_CACHE 0x0004")]
        public const int MIDICAPS_CACHE = 0x0004;

        [NativeTypeName("#define MIDICAPS_STREAM 0x0008")]
        public const int MIDICAPS_STREAM = 0x0008;

        [NativeTypeName("#define MHDR_DONE 0x00000001")]
        public const int MHDR_DONE = 0x00000001;

        [NativeTypeName("#define MHDR_PREPARED 0x00000002")]
        public const int MHDR_PREPARED = 0x00000002;

        [NativeTypeName("#define MHDR_INQUEUE 0x00000004")]
        public const int MHDR_INQUEUE = 0x00000004;

        [NativeTypeName("#define MHDR_ISSTRM 0x00000008")]
        public const int MHDR_ISSTRM = 0x00000008;

        [NativeTypeName("#define MEVT_F_SHORT 0x00000000L")]
        public const int MEVT_F_SHORT = 0x00000000;

        [NativeTypeName("#define MEVT_F_LONG 0x80000000L")]
        public const uint MEVT_F_LONG = 0x80000000;

        [NativeTypeName("#define MEVT_F_CALLBACK 0x40000000L")]
        public const int MEVT_F_CALLBACK = 0x40000000;

        [NativeTypeName("#define MEVT_SHORTMSG ((BYTE)0x00)")]
        public const byte MEVT_SHORTMSG = ((byte)(0x00));

        [NativeTypeName("#define MEVT_TEMPO ((BYTE)0x01)")]
        public const byte MEVT_TEMPO = ((byte)(0x01));

        [NativeTypeName("#define MEVT_NOP ((BYTE)0x02)")]
        public const byte MEVT_NOP = ((byte)(0x02));

        [NativeTypeName("#define MEVT_LONGMSG ((BYTE)0x80)")]
        public const byte MEVT_LONGMSG = ((byte)(0x80));

        [NativeTypeName("#define MEVT_COMMENT ((BYTE)0x82)")]
        public const byte MEVT_COMMENT = ((byte)(0x82));

        [NativeTypeName("#define MEVT_VERSION ((BYTE)0x84)")]
        public const byte MEVT_VERSION = ((byte)(0x84));

        [NativeTypeName("#define MIDISTRM_ERROR (-2)")]
        public const int MIDISTRM_ERROR = (-2);

        [NativeTypeName("#define MIDIPROP_SET 0x80000000L")]
        public const uint MIDIPROP_SET = 0x80000000;

        [NativeTypeName("#define MIDIPROP_GET 0x40000000L")]
        public const int MIDIPROP_GET = 0x40000000;

        [NativeTypeName("#define MIDIPROP_TIMEDIV 0x00000001L")]
        public const int MIDIPROP_TIMEDIV = 0x00000001;

        [NativeTypeName("#define MIDIPROP_TEMPO 0x00000002L")]
        public const int MIDIPROP_TEMPO = 0x00000002;

        [NativeTypeName("#define midiOutGetDevCaps midiOutGetDevCapsW")]
        public static delegate*<nuint, MIDIOUTCAPSW*, uint, uint> midiOutGetDevCaps => &midiOutGetDevCapsW;

        [NativeTypeName("#define midiOutGetErrorText midiOutGetErrorTextW")]
        public static delegate*<uint, ushort*, uint, uint> midiOutGetErrorText => &midiOutGetErrorTextW;

        [NativeTypeName("#define midiInGetDevCaps midiInGetDevCapsW")]
        public static delegate*<nuint, MIDIINCAPSW*, uint, uint> midiInGetDevCaps => &midiInGetDevCapsW;

        [NativeTypeName("#define midiInGetErrorText midiInGetErrorTextW")]
        public static delegate*<uint, ushort*, uint, uint> midiInGetErrorText => &midiInGetErrorTextW;

        [NativeTypeName("#define AUX_MAPPER ((UINT)-1)")]
        public const uint AUX_MAPPER = unchecked((uint)(-1));

        [NativeTypeName("#define AUXCAPS_CDAUDIO 1")]
        public const int AUXCAPS_CDAUDIO = 1;

        [NativeTypeName("#define AUXCAPS_AUXIN 2")]
        public const int AUXCAPS_AUXIN = 2;

        [NativeTypeName("#define AUXCAPS_VOLUME 0x0001")]
        public const int AUXCAPS_VOLUME = 0x0001;

        [NativeTypeName("#define AUXCAPS_LRVOLUME 0x0002")]
        public const int AUXCAPS_LRVOLUME = 0x0002;

        [NativeTypeName("#define auxGetDevCaps auxGetDevCapsW")]
        public static delegate*<nuint, AUXCAPSW*, uint, uint> auxGetDevCaps => &auxGetDevCapsW;

        [NativeTypeName("#define MIXER_SHORT_NAME_CHARS 16")]
        public const int MIXER_SHORT_NAME_CHARS = 16;

        [NativeTypeName("#define MIXER_LONG_NAME_CHARS 64")]
        public const int MIXER_LONG_NAME_CHARS = 64;

        [NativeTypeName("#define MIXERR_INVALLINE (MIXERR_BASE + 0)")]
        public const int MIXERR_INVALLINE = (1024 + 0);

        [NativeTypeName("#define MIXERR_INVALCONTROL (MIXERR_BASE + 1)")]
        public const int MIXERR_INVALCONTROL = (1024 + 1);

        [NativeTypeName("#define MIXERR_INVALVALUE (MIXERR_BASE + 2)")]
        public const int MIXERR_INVALVALUE = (1024 + 2);

        [NativeTypeName("#define MIXERR_LASTERROR (MIXERR_BASE + 2)")]
        public const int MIXERR_LASTERROR = (1024 + 2);

        [NativeTypeName("#define MIXER_OBJECTF_HANDLE 0x80000000L")]
        public const uint MIXER_OBJECTF_HANDLE = 0x80000000;

        [NativeTypeName("#define MIXER_OBJECTF_MIXER 0x00000000L")]
        public const int MIXER_OBJECTF_MIXER = 0x00000000;

        [NativeTypeName("#define MIXER_OBJECTF_HMIXER (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIXER)")]
        public const uint MIXER_OBJECTF_HMIXER = (0x80000000 | 0x00000000);

        [NativeTypeName("#define MIXER_OBJECTF_WAVEOUT 0x10000000L")]
        public const int MIXER_OBJECTF_WAVEOUT = 0x10000000;

        [NativeTypeName("#define MIXER_OBJECTF_HWAVEOUT (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEOUT)")]
        public const uint MIXER_OBJECTF_HWAVEOUT = (0x80000000 | 0x10000000);

        [NativeTypeName("#define MIXER_OBJECTF_WAVEIN 0x20000000L")]
        public const int MIXER_OBJECTF_WAVEIN = 0x20000000;

        [NativeTypeName("#define MIXER_OBJECTF_HWAVEIN (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEIN)")]
        public const uint MIXER_OBJECTF_HWAVEIN = (0x80000000 | 0x20000000);

        [NativeTypeName("#define MIXER_OBJECTF_MIDIOUT 0x30000000L")]
        public const int MIXER_OBJECTF_MIDIOUT = 0x30000000;

        [NativeTypeName("#define MIXER_OBJECTF_HMIDIOUT (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIOUT)")]
        public const uint MIXER_OBJECTF_HMIDIOUT = (0x80000000 | 0x30000000);

        [NativeTypeName("#define MIXER_OBJECTF_MIDIIN 0x40000000L")]
        public const int MIXER_OBJECTF_MIDIIN = 0x40000000;

        [NativeTypeName("#define MIXER_OBJECTF_HMIDIIN (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIIN)")]
        public const uint MIXER_OBJECTF_HMIDIIN = (0x80000000 | 0x40000000);

        [NativeTypeName("#define MIXER_OBJECTF_AUX 0x50000000L")]
        public const int MIXER_OBJECTF_AUX = 0x50000000;

        [NativeTypeName("#define mixerGetDevCaps mixerGetDevCapsW")]
        public static delegate*<nuint, MIXERCAPSW*, uint, uint> mixerGetDevCaps => &mixerGetDevCapsW;

        [NativeTypeName("#define MIXERLINE_LINEF_ACTIVE 0x00000001L")]
        public const int MIXERLINE_LINEF_ACTIVE = 0x00000001;

        [NativeTypeName("#define MIXERLINE_LINEF_DISCONNECTED 0x00008000L")]
        public const int MIXERLINE_LINEF_DISCONNECTED = 0x00008000;

        [NativeTypeName("#define MIXERLINE_LINEF_SOURCE 0x80000000L")]
        public const uint MIXERLINE_LINEF_SOURCE = 0x80000000;

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_FIRST 0x00000000L")]
        public const int MIXERLINE_COMPONENTTYPE_DST_FIRST = 0x00000000;

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_UNDEFINED (MIXERLINE_COMPONENTTYPE_DST_FIRST + 0)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_UNDEFINED = (0x00000000 + 0);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_DIGITAL (MIXERLINE_COMPONENTTYPE_DST_FIRST + 1)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_DIGITAL = (0x00000000 + 1);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_LINE (MIXERLINE_COMPONENTTYPE_DST_FIRST + 2)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_LINE = (0x00000000 + 2);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_MONITOR (MIXERLINE_COMPONENTTYPE_DST_FIRST + 3)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_MONITOR = (0x00000000 + 3);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_SPEAKERS (MIXERLINE_COMPONENTTYPE_DST_FIRST + 4)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_SPEAKERS = (0x00000000 + 4);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_HEADPHONES (MIXERLINE_COMPONENTTYPE_DST_FIRST + 5)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_HEADPHONES = (0x00000000 + 5);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_TELEPHONE (MIXERLINE_COMPONENTTYPE_DST_FIRST + 6)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_TELEPHONE = (0x00000000 + 6);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_WAVEIN (MIXERLINE_COMPONENTTYPE_DST_FIRST + 7)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_WAVEIN = (0x00000000 + 7);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_VOICEIN (MIXERLINE_COMPONENTTYPE_DST_FIRST + 8)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_VOICEIN = (0x00000000 + 8);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_DST_LAST (MIXERLINE_COMPONENTTYPE_DST_FIRST + 8)")]
        public const int MIXERLINE_COMPONENTTYPE_DST_LAST = (0x00000000 + 8);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_FIRST 0x00001000L")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_FIRST = 0x00001000;

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_UNDEFINED (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 0)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_UNDEFINED = (0x00001000 + 0);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_DIGITAL (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 1)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_DIGITAL = (0x00001000 + 1);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_LINE (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 2)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_LINE = (0x00001000 + 2);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_MICROPHONE (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 3)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_MICROPHONE = (0x00001000 + 3);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_SYNTHESIZER (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 4)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_SYNTHESIZER = (0x00001000 + 4);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_COMPACTDISC (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 5)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_COMPACTDISC = (0x00001000 + 5);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_TELEPHONE (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 6)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_TELEPHONE = (0x00001000 + 6);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_PCSPEAKER (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 7)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_PCSPEAKER = (0x00001000 + 7);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_WAVEOUT (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 8)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_WAVEOUT = (0x00001000 + 8);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_AUXILIARY (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 9)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_AUXILIARY = (0x00001000 + 9);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_ANALOG (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_ANALOG = (0x00001000 + 10);

        [NativeTypeName("#define MIXERLINE_COMPONENTTYPE_SRC_LAST (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10)")]
        public const int MIXERLINE_COMPONENTTYPE_SRC_LAST = (0x00001000 + 10);

        [NativeTypeName("#define MIXERLINE_TARGETTYPE_UNDEFINED 0")]
        public const int MIXERLINE_TARGETTYPE_UNDEFINED = 0;

        [NativeTypeName("#define MIXERLINE_TARGETTYPE_WAVEOUT 1")]
        public const int MIXERLINE_TARGETTYPE_WAVEOUT = 1;

        [NativeTypeName("#define MIXERLINE_TARGETTYPE_WAVEIN 2")]
        public const int MIXERLINE_TARGETTYPE_WAVEIN = 2;

        [NativeTypeName("#define MIXERLINE_TARGETTYPE_MIDIOUT 3")]
        public const int MIXERLINE_TARGETTYPE_MIDIOUT = 3;

        [NativeTypeName("#define MIXERLINE_TARGETTYPE_MIDIIN 4")]
        public const int MIXERLINE_TARGETTYPE_MIDIIN = 4;

        [NativeTypeName("#define MIXERLINE_TARGETTYPE_AUX 5")]
        public const int MIXERLINE_TARGETTYPE_AUX = 5;

        [NativeTypeName("#define mixerGetLineInfo mixerGetLineInfoW")]
        public static delegate*<HMIXEROBJ, MIXERLINEW*, uint, uint> mixerGetLineInfo => &mixerGetLineInfoW;

        [NativeTypeName("#define MIXER_GETLINEINFOF_DESTINATION 0x00000000L")]
        public const int MIXER_GETLINEINFOF_DESTINATION = 0x00000000;

        [NativeTypeName("#define MIXER_GETLINEINFOF_SOURCE 0x00000001L")]
        public const int MIXER_GETLINEINFOF_SOURCE = 0x00000001;

        [NativeTypeName("#define MIXER_GETLINEINFOF_LINEID 0x00000002L")]
        public const int MIXER_GETLINEINFOF_LINEID = 0x00000002;

        [NativeTypeName("#define MIXER_GETLINEINFOF_COMPONENTTYPE 0x00000003L")]
        public const int MIXER_GETLINEINFOF_COMPONENTTYPE = 0x00000003;

        [NativeTypeName("#define MIXER_GETLINEINFOF_TARGETTYPE 0x00000004L")]
        public const int MIXER_GETLINEINFOF_TARGETTYPE = 0x00000004;

        [NativeTypeName("#define MIXER_GETLINEINFOF_QUERYMASK 0x0000000FL")]
        public const int MIXER_GETLINEINFOF_QUERYMASK = 0x0000000F;

        [NativeTypeName("#define MIXERCONTROL_CONTROLF_UNIFORM 0x00000001L")]
        public const int MIXERCONTROL_CONTROLF_UNIFORM = 0x00000001;

        [NativeTypeName("#define MIXERCONTROL_CONTROLF_MULTIPLE 0x00000002L")]
        public const int MIXERCONTROL_CONTROLF_MULTIPLE = 0x00000002;

        [NativeTypeName("#define MIXERCONTROL_CONTROLF_DISABLED 0x80000000L")]
        public const uint MIXERCONTROL_CONTROLF_DISABLED = 0x80000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_MASK 0xF0000000L")]
        public const uint MIXERCONTROL_CT_CLASS_MASK = 0xF0000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_CUSTOM 0x00000000L")]
        public const int MIXERCONTROL_CT_CLASS_CUSTOM = 0x00000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_METER 0x10000000L")]
        public const int MIXERCONTROL_CT_CLASS_METER = 0x10000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_SWITCH 0x20000000L")]
        public const int MIXERCONTROL_CT_CLASS_SWITCH = 0x20000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_NUMBER 0x30000000L")]
        public const int MIXERCONTROL_CT_CLASS_NUMBER = 0x30000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_SLIDER 0x40000000L")]
        public const int MIXERCONTROL_CT_CLASS_SLIDER = 0x40000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_FADER 0x50000000L")]
        public const int MIXERCONTROL_CT_CLASS_FADER = 0x50000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_TIME 0x60000000L")]
        public const int MIXERCONTROL_CT_CLASS_TIME = 0x60000000;

        [NativeTypeName("#define MIXERCONTROL_CT_CLASS_LIST 0x70000000L")]
        public const int MIXERCONTROL_CT_CLASS_LIST = 0x70000000;

        [NativeTypeName("#define MIXERCONTROL_CT_SUBCLASS_MASK 0x0F000000L")]
        public const int MIXERCONTROL_CT_SUBCLASS_MASK = 0x0F000000;

        [NativeTypeName("#define MIXERCONTROL_CT_SC_SWITCH_BOOLEAN 0x00000000L")]
        public const int MIXERCONTROL_CT_SC_SWITCH_BOOLEAN = 0x00000000;

        [NativeTypeName("#define MIXERCONTROL_CT_SC_SWITCH_BUTTON 0x01000000L")]
        public const int MIXERCONTROL_CT_SC_SWITCH_BUTTON = 0x01000000;

        [NativeTypeName("#define MIXERCONTROL_CT_SC_METER_POLLED 0x00000000L")]
        public const int MIXERCONTROL_CT_SC_METER_POLLED = 0x00000000;

        [NativeTypeName("#define MIXERCONTROL_CT_SC_TIME_MICROSECS 0x00000000L")]
        public const int MIXERCONTROL_CT_SC_TIME_MICROSECS = 0x00000000;

        [NativeTypeName("#define MIXERCONTROL_CT_SC_TIME_MILLISECS 0x01000000L")]
        public const int MIXERCONTROL_CT_SC_TIME_MILLISECS = 0x01000000;

        [NativeTypeName("#define MIXERCONTROL_CT_SC_LIST_SINGLE 0x00000000L")]
        public const int MIXERCONTROL_CT_SC_LIST_SINGLE = 0x00000000;

        [NativeTypeName("#define MIXERCONTROL_CT_SC_LIST_MULTIPLE 0x01000000L")]
        public const int MIXERCONTROL_CT_SC_LIST_MULTIPLE = 0x01000000;

        [NativeTypeName("#define MIXERCONTROL_CT_UNITS_MASK 0x00FF0000L")]
        public const int MIXERCONTROL_CT_UNITS_MASK = 0x00FF0000;

        [NativeTypeName("#define MIXERCONTROL_CT_UNITS_CUSTOM 0x00000000L")]
        public const int MIXERCONTROL_CT_UNITS_CUSTOM = 0x00000000;

        [NativeTypeName("#define MIXERCONTROL_CT_UNITS_BOOLEAN 0x00010000L")]
        public const int MIXERCONTROL_CT_UNITS_BOOLEAN = 0x00010000;

        [NativeTypeName("#define MIXERCONTROL_CT_UNITS_SIGNED 0x00020000L")]
        public const int MIXERCONTROL_CT_UNITS_SIGNED = 0x00020000;

        [NativeTypeName("#define MIXERCONTROL_CT_UNITS_UNSIGNED 0x00030000L")]
        public const int MIXERCONTROL_CT_UNITS_UNSIGNED = 0x00030000;

        [NativeTypeName("#define MIXERCONTROL_CT_UNITS_DECIBELS 0x00040000L")]
        public const int MIXERCONTROL_CT_UNITS_DECIBELS = 0x00040000;

        [NativeTypeName("#define MIXERCONTROL_CT_UNITS_PERCENT 0x00050000L")]
        public const int MIXERCONTROL_CT_UNITS_PERCENT = 0x00050000;

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_CUSTOM (MIXERCONTROL_CT_CLASS_CUSTOM | MIXERCONTROL_CT_UNITS_CUSTOM)")]
        public const int MIXERCONTROL_CONTROLTYPE_CUSTOM = (0x00000000 | 0x00000000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_BOOLEANMETER (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_BOOLEAN)")]
        public const int MIXERCONTROL_CONTROLTYPE_BOOLEANMETER = (0x10000000 | 0x00000000 | 0x00010000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_SIGNEDMETER (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_SIGNED)")]
        public const int MIXERCONTROL_CONTROLTYPE_SIGNEDMETER = (0x10000000 | 0x00000000 | 0x00020000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_PEAKMETER (MIXERCONTROL_CONTROLTYPE_SIGNEDMETER + 1)")]
        public const int MIXERCONTROL_CONTROLTYPE_PEAKMETER = ((0x10000000 | 0x00000000 | 0x00020000) + 1);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_UNSIGNEDMETER (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_UNSIGNED)")]
        public const int MIXERCONTROL_CONTROLTYPE_UNSIGNEDMETER = (0x10000000 | 0x00000000 | 0x00030000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_BOOLEAN (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BOOLEAN | MIXERCONTROL_CT_UNITS_BOOLEAN)")]
        public const int MIXERCONTROL_CONTROLTYPE_BOOLEAN = (0x20000000 | 0x00000000 | 0x00010000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_ONOFF (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 1)")]
        public const int MIXERCONTROL_CONTROLTYPE_ONOFF = ((0x20000000 | 0x00000000 | 0x00010000) + 1);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_MUTE (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 2)")]
        public const int MIXERCONTROL_CONTROLTYPE_MUTE = ((0x20000000 | 0x00000000 | 0x00010000) + 2);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_MONO (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 3)")]
        public const int MIXERCONTROL_CONTROLTYPE_MONO = ((0x20000000 | 0x00000000 | 0x00010000) + 3);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_LOUDNESS (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 4)")]
        public const int MIXERCONTROL_CONTROLTYPE_LOUDNESS = ((0x20000000 | 0x00000000 | 0x00010000) + 4);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_STEREOENH (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 5)")]
        public const int MIXERCONTROL_CONTROLTYPE_STEREOENH = ((0x20000000 | 0x00000000 | 0x00010000) + 5);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_BASS_BOOST (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 0x00002277)")]
        public const int MIXERCONTROL_CONTROLTYPE_BASS_BOOST = ((0x20000000 | 0x00000000 | 0x00010000) + 0x00002277);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_BUTTON (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BUTTON | MIXERCONTROL_CT_UNITS_BOOLEAN)")]
        public const int MIXERCONTROL_CONTROLTYPE_BUTTON = (0x20000000 | 0x01000000 | 0x00010000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_DECIBELS (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_DECIBELS)")]
        public const int MIXERCONTROL_CONTROLTYPE_DECIBELS = (0x30000000 | 0x00040000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_SIGNED (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_SIGNED)")]
        public const int MIXERCONTROL_CONTROLTYPE_SIGNED = (0x30000000 | 0x00020000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_UNSIGNED (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_UNSIGNED)")]
        public const int MIXERCONTROL_CONTROLTYPE_UNSIGNED = (0x30000000 | 0x00030000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_PERCENT (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_PERCENT)")]
        public const int MIXERCONTROL_CONTROLTYPE_PERCENT = (0x30000000 | 0x00050000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_SLIDER (MIXERCONTROL_CT_CLASS_SLIDER | MIXERCONTROL_CT_UNITS_SIGNED)")]
        public const int MIXERCONTROL_CONTROLTYPE_SLIDER = (0x40000000 | 0x00020000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_PAN (MIXERCONTROL_CONTROLTYPE_SLIDER + 1)")]
        public const int MIXERCONTROL_CONTROLTYPE_PAN = ((0x40000000 | 0x00020000) + 1);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_QSOUNDPAN (MIXERCONTROL_CONTROLTYPE_SLIDER + 2)")]
        public const int MIXERCONTROL_CONTROLTYPE_QSOUNDPAN = ((0x40000000 | 0x00020000) + 2);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_FADER (MIXERCONTROL_CT_CLASS_FADER | MIXERCONTROL_CT_UNITS_UNSIGNED)")]
        public const int MIXERCONTROL_CONTROLTYPE_FADER = (0x50000000 | 0x00030000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_VOLUME (MIXERCONTROL_CONTROLTYPE_FADER + 1)")]
        public const int MIXERCONTROL_CONTROLTYPE_VOLUME = ((0x50000000 | 0x00030000) + 1);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_BASS (MIXERCONTROL_CONTROLTYPE_FADER + 2)")]
        public const int MIXERCONTROL_CONTROLTYPE_BASS = ((0x50000000 | 0x00030000) + 2);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_TREBLE (MIXERCONTROL_CONTROLTYPE_FADER + 3)")]
        public const int MIXERCONTROL_CONTROLTYPE_TREBLE = ((0x50000000 | 0x00030000) + 3);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_EQUALIZER (MIXERCONTROL_CONTROLTYPE_FADER + 4)")]
        public const int MIXERCONTROL_CONTROLTYPE_EQUALIZER = ((0x50000000 | 0x00030000) + 4);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_SINGLESELECT (MIXERCONTROL_CT_CLASS_LIST | MIXERCONTROL_CT_SC_LIST_SINGLE | MIXERCONTROL_CT_UNITS_BOOLEAN)")]
        public const int MIXERCONTROL_CONTROLTYPE_SINGLESELECT = (0x70000000 | 0x00000000 | 0x00010000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_MUX (MIXERCONTROL_CONTROLTYPE_SINGLESELECT + 1)")]
        public const int MIXERCONTROL_CONTROLTYPE_MUX = ((0x70000000 | 0x00000000 | 0x00010000) + 1);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT (MIXERCONTROL_CT_CLASS_LIST | MIXERCONTROL_CT_SC_LIST_MULTIPLE | MIXERCONTROL_CT_UNITS_BOOLEAN)")]
        public const int MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT = (0x70000000 | 0x01000000 | 0x00010000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_MIXER (MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT + 1)")]
        public const int MIXERCONTROL_CONTROLTYPE_MIXER = ((0x70000000 | 0x01000000 | 0x00010000) + 1);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_MICROTIME (MIXERCONTROL_CT_CLASS_TIME | MIXERCONTROL_CT_SC_TIME_MICROSECS | MIXERCONTROL_CT_UNITS_UNSIGNED)")]
        public const int MIXERCONTROL_CONTROLTYPE_MICROTIME = (0x60000000 | 0x00000000 | 0x00030000);

        [NativeTypeName("#define MIXERCONTROL_CONTROLTYPE_MILLITIME (MIXERCONTROL_CT_CLASS_TIME | MIXERCONTROL_CT_SC_TIME_MILLISECS | MIXERCONTROL_CT_UNITS_UNSIGNED)")]
        public const int MIXERCONTROL_CONTROLTYPE_MILLITIME = (0x60000000 | 0x01000000 | 0x00030000);

        [NativeTypeName("#define mixerGetLineControls mixerGetLineControlsW")]
        public static delegate*<HMIXEROBJ, MIXERLINECONTROLSW*, uint, uint> mixerGetLineControls => &mixerGetLineControlsW;

        [NativeTypeName("#define MIXER_GETLINECONTROLSF_ALL 0x00000000L")]
        public const int MIXER_GETLINECONTROLSF_ALL = 0x00000000;

        [NativeTypeName("#define MIXER_GETLINECONTROLSF_ONEBYID 0x00000001L")]
        public const int MIXER_GETLINECONTROLSF_ONEBYID = 0x00000001;

        [NativeTypeName("#define MIXER_GETLINECONTROLSF_ONEBYTYPE 0x00000002L")]
        public const int MIXER_GETLINECONTROLSF_ONEBYTYPE = 0x00000002;

        [NativeTypeName("#define MIXER_GETLINECONTROLSF_QUERYMASK 0x0000000FL")]
        public const int MIXER_GETLINECONTROLSF_QUERYMASK = 0x0000000F;

        [NativeTypeName("#define mixerGetControlDetails mixerGetControlDetailsW")]
        public static delegate*<HMIXEROBJ, MIXERCONTROLDETAILS*, uint, uint> mixerGetControlDetails => &mixerGetControlDetailsW;

        [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_VALUE 0x00000000L")]
        public const int MIXER_GETCONTROLDETAILSF_VALUE = 0x00000000;

        [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_LISTTEXT 0x00000001L")]
        public const int MIXER_GETCONTROLDETAILSF_LISTTEXT = 0x00000001;

        [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_QUERYMASK 0x0000000FL")]
        public const int MIXER_GETCONTROLDETAILSF_QUERYMASK = 0x0000000F;

        [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_VALUE 0x00000000L")]
        public const int MIXER_SETCONTROLDETAILSF_VALUE = 0x00000000;

        [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_CUSTOM 0x00000001L")]
        public const int MIXER_SETCONTROLDETAILSF_CUSTOM = 0x00000001;

        [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_QUERYMASK 0x0000000FL")]
        public const int MIXER_SETCONTROLDETAILSF_QUERYMASK = 0x0000000F;
    }
}
