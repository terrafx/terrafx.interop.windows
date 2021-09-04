// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A359DEC5-E813-4834-8A2A-BA7F1D777D76")]
    [NativeTypeName("struct IWbemBackupRestoreEx : IWbemBackupRestore")]
    public unsafe partial struct IWbemBackupRestoreEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemBackupRestoreEx*, Guid*, void**, int>)(lpVtbl[0]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemBackupRestoreEx*, uint>)(lpVtbl[1]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemBackupRestoreEx*, uint>)(lpVtbl[2]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Backup([NativeTypeName("LPCWSTR")] ushort* strBackupToFile, [NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemBackupRestoreEx*, ushort*, int, int>)(lpVtbl[3]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this), strBackupToFile, lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Restore([NativeTypeName("LPCWSTR")] ushort* strRestoreFromFile, [NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemBackupRestoreEx*, ushort*, int, int>)(lpVtbl[4]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this), strRestoreFromFile, lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IWbemBackupRestoreEx*, int>)(lpVtbl[5]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged<IWbemBackupRestoreEx*, int>)(lpVtbl[6]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this));
        }
    }
}
