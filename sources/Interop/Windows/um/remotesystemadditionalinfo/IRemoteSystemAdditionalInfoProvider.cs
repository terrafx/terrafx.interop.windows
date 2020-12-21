// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/remotesystemadditionalinfo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EEAA3D5F-EC63-4D27-AF38-E86B1D7292CB")]
    [NativeTypeName("struct IRemoteSystemAdditionalInfoProvider : IUnknown")]
    public unsafe partial struct IRemoteSystemAdditionalInfoProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IRemoteSystemAdditionalInfoProvider*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemAdditionalInfoProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IRemoteSystemAdditionalInfoProvider*, uint>)(lpVtbl[1]))((IRemoteSystemAdditionalInfoProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IRemoteSystemAdditionalInfoProvider*, uint>)(lpVtbl[2]))((IRemoteSystemAdditionalInfoProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdditionalInfo([NativeTypeName("HSTRING *")] IntPtr* deduplicationId, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** mapView)
        {
            return ((delegate* unmanaged[Stdcall]<IRemoteSystemAdditionalInfoProvider*, IntPtr*, Guid*, void**, int>)(lpVtbl[3]))((IRemoteSystemAdditionalInfoProvider*)Unsafe.AsPointer(ref this), deduplicationId, riid, mapView);
        }
    }
}
