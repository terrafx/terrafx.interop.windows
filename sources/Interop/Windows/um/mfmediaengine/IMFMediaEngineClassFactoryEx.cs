// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C56156C6-EA5B-48A5-9DF8-FBE035D0929E")]
    [NativeTypeName("struct IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory")]
    public unsafe partial struct IMFMediaEngineClassFactoryEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, uint>)(lpVtbl[1]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, uint>)(lpVtbl[2]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttr, [NativeTypeName("IMFMediaEngine **")] IMFMediaEngine** ppPlayer)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)(lpVtbl[3]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppPlayer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTimeRange([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppTimeRange)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, IMFMediaTimeRange**, int>)(lpVtbl[4]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), ppTimeRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateError([NativeTypeName("IMFMediaError **")] IMFMediaError** ppError)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, IMFMediaError**, int>)(lpVtbl[5]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), ppError);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMediaSourceExtension([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttr, [NativeTypeName("IMFMediaSourceExtension **")] IMFMediaSourceExtension** ppMSE)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)(lpVtbl[6]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppMSE);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMediaKeys([NativeTypeName("BSTR")] ushort* keySystem, [NativeTypeName("BSTR")] ushort* cdmStorePath, [NativeTypeName("IMFMediaKeys **")] IMFMediaKeys** ppKeys)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, ushort*, ushort*, IMFMediaKeys**, int>)(lpVtbl[7]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), keySystem, cdmStorePath, ppKeys);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsTypeSupported([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR")] ushort* keySystem, [NativeTypeName("BOOL *")] int* isSupported)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactoryEx*, ushort*, ushort*, int*, int>)(lpVtbl[8]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), type, keySystem, isSupported);
        }
    }
}
