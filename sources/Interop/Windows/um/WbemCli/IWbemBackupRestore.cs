// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C49E32C7-BC8B-11D2-85D4-00105A1F8304")]
    [NativeTypeName("struct IWbemBackupRestore : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWbemBackupRestore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemBackupRestore*, Guid*, void**, int>)(lpVtbl[0]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemBackupRestore*, uint>)(lpVtbl[1]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemBackupRestore*, uint>)(lpVtbl[2]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Backup([NativeTypeName("LPCWSTR")] ushort* strBackupToFile, [NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemBackupRestore*, ushort*, int, int>)(lpVtbl[3]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this), strBackupToFile, lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Restore([NativeTypeName("LPCWSTR")] ushort* strRestoreFromFile, [NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemBackupRestore*, ushort*, int, int>)(lpVtbl[4]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this), strRestoreFromFile, lFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemBackupRestore*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemBackupRestore*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemBackupRestore*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemBackupRestore*, ushort*, int, int> Backup;

            [NativeTypeName("HRESULT (LPCWSTR, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemBackupRestore*, ushort*, int, int> Restore;
        }
    }
}
