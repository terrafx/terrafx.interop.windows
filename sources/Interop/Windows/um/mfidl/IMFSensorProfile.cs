// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F765D1-8DAB-4107-846D-56BAF72215E7")]
    public unsafe partial struct IMFSensorProfile
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSensorProfile*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSensorProfile*, uint>)(lpVtbl[1]))((IMFSensorProfile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSensorProfile*, uint>)(lpVtbl[2]))((IMFSensorProfile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfileId([NativeTypeName("SENSORPROFILEID *")] SENSORPROFILEID* pId)
        {
            return ((delegate* stdcall<IMFSensorProfile*, SENSORPROFILEID*, int>)(lpVtbl[3]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), pId);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddProfileFilter([NativeTypeName("UINT32")] uint StreamId, [NativeTypeName("LPCWSTR")] ushort* wzFilterSetString)
        {
            return ((delegate* stdcall<IMFSensorProfile*, uint, ushort*, int>)(lpVtbl[4]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), StreamId, wzFilterSetString);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsMediaTypeSupported([NativeTypeName("UINT32")] uint StreamId, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("BOOL *")] int* pfSupported)
        {
            return ((delegate* stdcall<IMFSensorProfile*, uint, IMFMediaType*, int*, int>)(lpVtbl[5]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), StreamId, pMediaType, pfSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddBlockedControl([NativeTypeName("LPCWSTR")] ushort* wzBlockedControl)
        {
            return ((delegate* stdcall<IMFSensorProfile*, ushort*, int>)(lpVtbl[6]))((IMFSensorProfile*)Unsafe.AsPointer(ref this), wzBlockedControl);
        }
    }
}
