// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7FB7B48F-531D-44A2-BCB3-5AD5A134B3DC")]
    public unsafe partial struct IAudioVolumeLevel
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, Guid*, void**, int>)(lpVtbl[0]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, uint>)(lpVtbl[1]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, uint>)(lpVtbl[2]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* pcChannels)
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, uint*, int>)(lpVtbl[3]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), pcChannels);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLevelRange([NativeTypeName("UINT")] uint nChannel, [NativeTypeName("float *")] float* pfMinLevelDB, [NativeTypeName("float *")] float* pfMaxLevelDB, [NativeTypeName("float *")] float* pfStepping)
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, uint, float*, float*, float*, int>)(lpVtbl[4]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), nChannel, pfMinLevelDB, pfMaxLevelDB, pfStepping);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLevel([NativeTypeName("UINT")] uint nChannel, [NativeTypeName("float *")] float* pfLevelDB)
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, uint, float*, int>)(lpVtbl[5]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLevel([NativeTypeName("UINT")] uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, uint, float, Guid*, int>)(lpVtbl[6]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLevelUniform(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, float, Guid*, int>)(lpVtbl[7]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLevelAllChannels([NativeTypeName("float []")] float* aLevelsDB, [NativeTypeName("ULONG")] uint cChannels, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioVolumeLevel*, float*, uint, Guid*, int>)(lpVtbl[8]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), aLevelsDB, cChannels, pguidEventContext);
        }
    }
}
