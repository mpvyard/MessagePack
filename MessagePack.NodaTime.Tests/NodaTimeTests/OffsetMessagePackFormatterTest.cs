﻿// Copyright (c) ARK LTD. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for
// license information. 
using MessagePack.NodaTime.Tests.Helpers;
using NodaTime;
using Xunit;

namespace MessagePack.NodaTime.Tests
{
    [Collection("ResolverCollection")]
    public class OffsetMessagePackFormatterTest
    {
        [Fact]
        public void OffsetTest()
        {
            Offset offSet = Offset.FromHours(1);
            Assert.Equal(TestTools.Convert(offSet), offSet);
        }

        [Fact]
        public void NullableOffsetTest()
        {
            Offset? offSet = null;
            Assert.Equal(TestTools.Convert(offSet), offSet);
        }               

        [Fact]
        public void OffsetArrayTest()
        {
            Offset[] offSet = new Offset[]
                { Offset.FromHoursAndMinutes(1, 3),
                Offset.FromSeconds(80),
                Offset.FromMilliseconds(200),
                Offset.FromHours(3),
                Offset.FromNanoseconds(99)
            };
            Assert.Equal(TestTools.Convert(offSet), offSet);
        }

        [Fact]
        public void NullableOffsetArrayTest()
        {
            Offset?[] offSet = new Offset?[] {
                null,
                null,
                null,
                null,
                null
            };
            Assert.Equal(TestTools.Convert(offSet), offSet);
        }        
    }
}
