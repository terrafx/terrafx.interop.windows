// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("989191AC-28FF-4CF0-9584-E0D078BC2396")]
    [NativeTypeName("struct ILaunchSourceAppUserModelId : IUnknown")]
    public unsafe partial struct ILaunchSourceAppUserModelId
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILaunchSourceAppUserModelId*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchSourceAppUserModelId*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILaunchSourceAppUserModelId*, uint>)(lpVtbl[1]))((ILaunchSourceAppUserModelId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILaunchSourceAppUserModelId*, uint>)(lpVtbl[2]))((ILaunchSourceAppUserModelId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppUserModelId([NativeTypeName("LPWSTR *")] ushort** launchingApp)
        {
            return ((delegate* unmanaged<ILaunchSourceAppUserModelId*, ushort**, int>)(lpVtbl[3]))((ILaunchSourceAppUserModelId*)Unsafe.AsPointer(ref this), launchingApp);
        }
    }
}
