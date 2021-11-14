// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        public static void FreeConfirmConflictItem(CONFIRM_CONFLICT_ITEM* pcci)
        {
            if ((pcci->pShellItem) != null)
            {
                pcci->pShellItem->Release();
            }

            CoTaskMemFree(pcci->pszOriginalName);
            CoTaskMemFree(pcci->pszAlternateName);
            CoTaskMemFree(pcci->pszLocationShort);
            CoTaskMemFree(pcci->pszLocationFull);
            Unsafe.InitBlockUnaligned((pcci), 0, ((uint)(sizeof(CONFIRM_CONFLICT_ITEM))));
        }
    }
}
