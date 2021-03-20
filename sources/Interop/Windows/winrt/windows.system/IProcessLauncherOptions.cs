// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3080B9CF-F444-4A83-BEAF-A549A0F3229C")]
    [NativeTypeName("struct IProcessLauncherOptions : IInspectable")]
    public unsafe partial struct IProcessLauncherOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, Guid*, void**, int>)(lpVtbl[0]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, uint>)(lpVtbl[1]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, uint>)(lpVtbl[2]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IntPtr*, int>)(lpVtbl[4]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, TrustLevel*, int>)(lpVtbl[5]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StandardInput([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IInputStream**, int>)(lpVtbl[6]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StandardInput([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* value)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IInputStream*, int>)(lpVtbl[7]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StandardOutput([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IOutputStream**, int>)(lpVtbl[8]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StandardOutput([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* value)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IOutputStream*, int>)(lpVtbl[9]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StandardError([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IOutputStream**, int>)(lpVtbl[10]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StandardError([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* value)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IOutputStream*, int>)(lpVtbl[11]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WorkingDirectory([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IntPtr*, int>)(lpVtbl[12]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_WorkingDirectory([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IProcessLauncherOptions*, IntPtr, int>)(lpVtbl[13]))((IProcessLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }
    }
}
