// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISpeechGrammarRuleStateTransitions" />struct.</summary>
    public static unsafe class ISpeechGrammarRuleStateTransitionsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISpeechGrammarRuleStateTransitions" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISpeechGrammarRuleStateTransitions).GUID, Is.EqualTo(IID_ISpeechGrammarRuleStateTransitions));
        }

        /// <summary>Validates that the <see cref="ISpeechGrammarRuleStateTransitions" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISpeechGrammarRuleStateTransitions>(), Is.EqualTo(sizeof(ISpeechGrammarRuleStateTransitions)));
        }

        /// <summary>Validates that the <see cref="ISpeechGrammarRuleStateTransitions" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISpeechGrammarRuleStateTransitions).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISpeechGrammarRuleStateTransitions" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISpeechGrammarRuleStateTransitions), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISpeechGrammarRuleStateTransitions), Is.EqualTo(4));
            }
        }
    }
}
